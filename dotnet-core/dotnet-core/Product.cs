namespace dotnet_core
{
    public record Product
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int Price { get; set; }
    }
}
