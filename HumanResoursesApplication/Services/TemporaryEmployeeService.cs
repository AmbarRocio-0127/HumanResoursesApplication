using HumanResoursesApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace HumanResoursesApplication.Services
{
    public class TemporaryEmployeeService : ITemporaryEmployeeService
    {

        private readonly DataContext _context;
        public TemporaryEmployeeService(DataContext context)
        {
            _context = context;
        }
        async Task<List<TemporaryEmployee>> ITemporaryEmployeeService.AddTemporaryEmployee(TemporaryEmployee Temp)
        {
                _context.Temporaryemployee.Add(Temp);
                await _context.SaveChangesAsync();
                return await _context.Temporaryemployee.ToListAsync();
        }

        async Task<List<TemporaryEmployee>?> ITemporaryEmployeeService.DeleteATempTimeEmployee(int id)
        {
            var Employee = await _context.Temporaryemployee.FindAsync(id);
            if (Employee is null) return null; 

            _context.Temporaryemployee.Remove(Employee);
            await _context.SaveChangesAsync();

            return await _context.Temporaryemployee.ToListAsync();
        }

        async Task<TemporaryEmployee?> ITemporaryEmployeeService.GetATemporaryEmployee(int id)
        {
            var oneEmployee = await _context.Temporaryemployee.FindAsync(id);
            if (oneEmployee is null) { return null; }
            return oneEmployee;
        }

        async Task<List<TemporaryEmployee>> ITemporaryEmployeeService.GetTemporaryEmployees()
        {
            var T_E = await _context.Temporaryemployee.ToListAsync();
            return T_E;
        }

       async Task<List<TemporaryEmployee>?> ITemporaryEmployeeService.UpdateTemporaryEmployee(int id, TemporaryEmployee request)
        {
            var EmployeeUpdate = await _context.Temporaryemployee.FindAsync(id);
            if (EmployeeUpdate is null) { return null; }

            EmployeeUpdate.Name = request.Name;
            EmployeeUpdate.LastName = request.LastName;
            EmployeeUpdate.Cedula = request.Cedula;
            EmployeeUpdate.Department = request.Department;
            EmployeeUpdate.Position = request.Position;
            EmployeeUpdate.WorkedHours = request.WorkedHours;
            EmployeeUpdate.PricePerHour = request.PricePerHour;
            EmployeeUpdate.AccountNumber = request.AccountNumber;
            await _context.SaveChangesAsync();

            return await _context.Temporaryemployee.ToListAsync();
        }
    }
}
