using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationsTest.Model;

public class Passport
{
    [Key] public long pId { get; init; }
    public string IssueDate{ get; set; }
    public string ExpiryDate{ get; set; }
    [Required]
    [ForeignKey(nameof(Citizen))]
    public long citizenId{ get; set; }
    public Citizen? citizen{ get; set; }
}