
namespace stu;
class student
{
    string studentId;
    string Name;
    int age;
    List<string> doroos = new List<string>;

    public student(int sen, string shomare , string nam)
    {
        age=sen;
        studentId=shomare;
        Name=nam;
    }


    static void savedaneshjoo(string filename)
    {
        using(StreamWriter nevis=new StreamWriter(filename));
        foreach(var student in doroos )
        {
            writer.nevis($"{student.studentId} , {student.age} , {student.Name}");
        }
    }

    
}