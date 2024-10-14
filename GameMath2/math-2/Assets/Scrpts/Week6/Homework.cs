using UnityEngine;

public class Homework : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 벡터
        Vector2 vector2 = new Vector2 ();
        vector2.x = 100;
        vector2.y = 500;
        Debug.Log("1-1. 2차원 벡터 : v1 + v2 = " + (vector2.x + vector2.y));
        Vector3 vector3 = new Vector3 ();
        vector3.x = 1;
        vector3.y = 5;
        vector3.z = 100;
        Debug.Log("1-2. 3차원 벡터 : v1 + v2 + v3 = " + (vector3.x + vector3.y + vector3.z));

        // 벡터의 덧셈과 뻴셈
        Vector3 vPlusMinus1 = new Vector3(1f, 2f, 0f);
        Vector3 vPlusMinus2 = new Vector3(2f, 1f, 0f);
        Debug.Log("2-1. 벡터의 덧셈 : vPlusMinus1 + vPlusMinus2 = "+ (vPlusMinus1 + vPlusMinus2)); // 덧셈
        Debug.Log("2-2. 벡터의 뺄셈 : vPlusMinus1 - vPlusMinus2 = "+ (vPlusMinus1 - vPlusMinus2)); // 뺄셈

        // 벡터와 스칼라의 곱셈
        Vector3 vScalar1 = new Vector3(5f, 4f, 0); 
        int scalar = 4;
        Debug.Log("3. 벡터와 스칼라의 곱셈 : vScalar1 * scalar = " + (vScalar1 * scalar));

        // 벡터의 길이
        Vector3 vLenght1 = new Vector3(8f, 5f, 0);
        Debug.Log("4. Lenght of v1 : " + (vLenght1.magnitude));
    }
}
