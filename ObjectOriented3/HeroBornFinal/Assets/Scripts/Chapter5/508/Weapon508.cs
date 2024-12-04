using UnityEngine;
public struct Weapon508
{
    public string name;
    public int damage;

    public Weapon508(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon : {0} - {1} DMG", this.name, this.damage);
    }
}