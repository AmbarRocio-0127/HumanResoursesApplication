namespace HumanResoursesApplication.Interfaces
{
    public interface IEmployee
    {
        string Name { get; set; }
        string LastName { get; set; }
        long Cedula { get; set; }
        string Department { get; set; }
      
    }
}
