﻿using System.Configuration;
using System.Data;
using System.Windows;
using System;
using System.Io;
using std;

namespace s7;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
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
            string[] v=File.readAllText(esmfile);
            v=v.remove(parse(dastoor[1])-1,parse(datoor[1]));
            File.WraiteAllText(esmfile,v);
        
        }
        
        if(barresi(amalgar,"remove")==1)
        {
            int i=0 , yaftan=0;
            string[] v=File.readAllText(esmfile);
            int x=v[0].indexof(dastoor[1]);
            while(i<v.size())
            {
                if(x!=-1)
                {
                    
                    string tikke=v[i].remove(x,x+1);
                    int j=0;
                    v[i]=tikke;
                    File.WraiteAllText(esmfile,v);
                    system.console.writeline("amalaiat movafagh");
                    yaftan=1;
                    break;
                }
                x=v[i].indexof(dastoor[1]);
                i++;
            }
            if(yaftan==0)
            {
                system.console.writeline("adade dade shode yaft nashod");
            }        
        }
        
        if(barresi(amalgar,"removeAll")==1)
        {
            int i=0 , yaftan=0;
            string[] v=File.readAllText(esmfile);
            int x=v[0].indexof(dastoor[1]);
            while(i<v.size())
            {
                if(x!=-1)
                {
                    
                    string tikke=v[i].remove(x,x+1);
                    int j=0;
                    v[i]=tikke;
                    system.console.writeline("amalaiat movafagh");
                    yaftan=1;
                }
                x=v[i].indexof(dastoor[1]);
                i++;
            }
            if(yaftan==1)
            {
                File.WraiteAllText(esmfile,v);
            }
            else
                system.console.writeline("adade dade shode yaft nashod");        
        }
    
        if(barresi(amalgar,"list")==1)
        {
            string[] v=File.readAllText(esmfile);
            int i=0;
            while(i<v.size())
            {
                system.console.writeline(v[i]);
                i++;
            }
        }
    
        
    }
}

