using UnityEngine;

public class LearningCurve506 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character506 hero = new Character506();
        Character506 villain = hero;
        villain.name = "Sir. Krane the Brave";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();
    }
}
