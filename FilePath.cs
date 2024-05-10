namespace osuezmapsremover
{
    public class FilePath
    {
        static public string GetOsuDir()
        {
            if (File.Exists("dir.txt"))
            {
                return File.ReadAllText("dir.txt").Replace(@"\", "\\") + "\\Songs";
            }
            else
            {
                return GetRawOsuDir() + "\\Songs";
            }
        }

        static public string GetRawOsuDir()
        {
            if (File.Exists("dir.txt"))
            {
                return File.ReadAllText("dir.txt").Replace(@"\", "\\");
            }
            else
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\osu!";
            }
        }
    }
}
