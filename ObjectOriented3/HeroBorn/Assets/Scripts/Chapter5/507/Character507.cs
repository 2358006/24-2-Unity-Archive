using UnityEngine;
public class Character507
{
    public string name;
    public int exp = 0; 

    public Character507()
    {
        name = "Not assigned";
    }
    public Character507(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
