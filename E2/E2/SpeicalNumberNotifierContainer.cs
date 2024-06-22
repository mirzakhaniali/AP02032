namespace E2;
public interface ISpecialNumberNotifierContainer
{
    void add(int x);
    event Action<int> SpecialNumberAdded;
    Func<int,bool> SpecialNumberIdentifier { get; set; }
    int this[int i] { get;  set; }
}


public class SpecialNumberNotifierContainer : ISpecialNumberNotifierContainer
{
    private List<int> ints;

    public SpecialNumberNotifierContainer()
    {
        this.ints = new List<int>();
    }

    public int this[int i] { get => this.ints[i]; set => this.ints[i]=value; }

    public Func<int, bool> SpecialNumberIdentifier { get ; set ;}
    public event Action<int> SpecialNumberAdded;

    public void add(int x)
    {
        this.ints.Add(x);
        if(this.SpecialNumberIdentifier!=null)
            if(this.SpecialNumberIdentifier.Invoke(x))
                this.SpecialNumberAdded.Invoke(x);
    }
}