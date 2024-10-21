using UnityEngine;
public class Character513
{
    public string name;
    public int exp = 0; 

    public Character513()
    {
    }
    public Character513(string name)
    {
        this.name = name;
    }
    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero : {0} - {1} EXP", this.name, this.exp);
    }
}
public class Paladin513 : Character513
{
    public Weapon513 weapon;
    public Paladin513(string name, Weapon513 weapon) : base(name)
    {
        this.weapon = weapon;
    }            
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.name, this.weapon.name);
    }

}