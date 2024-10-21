using UnityEngine;

public class LearningCurve507 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon507 huntingBow = new Weapon507("Hunting Bow", 105);
        Weapon507 warBow = huntingBow;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }
}
