using HumanResoursesApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace HumanResoursesApplication.Services
{
    public class PartTimeEmployeeService : IPartTimeEmployeeService
    {
        private readonly DataContext _context;
        public PartTimeEmployeeService(DataContext context)
        {
            _context = context;
        }
        async Task<List<PartTimeEmployee>> IPartTimeEmployeeService.AddPartTimeEmployee(PartTimeEmployee pte)
        {
           _context.Parttimeemployee.Add(pte);
            await _context.SaveChangesAsync();
            return await _context.Parttimeemployee.ToListAsync();
        }

       async Task<List<PartTimeEmployee>?> IPartTimeEmployeeService.DeleteAPartTimeEmployee(int id)
        {
            var Employee = await _context.Parttimeemployee.FindAsync(id);
            if (Employee is null) return null;

            _context.Parttimeemployee.Remove(Employee);
            await _context.SaveChangesAsync();

            return await _context.Parttimeemployee.ToListAsync();
        }

       async Task<PartTimeEmployee?> IPartTimeEmployeeService.GetAPartTimeEmployee(int id)
        {
            var oneEmployee = await _context.Parttimeemployee.FindAsync(id);
            if (oneEmployee is null) { return null; }
            return oneEmployee;
        }
        async Task<List<PartTimeEmployee>> IPartTimeEmployeeService.GetPartTimeEmployees()
        {
            var PT = await _context.Parttimeemployee.ToListAsync();
            return PT;
        }

        async Task<List<PartTimeEmployee>?> IPartTimeEmployeeService.UpdatePartTimeEmployee(int id, PartTimeEmployee request)
        {
            var EmployeeUpdate = await _context.Parttimeemployee.FindAsync(id);
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

            return await _context.Parttimeemployee.ToListAsync();
        }
    }
}
