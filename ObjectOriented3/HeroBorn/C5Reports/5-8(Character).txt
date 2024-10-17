using UnityEngine;
public class Character508
{
    public string name;
    public int exp = 0; 

    public Character508()
    {
        name = "Not assigned";
    }
    public Character508(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
