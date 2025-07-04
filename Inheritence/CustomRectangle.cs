namespace Lab1.Files.Inheritence;

public interface ILength
{
    public void SetLength(float len);

}

public interface IBreadth
{
    public void SetBreadth(float breadth);
}

public class CustomRectangle : ILength , IBreadth
{
    private float _length;
    private float _breadth;

    public void SetLength(float len)
    {
        this._length = len;
    }

    public void SetBreadth(float breadth)
    {
        this._breadth = breadth;
    }

    public float GetArea()
    {
        return _length * _breadth;
    }
}