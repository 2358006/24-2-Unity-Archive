using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normaize : MonoBehaviour
{
    /// <summary>
    /// 5. 벡터의 정규화
    /// Vector3 구조체의 normalized 프로퍼티를 이용하면
    /// 정규화된 단위벡터를 가져올 수 있습니다.
    /// magnitude 프로퍼티를 사용하면 단위 벡터의 길이가
    /// 1임을 확인 할 수 있습니다.
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 2f, 0f);

        // 정규화된 단위 벡터
        Vector3 nomalizedVector = v1.normalized;
        Debug.Log("||v1|| = " + nomalizedVector);

        // v1의 길이
        Debug.Log("length of v1 = " + v1.magnitude);

        // 단위 벡터의 길이 확인
        Debug.Log("length of ||v1|| = " + nomalizedVector.magnitude);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
