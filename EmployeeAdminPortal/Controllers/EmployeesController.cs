using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;//THIS WAS CREATED BY USING BELOW PROCESS

        //PROCESS IS   select dbContext below and press ctrl + . and then click create and assign  field    
        //it will give you the line privvate readonly   
        //this is a field that will be used to connect to the database


        //write ctor below will be created and write manually ApplicationDbContext dbContext
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);

        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee
            {
                Id = Guid.NewGuid(), // Generate a new unique identifier
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                salary = addEmployeeDto.salary
            };
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges(); // Save changes to the database
            return Ok(employeeEntity); // Return the created employee entity
        }

        [HttpGet]
        //this method needs to know abt the id it wants to search in the database
        //as a route parameter  we will accept an identifier id and type is guid
        [Route("{id:guid}")]
       //id  write the same in paramter then only it works
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee is null)
            {
                return NotFound();
            }
            return Ok(employee);

        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee is null)
            {
                return NotFound();
            }
            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.salary = updateEmployeeDto.salary;

            dbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if(employee is null)
            {
                return NotFound("No employees with that id");
            }
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok("Deleted");
        }
    }
}
