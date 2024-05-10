using System.Diagnostics;
using System.Text.Json;

namespace osuezmapsremover
{
    public class Main
    {
        private readonly Form form;

        public string[] files { get; set; }

        public List<Beatmap> Beatmaps { get; set; }

        public List<Beatmap> BeatmapsToDelete { get; set; }

        public List<string> DirsToDelete { get; set; }

        public Main(Form form)
        {
            this.form = form;

            files = Directory.GetFiles(FilePath.GetOsuDir(), "*.osu", SearchOption.AllDirectories);
            Beatmaps = new List<Beatmap>();
            BeatmapsToDelete = new List<Beatmap>();
            DirsToDelete = new List<string>();
        }

        private void PrintMaps() // debug
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            GetAllMaps();

            sw.Stop();

            MessageBox.Show($"time: {sw.Elapsed.TotalSeconds} s");

            MessageBox.Show($"len: {Beatmaps.Count}");

            foreach (Beatmap beatmap in Beatmaps)
            {
                MessageBox.Show($"""
                            path: {beatmap.Path}
                            title: {beatmap.Title}
                            artist: {beatmap.Artist}
                            beatmapset_id: {beatmap.BeatmapSet_ID}
                            id: {beatmap.Beatmap_ID}
                            """);
            }
        }

