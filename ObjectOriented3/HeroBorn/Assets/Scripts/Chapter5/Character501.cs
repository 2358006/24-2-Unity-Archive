using UnityEngine;

public class Character501
{
    public string name;
    public int exp = 0; 

    public Character501()
    {
        name = "Not assigned";
    }
    public Character501(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
