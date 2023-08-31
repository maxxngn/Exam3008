using Exam3008;

public class Program
{
    public static void Main(string[] args)
    {
        Lion lion = new Lion(200, "lion");
        Tiger tiger = new Tiger(100, "tiger");

        lion.Show();
        tiger.Show();
    }
    public static void Main1(string[] args)
    {
        Cylinder cylinder = new Cylinder();
        cylinder.Process();
        cylinder.Result();

    }
}
