using UnityEngine;

public class LearningCurve508 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon508 huntingBow = new Weapon508("Hunting Bow", 105);
        Weapon508 warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }
}
