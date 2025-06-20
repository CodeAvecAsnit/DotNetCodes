using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DBTest.Models;

public class NewLetter
{
    [Key]
    public int newId { get; set; }
    public string date { get; set; }
    public string author { get; set; }
    public string headline { get; set; }
    public string body { get; set; }

}