namespace Car.Models
{
    public class Cars
    {
        public Guid CarsID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public bool New { get; set; }
    }
}
