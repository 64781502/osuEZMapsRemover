namespace osuezmapsremover
{
    public class Beatmap
    {
        public Beatmap(string path, string? title, string? artist, string? mapper, string? diff, int? beatmap_ID, int? beatmapSet_ID)
        {
            Path = path;
            Title = title;
            Artist = artist;
            Mapper = mapper;
            Diff = diff;
            Beatmap_ID = beatmap_ID;
            BeatmapSet_ID = beatmapSet_ID;
        }

        public string Path { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Mapper { get; set; }
        public string? Diff { get; set; }
        public int? Beatmap_ID { get; set; }
        public int? BeatmapSet_ID { get; set; }
    }
}
