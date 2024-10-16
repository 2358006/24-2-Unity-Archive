using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not assigned";
    }

        public Character(string name)
    {
        this.name = name;
    }
}
