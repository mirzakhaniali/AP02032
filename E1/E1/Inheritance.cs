using System.Reflection.Metadata;

namespace E1;

public abstract class Person
{
    public abstract int LunchRate { get; }
    public string esm{ get; set; }
    public virtual string Name { get
    {
        string jens = "آقای " ;
        if(IsFemale)
            jens = "خانم " ;
        return jens+esm;
    } 
    set{
        this.esm = value;
    } }
    public bool IsFemale { get; set; }

    public Person(string esm , bool aya_khanom_ast )
    {
        this.Name = esm;
        this.IsFemale = aya_khanom_ast;
    }
    #region TODO
    #endregion
}

public class Student : Person
{
    #region TODO
    #endregion
    public Student(string esm , bool aya_khanom_ast) : base(esm,aya_khanom_ast)
    {}
    public override int LunchRate => 2000;
}

public class Employee : Person
{
    #region TODO
    #endregion
    protected int hoghoogh { get; set; }= 5000;
    public virtual int CalculateSalary(int saat) => saat*hoghoogh;
    
    public Employee(string esm , bool aya_khanom_ast) : base(esm,aya_khanom_ast)
    {}
    public override int LunchRate => 5000;
}

public class Teacher : Employee
{
    #region TODO
    #endregion
    public Teacher(string esm, bool aya_khanom_ast) : base(esm, aya_khanom_ast)
    {
        hoghoogh=20_000;
    }

    public override string Name { get => "استاد " + this.esm; set => base.esm = value; }

    public override int LunchRate => 10_000;
}