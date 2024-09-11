using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addAge = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(30 + 1);
        Debug.Log(currentAge + 1);

        ComputerAge();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void ComputerAge()
    {
       Debug.Log(currentAge + addAge);
    }
    
}
