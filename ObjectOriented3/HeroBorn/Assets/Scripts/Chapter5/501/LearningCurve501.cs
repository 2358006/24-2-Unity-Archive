using UnityEngine;

public class LearningCurve501 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character501 hero = new Character501();
        hero.PrintStatsInfo();

        Character501 heroine = new Character501("Agatha");
        heroine.PrintStatsInfo();

        Weapon501 huntingBow = new Weapon501("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();
    }
}
