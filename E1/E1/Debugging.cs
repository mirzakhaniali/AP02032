
namespace E1;

public class FullName
{
    public string FirstName;
    public string LastName;

    public FullName(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override bool Equals(object obj)
    {
        var digar = obj as FullName;
        if (digar != null)
            return (digar.FirstName.Equals(this.FirstName)&& digar.LastName.Equals(this.LastName));
        return false;
    }
    #region TODO
    #endregion
}

public static partial class Basics
{
    public static void RemoveDuplicates<T>(ref T[] list)
    {
        List<T> newList = new List<T>();
        foreach (var item in list)
        {
            if (!Contains(newList, item))
                newList.Add(item);
        }
        list = newList.ToArray();
    }

    private static bool Contains<T>(List<T> list, T lookup)
    {
        foreach (var item in list)
            if (item.Equals(lookup))
                return true;
        return false;
    }
}
