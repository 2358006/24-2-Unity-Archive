using UnityEngine;

public class Dot2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 2. 벡터의 덧셈과 뺼샘

        // 벡터의 덧셉과 뺄셈은 간단히 덧셈과 뻴셈을 하듯이 연산자를 사용하면 바로 구할 수 있다.

        Vector3 v1 = new Vector3(1f, 2f, 0f);
        Vector3 v2 = new Vector3(2f, 1f, 0f);

        // 벡터의 덧셈
        Debug.Log("v1 + v2 = "+ (v1 + v2));
        // 벡터의 뺄셈
        Debug.Log("v1 - v2 = "+ (v1 - v2));
    }
}
