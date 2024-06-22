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
        // TODO1
        throw new NotImplementedException();
    }
    public (string,long)[] MostFrequent()
    {
        // TODO2
        throw new NotImplementedException();
    }
    public double[] BestPublisher()
    {
        // TODO3
        throw new NotImplementedException();
    }
    public string[] WestGamers(int limit1, int limit2)
    {
        //TODO4
        throw new NotImplementedException();
    }
    public string FaultyDatas()
    {
        //TODO5
        throw new NotImplementedException();
    }
}
