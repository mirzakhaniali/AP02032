using s27;

class program
{
    public static void Main(String[] args)
    {
        System.Console.WriteLine("name?");
        var name = Console.ReadLine();
        hesab karbar = new hesab(name , 0);
        karbar._karbanki = matn => 
        {
            using var v = new rangavazkon(ConsoleColor.Blue);
            System.Console.WriteLine(matn);
        };
        while (true)
        {
            var cmd = Console.ReadLine();
            string[] ghetee = cmd.Split();
            double meghdar = double.Parse(ghetee[1]);
            if(ghetee[0]=="+")
                karbar.deposit(meghdar);
            else if (ghetee[0]=="-")
                karbar.withdraw(meghdar);
            else 
                System.Console.WriteLine("meghdar namoshakhas");
        }
    }
}