using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class Practice48 : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
