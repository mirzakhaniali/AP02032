using System.Collections;
public class StringEnumerator : IEnumerator<string> , IEnumerable<string>
{
    private string voroodi{get;set;}
    private static int meghdar_khaste=3;
    public string Current { get
    {
        return voroodi.Substring(jaygah,StringEnumerator.meghdar_khaste);
    } }

    int jaygah=- StringEnumerator.meghdar_khaste;

    public StringEnumerator(string voroodi)
    {
        this.voroodi=voroodi;

    }

    object IEnumerator.Current {get{ return Current; }}

    public void Dispose()
    {
        System.Console.WriteLine("alhamdolllah");
    }

    public bool MoveNext()
    {
        // اول اینجا باید بعلاوه شه بعد ریترن شه برای همین عدد اولیه اون رو 
        //منفی سه گذاشتیم . 
        jaygah+=StringEnumerator.meghdar_khaste;
        return jaygah<voroodi.Length;
    }

    public void Reset()
    {
        this.jaygah=StringEnumerator.meghdar_khaste;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new StringEnumerator(this.voroodi);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StringEnumerator(this.voroodi);
    }
}
