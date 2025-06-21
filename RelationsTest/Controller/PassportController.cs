using Microsoft.AspNetCore.Mvc;
using RelationsTest.Model;
using RelationsTest.Service;

namespace RelationsTest.Controller;
[ApiController]
[Route("api/passport")]
public class PassportController(PassportService pass): ControllerBase
{
    [HttpGet("test")]
    public string Test()
    {
        return "Passport Api is running successfully";
    }

    [HttpGet("all")]
    public ActionResult<List<Passport>> GetAll()
    {
        return Ok(pass.GetAll());
    }

    [HttpDelete("delete")]
    public IActionResult DeleteById([FromQuery] long id)
    {
        return pass.Delete(id) ?
            Ok("Successfully Deleted") : 
            StatusCode(404, "Not Found");
    }

    [HttpPut("update")]
    public IActionResult UpdatePassport([FromBody] Passport passport)
    {
        return pass.Update(passport) ?
            Ok("Successfully updated") :
            StatusCode(404, "Not found");
    }

    [HttpGet("citizen/{id:long}")]
    public ActionResult<Citizen> GetCitizenByPassportId(long id)
    {
        var citizen = pass.GetCitizenInfo(id);
        return Ok(citizen);
    }
    
    [HttpGet("citizen")]
    public ActionResult<Citizen> GetCitizenByPasspor([FromBody] Passport passport)
    {
        var citizen = pass.GetCitizenInfo(passport);
        return Ok(citizen);
    }

    [HttpPost("post")]
    public IActionResult InsertCitizen([FromBody] Passport passport)
    {
        try
        {
            pass.InsertPassport(passport);
            return Ok("Successfully Inserted");
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
        
}