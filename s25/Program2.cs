namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).Select(t=> t.Replace('.' , '/')).ToList();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[6]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        //Query 1
        Console.WriteLine("Query 1");
        var query1=File.ReadAllLines("c:/git/AP02032/s25/data.csv")
        .Skip(1).Select(t => Data.Parse(t)).ToList()
        /* ورش رو دو تا گذاشتم تا ول حجم زیاد داده هایی که ایران نیستن بره کنار بعد به کارمون بپدازیم .  */
        .Where(t => t.Country.ToLower().Contains("iran"))
        .Where(t=> t.LEType==LifeExpectancyType.AtBirth&&t.DataGender==DataGender.Both)
        .OrderBy(r=> r.Value)
        .ToList();
        query1.ForEach(t => System.Console.WriteLine(t.ToString()));
        

        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        var query2=query1.Select(t=>t.Value).ToList();
        System.Console.WriteLine($"{query2.OrderDescending().ToList()[0]-query2.Order().ToList()[0]}");
    


        Console.WriteLine();

        //Query 3
        Console.WriteLine("Query 3");
         File.ReadAllLines("c:/git/AP02032/s25/data.csv")
         .ToList().Skip(1).Select(t=> Data.Parse(t))
         .Where(t=> t.DataGender==DataGender.Both&&t.LEType==LifeExpectancyType.AtBirth)
         .GroupBy(t=> t.Country)
         .Select(t=> (max: t.MaxBy(k=>k.Value) , min: t.MinBy(k=> k.Value) ))
         .OrderByDescending(t=> t.max.Value-t.min.Value)
         .Select((t , i)=> (shomare:i+1 ,
          keshvar : t.min.Country ,
           sal_kamine: t.min.Year ,
            kamine: t.min.Value ,
             ekhtelaf_ba_bishine: t.max.Value-t.min.Value)).ToList().ForEach(t=> System.Console.WriteLine("shomare: "+t.shomare
             +",sale kamine: " + t.sal_kamine 
             +",kamine: " + t.kamine
             + ",roshd keshvar(ekhtelaf kamine va bishine): "
             +t.ekhtelaf_ba_bishine
             + ",keshvar: " + t.keshvar));
        

        //
        //
        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        //تاپل های خواسته شده . 
        var query4 = File.ReadAllLines("c:/git/AP02032/S25/data.csv").Skip(1).Select(t=> Data.Parse(t))
        .Where(t=> t.LEType==LifeExpectancyType.AtBirth)
        .GroupBy(t=> t.Country+"@!#"+t.Year.ToString())
        .Select(t=>{
            var kelid=t.Key.Split("@!#" , StringSplitOptions.RemoveEmptyEntries).ToList();
            var omidmardan = t.Where(k=> k.DataGender==DataGender.Male).ToList()[0].Value;
            var omidzanan = t.Where(k=> k.DataGender==DataGender.Female).ToList()[0].Value;
            return (keshvar:kelid[0] ,
             sal: int.Parse(kelid[1]) ,
              omidmardan: omidmardan ,
               omidzanan: omidzanan ,
                ekhtelaf_mardan_zanan: Math.Abs(omidmardan-omidzanan)) ;
                }).ToList();
        query4.GroupBy(t=> t.keshvar)
        .Select(t => t.MaxBy(k=> k.ekhtelaf_mardan_zanan))
        .OrderByDescending(t=>t.ekhtelaf_mardan_zanan)
        .Select((t,i)=> (dade: t , rotbe: i+1)).ToList()
        .ForEach(t=> System.Console.WriteLine("rotbe: "+t.rotbe
        +",keshvar: "+t.dade.keshvar
        +",sal: "+t.dade.sal
        +" ,omid_be_zendegi_mardan: "+t.dade.omidmardan
        +" ,omid_be_zendegi_zanan: "+t.dade.omidzanan
        +" , ekhtelaf_omid_mardan_va_zanan: "+t.dade.ekhtelaf_mardan_zanan));
        //
        //
        Console.WriteLine();

    }
}
