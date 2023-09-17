namespace HumanResoursesApplication.DTOs
{
    public class TemporaryEmployeeDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Cedula { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal WorkedHours { get; set; }
        public decimal PricePerHour { get; set; }
        public long AccountNumber { get; set; }
    }
}
