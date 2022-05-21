namespace Temisto.Importer.Models
{
    public record Hero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? HeroName { get; set; }
        public string? Universe { get; set; }
        public int Gender { get; set; }

        public List<Power>? Powers { get; set; }
    }
}
