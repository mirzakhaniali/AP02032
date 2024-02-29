using System;
using System.Io;
using std;
class mashgh
{
    static int barresi(string a , string b)
    {
        int i=0;
        while(a[i]!=0 | b[i]!=0)
    {
        if (b[i]==0 && a[i]!=0)
        {
            return 0;
        }
        if (b[i]!=0 && a[i]==0)
        {
            return 0;
        }
        if (b[i]!=a[i])
        {
            return 0;
        }
        i++;
    }
    return 1;
    }

    static async int main(string[] esmfile)
    {
        // az await estefade shode ta vaghti in khat ejra nashe baghie nemishan.
        await string[] dastoor=system.console.readline();
        string amalgar = dastoor[0];
        if(barresi(amalgar,"add")==1|barresi(amalgar,"add")==1)
        {
            File.AppendText(esmfile,dastoor[1]);
        }
        if(barresi(amalgar,"removeAt")==1)
        {
            string[] v;
            v=File.readAllText(esmfile);
            v=v.remove(parse(dastoor[1],parse(datoor[1])));
            File.WraiteAllText(esmfile,v);
        }
        if(barresi(amalgar,"remove")==1)
        {
            int x=<int>parse(dastoor[1]);
            string[] v;
            v=File.readAllText(esmfile);
            v=v.remove(parse(dastoor[1],parse(datoor[1])));
            File.WraiteAllText(esmfile,v);

        }

    }
    
}