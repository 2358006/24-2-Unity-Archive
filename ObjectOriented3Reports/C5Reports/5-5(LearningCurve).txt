using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Character villain = hero;
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();
    }
}
