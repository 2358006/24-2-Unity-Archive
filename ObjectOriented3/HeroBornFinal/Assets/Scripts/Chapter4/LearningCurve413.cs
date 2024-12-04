using System.Collections.Generic;
using UnityEngine;

public class LearningCurve413 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int> ()
        {
            {"Potion", 5},
            {"Antidote", 7},
            {"Aspirin", 1}
        };

        foreach(KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item : {0} - {1}g", kvp.Key, kvp.Value);
        }
    }
}
