using System.Collections.Generic;
using UnityEngine;


public class Practice411 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindPartyMember();
    }

public void FindPartyMember()
{
    List <string> questPartyMembers= new List <string> ()
        {"Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};

    questPartyMembers.Add("Craven the Necromancer");
    questPartyMembers.Insert(1, "Tanis the Thief");
    questPartyMembers.RemoveAt(0);
    // questPartyMembers.RemoveAt("Grim the Barbarian");
    
    int listLength = questPartyMembers.Count;
    Debug.LogFormat("Party members: {0}", listLength);
    for (int i = 0; i < listLength; i ++)
    {
        Debug.LogFormat("Index : {0} - {1}", i , questPartyMembers[i]);
        if(questPartyMembers[i] == "Merin the Wise")
        {
            Debug.Log("Glad you're here Merlin!");
        }
    }
}
}
