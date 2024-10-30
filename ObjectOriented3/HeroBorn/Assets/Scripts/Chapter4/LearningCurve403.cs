using UnityEngine;

public class LearningCurve403 : MonoBehaviour
{
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";
    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
    }

    public void OpenTreasureChamber()
    {
        if(pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else 
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }
}
