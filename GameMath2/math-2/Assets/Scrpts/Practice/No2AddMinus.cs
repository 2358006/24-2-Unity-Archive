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

        // 벡터의 덧셈
        Debug.Log("v1 + v2 =" + (v1 + v2));

        // 벡터의 뻴샘
        Debug.Log("v1 + v2 = " + (v1 - v2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
