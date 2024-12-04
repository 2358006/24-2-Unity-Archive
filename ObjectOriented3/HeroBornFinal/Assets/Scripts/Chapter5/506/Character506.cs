using UnityEngine;
public class Character506
{
    public string name;
    public int exp = 0; 

    public Character506()
    {
        name = "Not assigned";
    }
    public Character506(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
