using UnityEngine;
public struct Weapon515
{
    public string name;
    public int damage;

    public Weapon515(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon : {0} - {1} DMG", this.name, this.damage);
    }
}