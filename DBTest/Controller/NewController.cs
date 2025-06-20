using DBTest.Models;
using DBTest.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DBTest.Controller;

[ApiController]
[Route("api")]
public class NewController(NewLetterService newLetterService) : ControllerBase
{
    [HttpGet("all")]
    public ActionResult<List<NewLetter>> GetAll()
    {
            var result = newLetterService.GetAll();
            return Ok(result);
    }

    [HttpPost("post")]
    public IActionResult PostNews([FromBody] NewLetter newLetter)
    {
            return newLetterService.Insert(newLetter)? 
                Ok("Success"):
                StatusCode(500, "Server Error");
    }

    [HttpGet("test")]
    public IActionResult Hello()
    {
        return Ok("The server is running");
    }

    [HttpPut("update")]
    public IActionResult UpdateNewsLetter([FromBody] NewLetter newLetter)
    {
        return newLetterService.Update(newLetter) ? 
            Ok("Successfully Updated") :
            StatusCode(404, "Newsletter Not Found");
    }

    [HttpGet("search/{id:int}")]
    public ActionResult<NewLetter> SearchById(int id)
    {
        try
        {
            var obj = newLetterService.Search(id);
            return Ok(obj);
        }
        catch (Exception ex)
        {
            return StatusCode(404, ex.Message);
        }
    }

    [HttpDelete("delete/{id:int}")]
    public IActionResult DeleteNews(int id)
    {
        return newLetterService.Delete(id) ?
            Ok("Successfully deleted") : 
            StatusCode(404, "Not Found");
    }
    
}