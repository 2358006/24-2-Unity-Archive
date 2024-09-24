using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No2AddMinus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 2. Vector의 덧셈과 뺄셈

        Vector3 v1 = new Vector3(1f, 2f, 0f);
        Vector3 v2 = new Vector3(2f, 1f, 0f);
        Vector3 v3 = v1 + v2;

        Debug.Log("v1 + v2 =" + (v3.x, v3.y, v3.z));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
