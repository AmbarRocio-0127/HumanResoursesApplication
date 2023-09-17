
namespace HumanResoursesApplication.Services
{
    public interface ITemporaryEmployeeService
{
        Task<List<TemporaryEmployee>> GetTemporaryEmployees();
        Task<TemporaryEmployee?> GetATemporaryEmployee(int id);
        Task<List<TemporaryEmployee>> AddTemporaryEmployee(TemporaryEmployee Temp);
        Task<List<TemporaryEmployee>?> UpdateTemporaryEmployee(int id, TemporaryEmployee request);
        Task<List<TemporaryEmployee>?> DeleteATempTimeEmployee(int id);
}
}
