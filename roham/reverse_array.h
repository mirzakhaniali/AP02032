#include<stdlib.h>
#include<stdio.h>
#include<iostream>
using namespace std;

int tooldarar(char* s)
{
    int i=0;
    while(s[i]!=0)
    {
        i++;
    }
    return i;
}

void khalikon(char* d,int j)
{
    for(int i=0; i<j ; i++)
    {
        d[i]=0;
    }
}

void khalikon(char* d)
{
    for(int i=0; d[i]!=0 ; i++)
    {
        d[i]=0;
    }
}

char* porkon(char* d , int j)
{
    char sdk[20];
    int i=0;
    while(i<j)
    {
        sdk[i]=d[i];
        i++;
    }
    return sdk;
}

char* porkon(char* d , char* sdk )
{
    int i=0;
    while(d[i]!=0)
    {
        sdk[i]=d[i];
        i++;
    }
    sdk[i]=0;
    return sdk;
}

void splter(char** sdk,char* s, char a , int tedad)
{
    char d[20];
    khalikon(d,21);
    char sd[100];
    int i=0 , j=0 , k=0;
    while(k<tedad)
    {
        if(s[i]==a)
        {
            sdk[k]=porkon(d,j);
            khalikon(d,j);
            i++;
            j=0;
            k++;
            if(k>=tedad)
                return;
        }
        d[j]=s[i];
        i++;
        j++;
    }
    sdk[k]=d;
}

void baraks(char** st,int tedad)
{
    //اینجا میخوام بگم یه دونه بساز از نفر تعدادم بیا عقب روش . 
    char* sdk[20];
    int i=0 ; 
    while(i<tedad)
    {
        sdk[i]=st[tedad-i-1];
        i++;
    }
    i=0;
    while(i<tedad)
    {
        st[i]=sdk[i];
        i++;
    }
}

char** asli()
{
    char* s[20] ;
    char sq[10];
    int tedad , k=0;
    scanf("%d\n",&tedad);
    for(int i =0; i<tedad ; i++)
    {
        scanf("%d " , &sq);
        // int j = tooldarar(sq);
        porkon(sq , s[k]);
        khalikon(sq);
        k++;
    }
    int araye1[100];
    baraks(s,tedad);
    for(int i=0 ; i<tedad ; i++)
        printf("%s" , s[i]);
    return s;
}
