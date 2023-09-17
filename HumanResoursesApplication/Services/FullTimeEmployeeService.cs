using HumanResoursesApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace HumanResoursesApplication.Services
{
    public class FullTimeEmployeeService : IFullTimeEmployeeService
    {
        private readonly DataContext _context;
        public FullTimeEmployeeService(DataContext context)
        {
                _context = context;
        }

        async Task<List<FullTimeEmployee>> IFullTimeEmployeeService.AddFullTimeEmployee(FullTimeEmployee fte)
        {
            _context.Fulltimeemployee.Add(fte);
            await _context.SaveChangesAsync();
            return await _context.Fulltimeemployee.ToListAsync();
        }

        async Task<List<FullTimeEmployee>?> IFullTimeEmployeeService.DeleteAFullTimeEmployee(int id)
        {
            var Employee = await _context.Fulltimeemployee.FindAsync(id);
            if (Employee is null) return null;

            _context.Fulltimeemployee.Remove(Employee);
            await _context.SaveChangesAsync();
            return await _context.Fulltimeemployee.ToListAsync();
        }

        async Task<FullTimeEmployee> IFullTimeEmployeeService.GetAFullTimeEmployee(int id)
        {
            var employee = await _context.Fulltimeemployee.FindAsync(id);
            if (employee is null) return null;

            return employee;
        }

        async Task<List<FullTimeEmployee>> IFullTimeEmployeeService.GetFullTimeEmployees()
        {
            var FT = await _context.Fulltimeemployee.ToListAsync();
            return FT;
        }

        async Task<List<FullTimeEmployee>?> IFullTimeEmployeeService.UpdateFullTimeEmployee(int id, FullTimeEmployee request)
        {

            var EmployeeUpdate = await _context.Fulltimeemployee.FindAsync(id);
            if (EmployeeUpdate is null) { return null; }

            EmployeeUpdate.Name = request.Name;
            EmployeeUpdate.LastName = request.LastName;
            EmployeeUpdate.Cedula = request.Cedula;
            EmployeeUpdate.Department = request.Department;
            EmployeeUpdate.Position = request.Position;
            EmployeeUpdate.Salary = request.Salary;
            EmployeeUpdate.PricePerHour = request.PricePerHour;
            EmployeeUpdate.DailyHours = request.DailyHours;
            EmployeeUpdate.AccountNumber = request.AccountNumber;
            await _context.SaveChangesAsync();

            return await _context.Fulltimeemployee.ToListAsync();
        }
    }
}
