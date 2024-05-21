using System;

public static class ezafegar
{
    public static IEnumerable<T> addkon<T>(this IEnumerable<T> list, ds.tabemesal1 amalgar) 
    {
        List<T> lisarray = new List<T>();
        foreach (var item in list)
        {
            // lisarray.Add(amalgar(item));
        }
        return lisarray;
    }

    public static IEnumerable<T> mytake<T>(this IEnumerable<T> list,int tedad)
    {
        List<T> lisarray = new List<T>();
        foreach(var item in list)
        {
            if(lisarray.Count()<tedad)
            lisarray.Add(item);
            else
            break;
        }
    }

}