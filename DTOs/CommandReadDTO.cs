namespace Commander.DTOs
{
    public class CommandReadDTO
    {
        public int Id { get; set; }
        public string? HowTo { get; set; }
        public string? Line { get; set; }

        // Removed Platform item to show irrelvant items aren't given to client

    }
}