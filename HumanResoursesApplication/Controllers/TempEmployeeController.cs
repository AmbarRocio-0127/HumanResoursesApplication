
using HumanResoursesApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HumanResoursesApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempEmployeeController : ControllerBase
    {
        private readonly ITemporaryEmployeeService _temptimeEmployee;
        public TempEmployeeController(ITemporaryEmployeeService temptimeEmployee)
        {
                this._temptimeEmployee = temptimeEmployee;
        }

        [HttpGet]
        public async Task<ActionResult<List<TemporaryEmployee>>> GetTemporaryEmployees()
        {
            return await _temptimeEmployee.GetTemporaryEmployees();
        }

        [HttpGet("id")]
        public async Task<ActionResult<TemporaryEmployee>> GetATemporaryEmployee(int id)
        {
            var oneEmployee = await _temptimeEmployee.GetATemporaryEmployee(id);
            if (oneEmployee is null) { return NotFound("Employee Not Found"); }
            return Ok(oneEmployee);
        }

        [HttpPost]
        public async Task<ActionResult<TemporaryEmployee>> AddTemporaryEmployee(TemporaryEmployee Temp)
        {
            var result = await _temptimeEmployee.AddTemporaryEmployee(Temp);
            if (result is null) { return NotFound("Infomation Not Found"); }
            return Ok(result);
        }

        [HttpPut("id")]
        public async Task<ActionResult<TemporaryEmployee>> UpdateTemporaryEmployee(int id, TemporaryEmployee request)
        {
            var EmployeeUpdate = await _temptimeEmployee.UpdateTemporaryEmployee(id, request);
            return Ok(EmployeeUpdate);
        }

        [HttpDelete("id")]
        public async Task<ActionResult<PartTimeEmployee>> DeleteAPartTimeEmployee(int id)
        {
            var Employee = await _temptimeEmployee.DeleteATempTimeEmployee(id);
            if (Employee is null) { return NotFound("Employee Not Found"); }

            return Ok(Employee);
        }
    }
    }
