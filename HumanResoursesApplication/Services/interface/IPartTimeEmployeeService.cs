namespace HumanResoursesApplication.Services
{
    public interface IPartTimeEmployeeService
{
        Task<List<PartTimeEmployee>> GetPartTimeEmployees();
        Task<PartTimeEmployee?> GetAPartTimeEmployee(int id);
        Task<List<PartTimeEmployee>> AddPartTimeEmployee(PartTimeEmployee pte);
        Task<List<PartTimeEmployee>?> UpdatePartTimeEmployee(int id, PartTimeEmployee request);
        Task<List<PartTimeEmployee>?> DeleteAPartTimeEmployee(int id);
}
}
