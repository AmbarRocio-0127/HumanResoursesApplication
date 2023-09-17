using HumanResoursesApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResoursesApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePartTimeController : ControllerBase
    {
        private readonly IPartTimeEmployeeService _parttimeEmployee;

        public EmployeePartTimeController(IPartTimeEmployeeService parttimeEmployee)
        {
                this._parttimeEmployee = parttimeEmployee;
        }

        [HttpGet]
        public async Task<ActionResult<List<PartTimeEmployee>>> GetPartTimeEmployees()
        {
            return await _parttimeEmployee.GetPartTimeEmployees();
        }

        [HttpGet("id")]
        public async Task<ActionResult<PartTimeEmployee>> GetAPartTimeEmployee(int id)
        {
            return await _parttimeEmployee.GetAPartTimeEmployee(id);
        }

        [HttpPost]
        public async Task<ActionResult<List<PartTimeEmployee>>> AddPartTimeEmployee(PartTimeEmployee pte)
        {
            var result = await _parttimeEmployee.AddPartTimeEmployee(pte);
            if (result is null) { return NotFound("Information Not Found."); }
            return result;
        }

        [HttpPut("id")]
        public async Task<ActionResult<PartTimeEmployee>> UpdatePartTimeEmployee(int id, PartTimeEmployee request)
        {
            var EmployeeUpdate = await _parttimeEmployee.UpdatePartTimeEmployee(id, request);
            if (EmployeeUpdate is null) { return NotFound("Employee Not Found"); }

            return Ok(EmployeeUpdate);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<PartTimeEmployee>> DeleteAPartTimeEmployee(int id)
        {
            var Employee = await _parttimeEmployee.DeleteAPartTimeEmployee(id);
            if (Employee is null) { return NotFound("Employee Not Found"); }

            return Ok(Employee);
        }
    }
}