        public void CreateJSONFile()
        {
            if (Beatmaps.Count > 0)
            {
                SaveFileDialog saveFileDialog = new()
                {
                    InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString(),
                    Title = "Save JSON",
                    DefaultExt = "json",
                    FileName = ".json",
                    Filter = "JSON (*.json)|*.txt|All files (*.*)|*.*",
                    RestoreDirectory = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json_content = JsonSerializer.Serialize(Beatmaps, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                    File.WriteAllText(saveFileDialog.FileName, json_content);

                    MessageBox.Show($"Saved as {saveFileDialog.FileName}!", form.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void GetAllMaps()
        {
            string title_pattern = "Title:";
            string diff_pattern = "Version:";
            string artist_pattern = "Artist:";
            string mapper_pattern = "Creator:";
            string set_id_pattern = "BeatmapSetID:";
            string id_pattern = "BeatmapID:";

            int[] line_numbers = [21, 23, 25, 30, 29]; // metadata lines (unused)

            foreach (string? file in files)
            {
                string path = file;
                string? title = null;
                string? diff = null;
                string? artist = null;
                string? mapper = null;
                int? set_id = null;
                int? beatmap_id = null;

                string[] lines;

                try
                {
                    lines = File.ReadLines(path).Take(line_numbers.Max() + 1).ToArray();
                }
                catch (IOException) // if file doesnt exist for some reason
                {
                    continue;
                }

                foreach (string? line in lines)
                {
                    string? line_trimmed = line.Trim();

                    #region this part is really shit so dont look
                    if (line_trimmed.StartsWith(title_pattern))
                    {
                        title = line_trimmed.Split(title_pattern)[1];
                    }

                    if (line_trimmed.StartsWith(artist_pattern))
                    {
                        artist = line_trimmed.Split(artist_pattern)[1];
                    }

                    if (line_trimmed.StartsWith(mapper_pattern))
                    {
                        mapper = line_trimmed.Split(mapper_pattern)[1];
                    }

                    if (line_trimmed.StartsWith(diff_pattern))
                    {
                        diff = line_trimmed.Split(diff_pattern)[1];
                    }

                    if (line_trimmed.StartsWith(id_pattern))
                    {
                        beatmap_id = int.Parse(line_trimmed.Split(id_pattern)[1]);
                    }

                    if (line_trimmed.StartsWith(set_id_pattern))
                    {
                        set_id = int.Parse(line_trimmed.Split(set_id_pattern)[1]);
                    }
                    #endregion

                    if (line_trimmed == "[Difficulty]") // when the file is at the end of the metadata, stop reading
                    {
                        break;
                    }
                }

                Beatmaps.Add(new Beatmap(path, title, artist, mapper, diff, beatmap_id, set_id));
            }
        }

        public void RunTool()
        {
            int count = 0;
            string content = form.DiffBoxComponent.Text;

            foreach (Beatmap beatmap in BeatmapsToDelete)
            {
                File.Delete(beatmap.Path);
                count++;
                form.ProgressBar.Value = count;
            }

            foreach (string path in DirsToDelete)
            {
                Directory.Delete(path, true);
                count++;
                form.ProgressBar.Value = count;
            }

            MessageBox.Show($"{count} {content} maps have been deleted!", form.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void DisplayMaps()
        {
            BeatmapsToDelete.Clear();
            DirsToDelete.Clear();

            form.ProgressBar.Value = 0;

            form.LabelShowComponent.Text = "Progress:";
            string loading_text = " | Loading...";
            form.Text += loading_text;

            int count = 0;

            form.FileTextBox.Text = string.Empty;

            string content = form.DiffBoxComponent.Text;
            string? search_by = string.Empty;

            if (!string.IsNullOrWhiteSpace(content))
            {

                foreach (Beatmap beatmap in Beatmaps)
                {
                    switch (form.SearchByBox.SelectedIndex)
                    {
                        case (int)SearchByBoxIndex.Title: // title
                            search_by = beatmap.Title;
                            break;

                        case (int)SearchByBoxIndex.Artist: // artist
                            search_by = beatmap.Artist;
                            break;

                        case (int)SearchByBoxIndex.Mapper: // mapper
                            search_by = beatmap.Mapper;
                            break;

                        case (int)SearchByBoxIndex.Diff: // diff
                            search_by = beatmap.Diff;
                            break;

                        case (int)SearchByBoxIndex.Beatmap_ID: // beatmap id
                            search_by = beatmap.Beatmap_ID.ToString();
                            break;

                        case (int)SearchByBoxIndex.BeatmapSet_ID: // beatset id
                            search_by = beatmap.BeatmapSet_ID.ToString();
                            break;
                    }

                    //          case sensitivity check
                    if (!form.CaseSensitiveButton.Checked && search_by != null && content != null)
                    {
                        search_by = search_by.ToLower();
                        content = content.ToLower();
                    }

                    if (search_by != null && content != null && search_by.Contains(content))
                    {
                        if (Directory.GetFiles(Directory.GetParent(beatmap.Path).ToString(), "*.osu", SearchOption.TopDirectoryOnly).Length == 1) //prevent osu glitch
                        {
                            DirsToDelete.Add(Directory.GetParent(beatmap.Path).FullName);
                        }
                        else
                        {
                            BeatmapsToDelete.Add(beatmap); // maybe change to beatmap.path
                        }


                        count++;
                        form.FileTextBox.Text += $"{beatmap.Artist} - {beatmap.Title} [{beatmap.Diff}] ({beatmap.Mapper}){Environment.NewLine}";
                    }
                }
            }

            form.ProgressBar.Maximum = count;
            form.Text = form.Text.Remove(form.Text.Length - loading_text.Length); // remove loading from window name

            if (count > 0)
            {
                form.FileTextBox.Text = $"Found {count} beatmaps.{Environment.NewLine}{Environment.NewLine}" + form.FileTextBox.Text;
            }
            else
            {
                form.FileTextBox.Text = $"No beatmaps found.";
            }
        }

        public static string? GetOsuUsername()
        {
            if (File.Exists(FilePath.GetRawOsuDir() + "\\osu!." + Environment.UserName + ".cfg")) // get osu username
            {
                var lines = File.ReadLines(FilePath.GetRawOsuDir() + "\\osu!." + Environment.UserName + ".cfg");
                string split_pattern = "Username = ";
                foreach (var line in lines)
                {
                    if (line.StartsWith(split_pattern))
                    {
                        return line.Split(split_pattern)[1]; // fix this
                    }
                }
            }

            return "(username not found)";
        }
    }
}
