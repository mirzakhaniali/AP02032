public static class Sezar
{
    public static string sezar(this string matn , int key)
    {
        int j=0;
        string javab=new string("");
        char c = default(char);
        for (int i = 0;i<matn.Length;i++)
        {
            c = matn[i];
            javab+=harf_moayyankon(c , key);
        }
        return javab;
    }

    static public int adadin(char c , string meyar)
    {
        for(int i = 0;i<meyar.Length;i++)
        {
            if(meyar[i] == c)
                return i;
        }
        return -1;
    }

    public static char harf_moayyankon(char c , int key)
    {
        string meyarbozorg="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string meyarkoochak="abcdefghijklmnopqrstuvwxyz";
        string adad="0123456789";
        int a=adadin(c,meyarbozorg);
        int j=0;
        if(a==-1)
        {
            a=adadin(c,meyarkoochak);
            if(a==-1)
            {
                a=adadin(c,adad); 
                if(a!=-1)
                {
                    j = adad_tayinkon(c,adad,key , a); 
                    return adad[j];
                }
                else
                {throw new FormatException();}
            }
            else
            {
                j = adad_tayinkon(c,meyarkoochak,key,a); 
                return meyarkoochak[j];
            }
        }
        j= adad_tayinkon(c,meyarbozorg,key,a); 
        return meyarbozorg[j];
    }

    public static int adad_tayinkon(char c , string meyar , int key , int a)
    {
        if (a+key<meyar.Length) {return a+key;}
        return a + key- meyar.Length;
    }
}