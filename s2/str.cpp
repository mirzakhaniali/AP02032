#include<stdlib.h>
#include<stdio.h>
class str
{
    char * s;
public:
    void ssaz(const char * b)
    {
        int i=0 ; 
        while (b[i]!=0)
        {
            s[i]=b[i];
            i++;
        }
    }
    int tool(const char* b) const
    {
        int i =0 ;
        while(b[i]!=NULL)
            i++;
        return i;
    }
    int tool() const
    {
        int i =0 ;
        while(s[i]!=0)
            i++;
        return i;
    }
    char* sbede() const 
    {
        char* r=(char*)malloc(sizeof(char)*tool());
        int i=0;
        while(s[i])
        {
            r[i]=s[i];
            i++;
        }
        return r;
    }
    str()
    {
        s=(char*)malloc(sizeof(char));
    }
    str(const char* a)
    {
        s=(char*)malloc(tool(a)*sizeof(char));
        ssaz(a);
    }
    str(const str& a)
    {
        s=(char*)malloc(a.tool()*sizeof(char));
        ssaz(a.sbede());
    }
    void append(const char* a)
    {
        char* r=(char*)malloc(sizeof(char)*(tool()+tool(a)));
        int i=0,j=0;
        while(i<tool())
        {
            r[i]=s[i];
            i++;
        }
        while(a[j])
        {
            r[i]=a[j];
            i++;
            j++;
        }
    }
    void append(const str& a)
    {
        char* r=(char*)malloc(sizeof(char)*(tool()+a.tool()));
        int i=0,j=0;
        while(i<tool())
        {
            r[i]=s[i];
            i++;
        }
        char g=a.sbede()[0];
        while(g)
        {
            r[i]=g;
            i++;
            j++;
            g=a.sbede()[j];
        }
    }
    void print() const
    {
        int i =0 ;
        while(i<tool())
        {
            printf("%c",s[i]);
            i++;
        }
    }
};