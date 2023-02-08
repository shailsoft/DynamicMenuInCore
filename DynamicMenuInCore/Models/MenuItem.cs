namespace DynamicMenuInCore.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? Url { get; set; }
    }
}
