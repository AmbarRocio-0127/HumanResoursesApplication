using HumanResoursesApplication.Interfaces;
namespace HumanResoursesApplication.Factory
{
    public class FactoryEmployee
    {
            public static IEmployee CrearEmpleado(string type)
            {
                switch (type)
                {
                    case "FullTimeEmployee":
                        return new FullTimeEmployee();
                    case "PartTimeEmployee":
                        return new PartTimeEmployee();
                    case "TemporeryEmployee":
                        return new TemporaryEmployee();
                    default:
                        throw new ArgumentException("Employee Type Not Valid.");
                }
            }
        

    }

}