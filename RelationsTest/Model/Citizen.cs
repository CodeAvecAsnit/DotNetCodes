using System.ComponentModel.DataAnnotations;

namespace RelationsTest.Model;

public class Citizen
{
    [Key] public long citizenId{ get; set; }
    public string citzenName{ get; set; }
}