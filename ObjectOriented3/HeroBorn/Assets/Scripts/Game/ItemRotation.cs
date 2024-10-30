using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    public int rotationSpeed = 100;
    private Transform itemTransform;
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }
}
