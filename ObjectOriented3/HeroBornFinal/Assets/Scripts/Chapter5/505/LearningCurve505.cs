using UnityEngine;

public class LearningCurve505 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character505 hero = new Character505();
        Character505 villain = hero;
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();
    }
}
