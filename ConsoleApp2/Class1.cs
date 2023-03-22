namespace ConsoleApp2;

public delegate double Clac(double a,double b);

public class Class1
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Sun(double a, double b)
    {
        return a - b;
    }
    
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    
    public double Except(double a, double b)
    {
        return a / b;
    }
}