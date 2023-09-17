using HumanResoursesApplication.Interfaces;

namespace HumanResoursesApplication.Services
{
    public interface IFullTimeEmployeeService
{
        Task<List<FullTimeEmployee>> GetFullTimeEmployees();
        Task<List<FullTimeEmployee>> AddFullTimeEmployee(FullTimeEmployee employee);
        Task<FullTimeEmployee?> GetAFullTimeEmployee(int id);
        Task<List<FullTimeEmployee>?> UpdateFullTimeEmployee(int id, FullTimeEmployee request);
        Task<List<FullTimeEmployee>?> DeleteAFullTimeEmployee(int id);
}
}
