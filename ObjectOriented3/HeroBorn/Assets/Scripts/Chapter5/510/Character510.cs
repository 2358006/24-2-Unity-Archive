using UnityEngine;
public class Character510
{
    public string name;
    public int exp = 0; 

    public Character510()
    {
        Reset();
    }
    public Character510(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}
public class Paladin510 : Character510
{
    public Paladin510(string name) : base(name)
    {

    }
}