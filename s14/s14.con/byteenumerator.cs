using System.Collections;
using System.Collections.Generic;

public class byteenumerable : IEnumerable
{
    public string m_voroodi{ get; set; }
    public byteenumerable(string voroodi)
    {
        this.m_voroodi= voroodi; 
    }
    public IEnumerator GetEnumerator()
    {
        return new byteenumerator(this);
    }
}

public class byteenumerator : IEnumerator<byte>
{
    string m_voroodi{get; set; }
    int jaygah{get; set; }=-1; 
    public byte Current { get
    {
        return (byte) m_voroodi[jaygah];
    } }

    object IEnumerator.Current => (byte) m_voroodi[jaygah];

    public void Dispose()
    {
        Reset();
    }

    public bool MoveNext()
    {
        jaygah++;
        return jaygah<m_voroodi.Length;
    }

    public void Reset()
    {
        jaygah=-1;
    }

    public byteenumerator(byteenumerable a)
    {
        this.m_voroodi = a.m_voroodi;
    }
}
