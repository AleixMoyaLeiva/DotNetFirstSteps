using Microsoft.AspNetCore.Mvc;
namespace backend.EmployeeApi.Data;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Employee>>  GetEmployees()
    {
        return Ok(EmployeeMockData.Employees);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateEmployee(int id, Employee updatedEmployee)
    {
        var employee = EmployeeMockData.Employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }

        employee.Nombre = updatedEmployee.Nombre;
        employee.ProyectoActual = updatedEmployee.ProyectoActual;
        employee.ProyectosAnteriores = updatedEmployee.ProyectosAnteriores;
        employee.TiempoEnLaEmpresa = updatedEmployee.TiempoEnLaEmpresa;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteEmployee(int id)
    {
        var employee = EmployeeMockData.Employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }

        EmployeeMockData.Employees.Remove(employee);
        return NoContent();
    }
}