
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization;

public class Maini
{
    public static string namad;
    public static string namad_khorooj="khorooj";
    public static string khataye_matni="matn dade shode sahih nemibasahd . ";
    public static int tedad_karmandan=10;
    public static int tedad_asatid=5;
    public bool not_null;
    public static void Main(String[] args)
    {
        ostad rayis_daneshgah=new ostad("doktor", "anbiya", 1342 , 30_000_000 , new List<string> {"shimi"});
        ostad riasat_daneshkade=new ostad("naser" , "mozayyeni" , 1347,30_000_000,new List<string> {"hooshe masnooyi"});
        ostad soltan=new ostad("doktor seyyed saleh" , "eetemadi", 1358 , 30_000_000 , new List<string> {"بردازش داده ","بردازش زبان های ماشینی","شبکه های کامبیوتری","امنیت سیستم های عامل","شبکه های اجتماعی و ماشینی","",});
        daneshjoo soltan_shoobe_2 = new daneshjoo("ali", "mirzakhani",1383);
        daneshjoo jaaabaaar = new daneshjoo( "ali" , "jabbari poor" , 1384);
        daneshjoo asgari = new daneshjoo("ali","askari" , 1320);
        List<daneshjoo> salatin_bela_monazee=new List<daneshjoo>{soltan_shoobe_2 , jaaabaaar , asgari};
        List<ostad> asatid_campiuter = new List<ostad>{riasat_daneshkade , soltan};
        karmand karmand_shoobe_2 = rayis_daneshgah;
        List<karmand> karmands = new List<karmand>{karmand_shoobe_2}; 
        setad ejrayi_farman_emam=new setad("setade ejrayi farman emam",rayis_daneshgah,karmands);
        List<setad> setads=new List<setad>{ejrayi_farman_emam};
        tashakkol farhangi = new tashakkol("anjoman farhangi"  , asgari , salatin_bela_monazee );
        List<tashakkol> tashakkols= new List<tashakkol>{farhangi};
        daneshkade kampiuter = new daneshkade("campiuter" , riasat_daneshkade , asatid_campiuter, salatin_bela_monazee ,karmands,tashakkols);
        List<daneshkade> daneshkades= new List<daneshkade>{kampiuter};
        daneshgah ElmoSanaat = new daneshgah("Elm o Sanaat" , rayis_daneshgah , "Iran" , daneshkades , setads);
        bool che_khabar=true;

        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        string baraye_while;
        while(che_khabar)
        {
            System.Console.WriteLine("darkhast shoma chist ?");
            baraye_while=Console.ReadLine();
            switch(baraye_while)
            {
                case "":
                    baraye_while="";
                    break;
                case "chap daneshgah":
                    ElmoSanaat.chap();
                    break;
                case "chap campiuter":
                    kampiuter.chap();
                    break;
                case "chap ostad":
                    soltan.chap();
                    break;
                case "chap setad":
                    ejrayi_farman_emam.chap();
                    break ;
                case "chap tashakkol":
                    farhangi.chap();
                    break;
                case "add daneshjoo":
                    try
                    {                    
                        System.Console.WriteLine($"ba namad {Maini.namad} joda konid");
                        System.Console.WriteLine("fname , lname , sal tavallod");
                        string s = System.Console.ReadLine();
                        string[] sss=s.Split(Maini.namad);
                        daneshjoo rr = new daneshjoo(sss[0] , sss[1] , int.Parse(sss[2]));
                        salatin_bela_monazee.Add(rr);
                    }
                    catch (FormatException ex)
                    {
                        System.Console.WriteLine("lotfan be format dorost vared konid");
                    }
                    break;
                case "kj":
                    che_khabar=false;
                    break;
            }
        }
    }

    // public List<karmand> list_karmand_gir()
    // {
    //     string baraye_while;
    //     string[] porkon=new string[5];
    //     int i=0;
    //     List<karmand> list = new List<karmand>();
    //     System.Console.WriteLine($"agar mayel be tark barname hastid kelid ({namad_khorooj}) ra feshar dahid");
    //     while (true)
    //     {
    //         System.Console.WriteLine("name karmand ra vared namaiid .");
    //         baraye_while=System.Console.ReadLine();
    //         /* این اگر خواست بره بیرون /  */
    //         if(baraye_while==Maini.namad_khorooj)
    //         {
    //             if(i>=Maini.tedad_karmandan)
    //                 break;
    //             System.Console.WriteLine("hanooz be tedad kafi karmand nadarim");
    //         }
    //         /* این اگر هیچی وارد نکرده بود . چون ارور نمیده اما کار رو خراب میکنه . */
    //         if(baraye_while==string.Empty&&this.not_null)
    //         {
    //             System.Console.WriteLine(Maini.khataye_matni);
    //             porkon=new string[5];
    //             continue;
    //         }
    //         porkon.SetValue(baraye_while,i);
    //         i++;
    //         if(i==5)
    //         {
    //             karmand r=new daneshgah(porkon[0],new person ( person.idp++ , porkon[1] , porkon[2] , int.Parse(porkon[3]) ) , porkon[4]);
    //             return r;
    //         }
    //     }
    //     return null;
    // }

    // public daneshgah daneshgah_porkon()
    // {
    //     string baraye_while;
    //     string[] porkon=new string[5];
    //     int i=0;
    //     System.Console.WriteLine($"agar mayel be tark barname hastid kelid ({namad_khorooj}) ra feshar dahid");
    //     while (true)
    //     {
    //         System.Console.WriteLine("name daneshgah ra vared namaiid .");
    //         baraye_while=System.Console.ReadLine();
    //         /* این اگر خواست بره بیرون /  */
    //         if(baraye_while==Maini.namad_khorooj)
    //         {
    //             break;
    //         }
    //         /* این اگر هیچی وارد نکرده بود . چون ارور نمیده اما کار رو خراب میکنه . */
    //         if(baraye_while==string.Empty&&this.not_null)
    //         {
    //             System.Console.WriteLine(Maini.khataye_matni);
    //             continue;
    //         }
    //         porkon.SetValue(baraye_while,i);
    //         i++;
    //         if(i==5)
    //         {
    //             daneshgah r=new daneshgah(porkon[0],new person ( person.idp++ , porkon[1] , porkon[2] , int.Parse(porkon[3]) ) , porkon[4]);
    //             return r;
    //         }
    //     }
    //     return null;
    // }
}