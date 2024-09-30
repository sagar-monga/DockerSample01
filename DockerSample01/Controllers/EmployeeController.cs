using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using DockerSample01.Models;
using DockerSample01.Models.RequestModels;

namespace DockerSample01.Controllers
{

    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new JsonResult(EmployeeDataStore.Current.Employees);
        }

        [HttpGet("{id:int}", Name = "GetEmployee")]
        public ActionResult<EmployeeDto> Get(int id)
        {
            var employee = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public ActionResult Add(EmployeeRequestModelDto employeeRequestModel)
        {
            var count = EmployeeDataStore.Current.Employees.Count();

            EmployeeDto newEmployee = new EmployeeDto()
            {
                Id = count + 1,
                FirstName = employeeRequestModel.FirstName,
                LastName = employeeRequestModel.LastName,
                Salary = employeeRequestModel.Salary,
                Department = employeeRequestModel.Department,
                Position = employeeRequestModel.Position,
                HireDate = employeeRequestModel.HireDate,
                DateOfBirth = employeeRequestModel.DateOfBirth,
            };

            try
            {
                if (count == 210)
                {
                    throw new Exception("Max Count reached");
                }
                EmployeeDataStore.Current.Employees.Add(newEmployee);
                return CreatedAtRoute("GetEmployee",
                new
                {
                    id = newEmployee.Id,
                }, newEmployee);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception {0} occurred", ex);
                return Ok(false);
            }
        }

        [HttpPut("{id}")]
        public ActionResult FullUpdate(int id, EmployeeDtoForUpdate newEmployeeDetails)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound("Employee not found");
            }

            employeeFromStore.FirstName = newEmployeeDetails.FirstName;
            employeeFromStore.LastName = newEmployeeDetails.LastName;
            employeeFromStore.Salary = newEmployeeDetails.Salary;
            employeeFromStore.Department = newEmployeeDetails.Department;
            employeeFromStore.Position = newEmployeeDetails.Position;
            employeeFromStore.LastWorkingDate = newEmployeeDetails.LastWorkingDate;
            employeeFromStore.HireDate = newEmployeeDetails.HireDate;
            employeeFromStore.DateOfBirth = newEmployeeDetails.DateOfBirth;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdate(int id, JsonPatchDocument<EmployeeDtoForUpdate> patchDocument)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound();
            }

            var employeeToPatch = new EmployeeDtoForUpdate()
            {
                FirstName = employeeFromStore.FirstName,
                LastName = employeeFromStore.LastName,
                Salary = employeeFromStore.Salary,
                Department = employeeFromStore.Department,
                Position = employeeFromStore.Position,
                LastWorkingDate = employeeFromStore.LastWorkingDate,
                HireDate = employeeFromStore.HireDate,
                DateOfBirth = employeeFromStore.DateOfBirth,
            };



            patchDocument.ApplyTo(employeeToPatch, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(employeeToPatch);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employeeFromStore = EmployeeDataStore.Current.Employees.FirstOrDefault(e => e.Id == id);

            if (employeeFromStore == null)
            {
                return NotFound();
            }

            EmployeeDataStore.Current.Employees.Remove(employeeFromStore);

            return NoContent();
        }
    }
}
