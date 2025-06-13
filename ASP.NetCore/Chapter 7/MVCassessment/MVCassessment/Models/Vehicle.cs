namespace MVCassessment.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleModel { get; set; }

        public string Category { get; set; }
        public int RentPerDay { get; set; }
        public string IsAvailableVehicle { get; set; }
    }
}
