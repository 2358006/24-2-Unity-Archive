    using System.Collections.Generic;
using UnityEngine;

public class Practice410 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List <string> questPartyMembers= new List <string> ()
        {"Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};

        int listLength = questPartyMembers.Count;
        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index : {0} - {1}", i, questPartyMembers[i]);
        }
    }
}
