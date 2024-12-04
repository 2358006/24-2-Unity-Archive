using UnityEngine;

public class Character505
{
    public string name;
    public int exp = 0; 

    public Character505()
    {
        name = "Not assigned";
    }
    public Character505(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
