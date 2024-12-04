using System.Collections.Generic;
using UnityEngine;

public class LearningCurve408 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List <string> questPartyMembers= new List <string> ()
        {
            "Grim the Barbarian", 
            "Merlin the Wise", 
            "Sterling the Knight"
        };

        Debug.LogFormat("Party members: {0}", questPartyMembers.Count);
    }
}
