#include<stdlib.h>
#include<stdio.h>
class str
{
    char * s;
    int tool_s;
    void ssaz(const char * b)
    {
        int i=0 ; 
        while (b[i]!=0)
        {
            s[i]=b[i];
            i++;
        }
    }
    void ssaz(const char * b , int andaze)
    {
        int i=0 ; 
        s=(char*)malloc(andaze*sizeof(char));
        while (b[i]!=0)
        {
            s[i]=b[i];
            i++;
        }
    }
public:
    int tool(const char* b) const
    {
        int i =0 ;
        while(b[i]!=NULL)
            i++;
        return i;
    }
    int tool_bede() const
    {
        return tool_s;
    }
    char* sbede() const 
    {
        char* r=(char*)malloc(sizeof(char)*tool_s);
        int i=0;
        while(i<tool_s)
        {
            r[i]=s[i];
            i++;
        }
        *(r+i)=0;
        return r;
    }
    str()
    {
        s=(char*)malloc(sizeof(char));
        tool_s=0;
    }
    str(const char* a)
    {
        tool_s=tool(a);
        s=(char*)malloc(tool_s*sizeof(char));
        ssaz(a);
    }
    str(const str& a)
    {
        tool_s=a.tool_bede();
        s=(char*)malloc(tool_s*sizeof(char));
        ssaz(a.sbede());
    }
    void append(const char* a)
    {
        char* r=(char*)malloc(sizeof(char)*(tool_s+tool(a)));
        int i=0,j=0;
        while(i<tool_s)
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
        free(s);
        s=r;
    }
    void append(const str& a)
    {
        char* r=(char*)malloc(sizeof(char)*(tool_s+a.tool_s));
        int i=0,j=0;
        while(i<tool_s)
        {
            r[i]=s[i];
            i++;
        }
        while(a.sbede()[j])
        {
            r[i]=a.sbede()[j];
            i++;
            j++;
        }
        free(s);
        s=r;
    }
    void print() const
    {
        int i =0 ;
        while(i<tool_s)
        {
            printf("%c",s[i]);
            i++;
        }
        printf("\n");
    }
    // const char* chars() const
    // {
    //     int i=0,j=0 ; 
    //     while(s[i])
    //     {
    //         printf("%c",s[i]);
    //         i++;
        // }
        // while(s[i])
        // // 32 همون اسپیسه.
        // {    if(s[i]==32)
        //         j++;
        //     i++;
        // }
        // char r[j];
        // i=0;
        // while(s[i])
        // {
        //     if(s[i]!=32)
        //     {   r[j]=s[i];
        //         j++;
        //     }
        //     i++;
        // }
    // }
    void replace(char ooni_ke_hast , char ooni_ke_mishe)
    {
        int i=0;
        while (s[i])
        {
            if (s[i]==ooni_ke_hast)
                s[i]=ooni_ke_mishe;
            i++;
        }
    }
    
    str substr(int start , int count) const
    {
        int i=0;
        char l[count+1];
        // الان خب اینکه وسطش استرینگ بدم میپرسه داداش این که دادی خودمم و طولش نامشخص میشه که . 
        // بعد اونوقت ارور میده نمیسازه که . 
        while(i<=count)
        {
            l[i]=s[start+i];
            i++;
        }
        str r(l);
        return r;
    }
};

int main ()
{
    str s("ali");
    s.print();
    s.replace('a','b');
    printf("%s\n",s.sbede());
    printf("%s\n",s.substr(0,1).sbede());
    return 0;
}