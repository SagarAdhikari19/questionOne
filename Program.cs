using System;
using System.Drawing;

//******************************************************************************
//basic example of interface 


/* public interface IDrawable{


    void draw ();
}
  
  public class Square :IDrawable{

    public void draw(){
        Console.WriteLine("this is square ");

    }
  }

    public class Rectangle : IDrawable{
        public void draw(){
            Console.WriteLine("this is rectangular");

        }
    }

    public class Triangle :IDrawable{
        public void draw(){
Console.WriteLine("this is triangle");
        }
    }
  

public class ProgramInterface{
    public static void Main(string[] args){
        IDrawable ShapeOne= new Square();
        ShapeOne.draw();
        IDrawable shapeTwo= new Rectangle();
        shapeTwo.draw();
        IDrawable ShapeThree= new Triangle();


ShapeThree.draw();

    }
}

*/

//******************************************************************************
//Shape Area Calculator:
/*Define an interface IShape with a method CalculateArea() that returns a double.
Implement the interface in classes for different shapes such as Circle, Square, and Triangle.
Create an array of IShape objects and calculate the area for each shape.
solve these*/
/*
public interface IShape
{
    public double CalculateArea();// method to calculate area 

}

public class Circle : IShape
{

    public double radius { get; set; }
    public Circle(double rad)
    {
        this.radius = rad;

    }
    public double CalculateArea()
    {
        return (3.13 * radius * radius);

    }
}


public class Square : IShape
{
    public double length
    {
        get;
        set;
    }
    public Square(double len)
    {
        this.length = len;

    }
    public double CalculateArea()
    {
        return (length * length);
    }

}

public class Triangle : IShape
{

    public double Base
    {
        get;
        set;
    }
    public double Height
    {
        get;
        set;
    }

    public Triangle(double baase, double height)
    {
        this.Base = baase;
        this.Height = height;

    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }


}


public class program
{
    public static void Main()
    {

        //creating instance of each shape
        Circle cir = new Circle(5);
        Square sq = new Square(4);
        Triangle tri = new Triangle(3, 6);

        //calcalculate 
        double CircleArea = cir.CalculateArea();
        double SquareArea = sq.CalculateArea();
        double TriangleArea = tri.CalculateArea();


        Console.WriteLine(CircleArea);
        Console.WriteLine(SquareArea);
        Console.WriteLine(TriangleArea);

    }


}
*/







