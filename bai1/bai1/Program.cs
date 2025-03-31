using System;

public class Student
{
    private int rollno;
    private string name;
    private static string college = "Ptit";

    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
    // phuong thuc change de thay doi gia tri tinh cua bien
    public static void Change()
    {
        college = "Dai Hoc Kien Truc";
    }
    public void Display()
    {
        Console.WriteLine(rollno+" "+name+" "+college);
    }
    public static void Main(string[] args)
    {
        Student s1 = new Student(1,"tuan") ;
        
        s1.Display();
        Student s2 = new Student(2, "thanh");
        s2.Display();
    }
  }