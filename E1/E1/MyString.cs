namespace E1;

public class MyString
{
    #region TODO
    #endregion
    public string matn { get; set; }
    public static explicit operator MyString(string s) => new MyString(s);

    public static bool operator ==(MyString a, MyString b) => a.matn == b.matn;
   
    public static bool operator !=(MyString a,MyString b) => !(a == b);
   
    public static bool operator ==(MyString a, string b) => a.matn == b;
  
    public static bool operator !=(MyString a,string b) => !(a == b);
   
    public static explicit operator string(MyString a) => a.matn;
    public override bool Equals(object obj)
    {
        
        try
        {
            var te=obj as MyString;
            return te.matn == this.matn;
        }
        catch
        {
            try
            {
                var te = obj as string;
                return te == this.matn;
            }
            catch { return false; }
        }
    }
    public MyString(string s) => this.matn = s;

    public static MyString operator ++(MyString a) {
        a.matn=a.matn.ToUpper();
        return new MyString(a.matn);}
    public static MyString operator --(MyString a)
    {
        a.matn=a.matn.ToLower();
        return new MyString(a.matn);
    }
}

