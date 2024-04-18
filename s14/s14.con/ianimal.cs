using System.Collections;
using System.Reflection.Metadata.Ecma335;

public interface IAnimal
{
    /* ای باید یه نوع صدای حیوان رو داشته باشه . که یه استرینگه 
    همچنین یه نوع حرکت اون که مثلا خزنده است رو با راه میره یا تو آب شنا 
    میکنه . هردو استرینگ .  */
    string sound{get;}
    
    string move {get;}

    string name{get; }
}




public class heyvoon : IAnimal
{
    public string sound {get; set;}

    public string move {get; set;}

    public string name {get;set;}

    public heyvoon(string name,string sound, string move)
    {
        this.name = name;
        this.sound = sound;
        this.move = move;
    }

}