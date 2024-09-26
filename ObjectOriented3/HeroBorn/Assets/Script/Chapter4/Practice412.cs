using System.Collections.Generic;
using UnityEngine;

public class Practice412 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List <string> questPartyMembers= new List <string> ()
        {"Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat  ("{0} - Here!",partyMember);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
