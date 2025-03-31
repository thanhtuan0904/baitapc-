using System;
public class Fan {
    public const int Slow = 1;
    public const int Medium = 2;
    public const int Fast = 3;
    private int speed = Slow;
    private bool on = false;
    private double radius = 5;
    private string color = "blue";

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool On { get { return on; } set { on = value; } }
    public double Radius { get { return radius; } set { radius = value; } }
    public string Color { get { return color; } set { color = value; } }

    public Fan()
    {
        speed = Slow;
        on = true;
        radius = 5;
        color = "blue";
    }
    public Fan(int speed, bool on, double radius, string color)
    {
        Speed = speed;
        On = on;
        Radius = radius;
        Color = color;
   
       
    }

    public override string ToString()
    {
        if (on)
        {
            Console.WriteLine("quat dang bat :");
            return $"Speed: {speed} , On: {on} , Radius: {radius} , Color: {color} ";
        }
        else
        {
            Console.WriteLine(" quat dang tat :");
            return $"On:{on},Radius: {radius} , Color: {color} ";
        }
    }
    public static void Main(string[] args)
    {
        Fan f1 = new Fan(3,true,10,"yellow");
        Console.WriteLine(f1.ToString());
        Fan f2 = new Fan(2,false, 6, "red");
        Console.WriteLine(f2.ToString());

    }
}
