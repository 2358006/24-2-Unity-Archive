using UnityEngine;

public class Dot3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 3. 벡터와 스칼라의 곱셈
        // 벡터와 스칼라, 단일 정수 or 혹은 실수와의 곱셈
        // 역실 일반 계산과 같이 간단하다 .

        Vector3 v1 = new Vector3(1f, 1f, 0); 

        int scalar = 4;

        // 벡터와 스칼라의 곱셈
        Debug.Log("v1 * scalar = " + (v1 * scalar));
    }
}
