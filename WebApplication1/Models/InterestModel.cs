namespace WebApplication1.Models;

public class InterestModel
{
    public decimal Principal { get; set; }
    public decimal Rate { get; set; }
    public int Time { get; set; }
    public decimal Interest => (Principal * Rate * Time) / 100;
}