
using namespace stu

class programm
{
    static List<student> students=new List<student>;
    static void add_student()
    {
        student a;
        string stdid=Console.ReadLine();
        string stdnam=Console.ReadLine();
        string stdsen=Console.ReadLine();
        students.add(new student(stdid , int.Parse(stdsen) , stdnam ));
    }

    static void loadfile(string filename)
    {
        if(File.exist(filename))
        {
            string[] s=File.ReadAllLines(filename);
            foreach(var d in s)
            {
                string[] ds= d.split(',');
                students.add(new student(ds[0] ,ds[1],int.parse(ds[2])));
            }
        }
    }
    
    public  void Enroll(string name_dars)
    {
        doroos.pushback(name_dars);
    }
    
    static void EnrollStudentCourse(string shomare_daneshjoi)
    {
        var a= students.FirstOrDefault(doroos => doroos.studentId==shomare_daneshjoi);
        if(a==null)
        {
            Consle.Writeline("nist");
            return ;
        }
        string name_dars = Console.ReadLine();
        doroos.pushback(name_dars);
    }

    static void DisplayStudentDetai()
    {
        
        var a= students.FirstOrDefault(doroos => doroos.studentId==shomare_daneshjoi);
        if(a==null)
        {
            Console.Writeline("nist");
            return ;
        }

    }

    static void Main(
        {
            loadfile(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("Student Management System\n1. Add Student\n2. Enroll Student in Course\n 3. Display Student Details\n4. Save Students to File\n5. Exit\nEnter your choice: ")
                string dastoor=Console.ReadLine();
                // if(int.parse(dastoor)==1)
                // میشه جای ایف و الس از سوییچ استفاده کرد . 
                switch (dastoor)
                {
                    case "1":
                        add_student();
                        break;
                    case "2":
                        Enroll();
                        break;
                }
            }
        }
    )
}