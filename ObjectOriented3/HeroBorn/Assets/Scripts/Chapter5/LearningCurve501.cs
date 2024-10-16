using UnityEngine;

public class LearningCurve501 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character501 hero = new Character501("Agatha");
        Weapon501 huntingBow = new Weapon501("Hunting Bow", 105);
        Debug.LogFormat("hero : {0} - {1} EXP", hero.name, hero.exp);
        huntingBow.PrintWeaponStats();  
    }
}
