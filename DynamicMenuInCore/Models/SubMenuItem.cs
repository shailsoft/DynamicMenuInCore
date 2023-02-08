namespace DynamicMenuInCore.Models
{
    public class SubMenuItem
    {
        public int Id { get; set; }
        public string? SName { get; set; }
        public string? SControllerName { get; set; }
        public string? SActionName { get; set; }
        public string? SUrl { get; set; }
        public int? MenuId { get; set; }

    }
}
