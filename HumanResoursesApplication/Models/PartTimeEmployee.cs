
using HumanResoursesApplication.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace HumanResoursesApplication.Models
{
    public class PartTimeEmployee : IEmployee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public long Cedula { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public int DailyHours { get; set; }
        public decimal PricePerHour { get; set; }
        public long AccountNumber { get; set; }
    }
}
