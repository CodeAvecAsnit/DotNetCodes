namespace WebApplication1;

public class SimpleInterest
{
    public float? _amount { get; set; }
    public int? _time { get; set; }
    public float? _rate { get; set; }

    public SimpleInterest(float amount, int time, float rate)
    {
        _amount = amount;
        _time = time;
        _rate = rate;
    }

    public SimpleInterest()
    {
    }

    public float calSimpleInterest()
    {
        return (float)(((_amount * _time) * _rate) / 100);
    }
}