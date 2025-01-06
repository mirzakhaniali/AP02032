#include<stdlib.h>
#include<stdio.h>

// typedef t (*tabe_clas)(t , int , int);

#include <iostream>
using namespace std;


template<typename t> 
class matris
{
private:
    t** adad;
    int tool;
    int arz;

public:
    // void matris_saz(t* a)
    // {
    //     int i=0;
    //     while(i<tool*arz)
    //     {
    //         adad[i]=a[i];
    //         i++;
    //     }
    // }
    void matris_saz(t* a)
{
    adad =(int **) malloc(sizeof(t)*tool) ;
    int k=0;
    while()
    int i=0, j=0; 
    while(i<arz)
    {
        while(j<tool)
        {
            adad[i][j]=a[i*(tool)+j];
            j++;
        }
        j=0;
        i++;
    }
}
    matris(t* dade , int tool_dade,int arz_dade)
    {
        tool=tool_dade;
        arz=arz_dade;  
        // adad= new t[tool*arz];
        // int i=0;
        // while(i<arz)
        // {
        //     adad[i]=(int*)malloc(sizeof(int)*tool);
        //     i++;
        // }
        matris_saz(dade);
    }
    
    matris(const matris & dade)
    {
        tool=dade.tool;
        arz=dade.arz;
        // adad=(t*)malloc(sizeof(t*)*tool)
        adad=new t[tool*arz];
        int i=0;
        // while(i<arz)
        // {
        //     adad[i]=(t)malloc(sizeof(t)*arz);
        //     i++;
        // }
        matris_saz(dade.mbede());
    }
    t* mbede()
    {
        // t* r=(t*)malloc(sizeof(t*)*tool);
        // int k=0;
        // while(k<arz)
        // {
        //     adad[k]=(t)malloc(sizeof(t)*arz);
        //     k++;
        // }
        t* r = new t[tool*arz];
        int i=0 ; 
        while (i<tool*arz)
        {
            r[i]=adad[i];    
            i++;
        }
        return r;
    }
    t at(int makan_tool , int makan_arz)
    {
        return adad[makan_tool-1+(makan_arz-1)*tool]
    }
    t jam(const matris& a, int makan_tool,int makan_arz)
    { 
        t r = a.at(makan_tool,makan_arz)+at(makan_tool,makan_arz);
        return r;
    }
    t kam(const matris & a , int makan_tool , int makan_arz)
    { 
        t r = at(makan_tool,makan_arz) -a.at(makan_tool,makan_arz);
        return r;
    }
    t* jam(const matris& a)
    {
        if(a.tool==tool)
        {
            t* r=(t*)malloc(sizeof(t*)*tool);
            int i =0, j=0 ; 
            while(i<tool)
            {
                while (j<arz)
                {
                r[i][j]=jam(a,i,j);
                j++;
                }
                j=0;
                i++;
            }
            return r;
        }
        return nullptr;
    }
    t* kam(const matris& a)
    {
            t* r=(t*)malloc(sizeof(t*)*tool);
            int i =0, j=0 ; 
            while(i<tool)
            {
                while (j<arz)
                {
                r[i][j]=kam(a,i,j);
                j++;
                }
                j=0;
                i++;
            }
            return r;
    }
    // t* zarb()
};

int main()
{
    int r[2*2]={2,3,1,2};
    matris<int> m(r,2,2);
    return 0;
}