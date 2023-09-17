using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HumanResoursesApplication.Services;
using HumanResoursesApplication.Interfaces;

namespace HumanResoursesApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeFullTimeController : ControllerBase
    {
        private readonly IFullTimeEmployeeService fulltimeEmployee;
        public EmployeeFullTimeController(IFullTimeEmployeeService fulltimeemployee)
        {
                this.fulltimeEmployee = fulltimeemployee;
        }
        [HttpGet]
        public async Task<ActionResult<List<FullTimeEmployee>>> GetFullTimeEmployees()
        {
            return await fulltimeEmployee.GetFullTimeEmployees();

        }

        [HttpGet("id")]
        public async Task<ActionResult<FullTimeEmployee>>? GetAFullTimeEmployee(int id)
        {
            var oneEmployee = await fulltimeEmployee.GetAFullTimeEmployee(id);
            if (oneEmployee is null) return null; 
            return oneEmployee;
        }

        [HttpPost]
        public async Task<ActionResult<FullTimeEmployee>> AddFullTimeEmployee(FullTimeEmployee fte)
        {
            var result = await fulltimeEmployee.AddFullTimeEmployee(fte);
            if (result is null) { return NotFound("Information Not Found"); }
            return Ok(result);
        }

        [HttpPut("id")]
        public async Task<ActionResult<FullTimeEmployee>> UpdateFullTimeEmployee(int id, FullTimeEmployee request)
        {
            var EmployeeUpdate = await fulltimeEmployee.UpdateFullTimeEmployee(id, request);
            if (EmployeeUpdate is null) { return NotFound("Employee Not Found"); }

            return Ok(EmployeeUpdate);
        }
        [HttpDelete("id")]
        public async Task<ActionResult<FullTimeEmployee>> DeleteAFullTimeEmployee(int id)
        {
            var Employee = await fulltimeEmployee.DeleteAFullTimeEmployee(id);
            if (Employee is null) { return NotFound("Employee Not Found"); }

            return Ok(Employee);
        }
    }
}

