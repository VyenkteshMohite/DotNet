namespace maths;
public class complex
{
    private int real;
    private int img;
    public complex()
    {
        this.real = 0;
        this.img = 0;

    }
    public complex(int r, int i)
    {
        this.real = r;
        this.img = i;
    }
    public int real
    {
        get { return this.real; }
        set { this.real = value; }

    }
    public int img
    {
        get { return this.img; }
        set { this.img = value; }
    }
    public static complex operator +(complex c1, complex c2
    )
}