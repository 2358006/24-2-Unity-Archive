using UnityEngine;
public class Character515
{
    public string name;
    public int exp = 0; 

    public Character515()
    {
    }
    public Character515(string name)
    {
        this.name = name;
    }
    public virtual void PrintStatsInfo() 
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
public class Paladin515 : Character515
{
    public Weapon515 weapon;
    public Paladin515(string name, Weapon515 weapon) : base(name)
    {
        this.weapon = weapon;
    }            
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name, this.weapon.name);
    }

}