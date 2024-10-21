using UnityEngine;
public struct Weapon507
{
    public string name;
    public int damage;

    public Weapon507(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon : {0} - {1} DMG", this.name, this.damage);
    }
}