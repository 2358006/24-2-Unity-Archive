using UnityEngine;

public class No3Multiply : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 3. Vector와 스칼라의 곱셈
        // 벡터 : 방향 + 크기
        // 스칼라 : 방향

        Vector3 v1 = new Vector3(1f, 1, 0);
        int scalar = 4;

        //벡터와 스칼라 곱셈
        Debug.Log("벡터와 스칼라 곱셈 : v1 * scalar = " + (v1 * scalar));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
