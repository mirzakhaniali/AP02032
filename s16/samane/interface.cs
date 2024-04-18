using System.Dynamic;

public interface daneshgahi
{
    public void ezafe(daneshkade a);
    public void kam(daneshkade a);
    public void ezafe(setad a);
    public void kam(setad a);
}

public interface chapgar
{
    public void chap();
}

public interface tashakkoli : daneshjoodar , chapgar
{
    public string name { get; set; }
    public daneshjoo dabir {get; set;}
}

public interface daneshkadei : daneshjoodar , edari , setaddar , ostaddar , chapgar{}

public interface ostaddar 
{
    public List<ostad> asatid { get; set;}
    public void chapostad();
}

public interface darshandle
{
    public List<string> doroos{ get; set; }
    public void Adddars(string dars);
    public void kamdars(string dars);
    public void chapdoroos();
}

public interface nomrehandle : darshandle
{
    public List<int> nomarat{ get; set; }
    public void Addnomre(int nomre);
    public void kamnomre(int nomre);
    public void chapnomarat();
    public double Average();
}

public interface setadi : edari , chapgar{}

public interface ostadi : darshandle , chapgar{}

public interface edari
{
    public string name{ get; set; }
    public person riasat{ get; set; }
    public List<karmand> karkonan{ get; set; }
    public void chapkarkonan();
}

public interface daneshjoi : chapgar , nomrehandle{}

public interface daneshjoodar
{
    List<daneshjoo> daneshjoos{ get; set; }
    public void chapdaneshjoo();
}

public interface setaddar
{
    public List<setad> gorooh{ get; set; }
    public void chapgorooh();
    
}