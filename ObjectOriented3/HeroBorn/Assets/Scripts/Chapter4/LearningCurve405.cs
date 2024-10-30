using UnityEngine;

public class LearningCurve405 : MonoBehaviour
{
    public int diceRoll = 7;

    // Start is called before the first frame update
    void Start()
    {
        RollDice();
    }

    public void RollDice()
    {
        switch (diceRoll)
        {
            case 7 :
            case 15 :
            Debug.Log("Mediorce damage, not bad.");
            break;
            case 20 :
            Debug.Log("Critical hit, the creature goes down!");
            break;
            default :
            Debug.Log("You completely missed and fell on your face.");
            break;
        }
    }
}