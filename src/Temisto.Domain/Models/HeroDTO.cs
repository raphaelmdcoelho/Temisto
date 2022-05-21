namespace Temisto.Domain.Models
{
    public record HeroDTO
    {
        public string? Name { get; set; }
        public string? HeroName { get; set; }
        public int? Age { get; set; }
        public char? Gender { get; set; }

        public string? FullName { get { return $"{Name}/{HeroName}"; } set { FullName = value; } }
    }
}
