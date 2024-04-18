using System.Collections;
using System.Data.Common;


public class ShapeClass:shapeinterface
{
    public string name{ get; set; }
    public string color{ get; set; }
    public double X{get; set; }
    public double Y{get; set; }

    public void printfeauters()
    {
        System.Console.WriteLine($"{name},{color},{X},{Y}");
    }
    public void moveto(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public virtual double area()
    {
        return 0.00;
    }

    public virtual double perimeter()
    {
        return 0.00;
    }

    public virtual bool ispointinside(double x, double y)
    {
        return false;
    }

    public ShapeClass(string name, string color, double x, double y)
    {
        this.name = name;
        this.color = color;
        this.X = x;
        Y = y;
    }

}

interface shapeinterface
{
    double area();
    double perimeter();
    bool ispointinside(double x, double y);
}


public class circle: ShapeClass 
{
    double radius{get; set; }
    public void radius_scale(double cheghad)
    {
        X=X*cheghad;
        Y=Y*cheghad;
    }

    public override double area()
    {
        return radius*radius*(3.14);
    }

    public override double perimeter()
    {
        return radius*2*(3.14);
    }

    public override bool ispointinside(double x, double y)
    {
        return (radius*radius>X*X+Y*Y);
    }

    public circle(double radius,string name,string color, double x, double y):
        base(name,color,x,y)
    {
        this.radius = radius;
    }
}

public class rectangle:ShapeClass  
{
    double width{get; set; }
    double height{get; set;}
    public void scalewidth(double cheghad)
    {
        width*=cheghad;
    }

    public void scaleheight(double height)
    {
        height*=height;
    }

    public override double area()
    {
        return width*height;
    }

    public override double perimeter()
    {
        return 2*(width+height);
    }

    public override bool ispointinside(double x, double y)
    {
        return ((X<this.X+width/2&&X>this.X-width/2)&&(y<this.Y+height/2&&Y>this.Y-height/2));
    }

    public rectangle(double width,double height, string name,string color,double x,double y)
    :base(name,color,x,y)
    {
        this.width=width;
        this.height=height;
    }
}

class square:ShapeClass
{
    public double side{get; set; }
    public void side_scale(double cheghad)
    {
        this.side*=cheghad;
    }

    public override double area()
    {
        return side*side;
    }

    public override double perimeter()
    {
        return 4*side;
    }

    public override bool ispointinside(double x, double y)
    {
        return (X<this.X+side/2&&X>this.X-side/2)&&(y<this.Y+side/2&&Y>this.Y-side/2);
    }

    public square(double side,string name,string color , double x,double y)
    :base(name,color,x,y)
    {
        this.side=side;
    }
}

