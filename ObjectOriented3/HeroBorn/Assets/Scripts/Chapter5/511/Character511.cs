using UnityEngine;
public class Character511
{
    public string name;
    public int exp = 0; 

    public Character511()
    {
    }
    public Character511(string name)
    {
        this.name = name;
    }
    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
public class Paladin511 : Character511
{
    public Weapon511 weapon;
    public Paladin511(string name, Weapon511 weapon) : base(name)
    {
        this.weapon = weapon;
    }            
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name, this.weapon.name);
    }

}