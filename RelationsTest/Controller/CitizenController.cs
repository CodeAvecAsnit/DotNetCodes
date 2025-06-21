using Microsoft.AspNetCore.Mvc;
using RelationsTest.Model;
using RelationsTest.Service;

namespace RelationsTest.Controller;

[ApiController]
[Route("api/citizen")]
public class CitizenController(CitizenService citizenServe) : ControllerBase
{
    [HttpGet("all")]
    public ActionResult<List<Citizen>> GetAll()
    {
        var result = citizenServe.GetAll();
        return Ok(result);
    }

    [HttpGet("test")]
    public string Test()
    {
        return "Test Success";
    }

    [HttpPost("post")]
    public IActionResult PostCitizen([FromBody] Citizen citizen)
    {
        return (citizenServe.Insert(citizen))?
            Ok("Success"):
            StatusCode(500, "Internal Server Error");
    }

    [HttpGet("find/{id:long}")]
    public ActionResult<Citizen> FindById(long id)
    {
        var citizen = citizenServe.GetById(id);
        return (citizen != null) ?
            Ok(citizen) : 
            StatusCode(404, "not found");
    }

    [HttpPut("update")]
    public IActionResult UpdateCitizen([FromBody] Citizen citizen)
    {
        return citizenServe.Update(citizen) ? 
            Ok("Successfully Updated") :
            StatusCode(404, "Citizen Not found");
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] long id)
    {
        return citizenServe.Delete(id) ? Ok("Successfully deleted") : StatusCode(404, "Not found");
    }

    [HttpGet("passport/{id:long}")]
    public ActionResult<Passport> GetCitizenPassportDetails(long id)
    {
        var passport = citizenServe.GetPassportForCitizen(id);
        if (passport != null)
        {
            passport.citizen = citizenServe.GetById(passport.citizenId);
            return Ok(passport);
        }else return 
            StatusCode(404,"Passport doesn't exist");
    }
}

