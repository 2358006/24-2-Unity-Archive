using UnityEngine;

public class Practice41 : MonoBehaviour
{
    public int currnetGold = 32;

    // Start is called before the first frame update
    void Start()
    {
        Thievery();
    }

    public void Thievery()
    {
        if(currnetGold > 50)
        {
            Debug.Log("You're rolling int it!");
        }
        else if(currnetGold < 15)
        {
            Debug.Log("Not much there to steel...");
        }
        else
        {
            Debug.Log("Looks like your purse is in  in the sweet spot.");
        }
    }
}
