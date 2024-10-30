using UnityEngine;

public class Practice404 : MonoBehaviour
{
    public string charcterAction = "Attack";
    // Start is called before the first frame update
    void Start()
    {
        PrintCharacterAction();
    }

void PrintCharacterAction()
{
    switch (charcterAction)
    {
        case "Heal" :
        Debug.Log("Potion sent");
        break;
        case "Attack" :
        Debug.Log("To arms!");
        break;
        default :
        Debug.Log("Shields up.");
        break;
    }
}
}
