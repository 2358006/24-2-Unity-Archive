using UnityEngine;

public class LearningCurve511 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        Weapon511 huntingBow = new Weapon511("Hunting Bow", 105);
        Paladin511 knight = new Paladin511("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();
    }
}
