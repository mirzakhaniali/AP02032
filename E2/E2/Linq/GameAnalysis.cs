namespace E2;
using System;

public class GameAnalysis
{
    public GameData[] GameDatas;
    public GameAnalysis(string path)
    {
        string[] lines = File.ReadAllLines(path);
        List<GameData> Games = new List<GameData>();
        for (int i = 1; i < lines.Length - 1; i++)
            try
            {
                var t = new GameData(lines[i].Replace(" ", "").Split(','));
                Games.Add(t);
            }
            catch
            {
            }
        GameDatas = Games.ToArray();
    }
    public long AllDataCount()
    {
        return GameDatas.Length.GetHashCode();
    }
    public (string,long)[] MostFrequent()
    {
       var k= GameDatas.GroupBy(x=> x.genre).ToList().OrderByDescending(t=>t.Count()).Take(5).Select(t=> (t.Key,(long)t.Count().GetHashCode())).ToArray();
        k.ToList().ForEach(t => System.Console.WriteLine(t.Key));
        return k;
    }
    public double[] BestPublisher()
    {
        var k = GameDatas.Where(x=> 2000<x.year&&x.year<2010).GroupBy(t=> t.publisher).Select(t=> (double)Math.Round(t.Select(k=>k.JP_sales+k.EU_sales+k.NA_sales+k.Other_sales).Sum(t=>t)/t.Count(),3)).OrderByDescending(t=>t).Take(5).ToArray();
        k.ToList().ForEach(t => System.Console.WriteLine(t));
        return k;
    }
    public string[] WestGamers(int limit1, int limit2)
    {
        var k = GameDatas.OrderByDescending(x=> (x.NA_sales+x.EU_sales)).Select(t=>t.name).ToArray();
        string[] r = new string[limit2-limit1+1];
        for(int i =limit1; i<=limit2;i++)
            r[i-limit1] = k[i];
        r.ToList().ForEach(t => System.Console.WriteLine(t));
        return r;
    }
    public string FaultyDatas()
    {
        string s = "";
        var k =GameDatas.Where(x=> x.Global_sales!=x.JP_sales+x.EU_sales+x.NA_sales+x.Other_sales).OrderByDescending(t=>t.year).Take(10).ToList();
        for(int i = 0;i<k.Count-1;i++)
            s += k[i].name+" ";
        s+=k[k.Count-1].name;
        return s;
    }
}
