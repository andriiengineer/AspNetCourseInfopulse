namespace HW1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = "Lexus";
        public string Model { get; set; } = "NX";
        public int Price { get; set; } = 35000;
        public FuelType FuelType { get; set; } = FuelType.Hybrid;
    }
}
