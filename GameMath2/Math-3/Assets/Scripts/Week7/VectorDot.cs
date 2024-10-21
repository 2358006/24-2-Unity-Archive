using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDot : MonoBehaviour
{
    /// <summary>
    /// 6. 벡터의 내적
    /// 벡터의 내적을 구하려면 Vector3 클래스의 정적 함수인
    /// Dot 함수를 사용하면 됩니다.
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 0f, 0f);
        Vector3 v45 = new Vector3(1f, 1f, 0);
        Vector3 v90 = new Vector3(0, 90, 0);
        Vector3 v135 = new Vector3(-1f, 1f, 0f);

        // 벡터의 내적
        Debug.Log("V1, V45 = " + Vector3.Dot(v1, v45));
        Debug.Log("V1, V90 = " + Vector3.Dot(v1, v90));
        Debug.Log("V1, V135 = " + Vector3.Dot(v1, v135));

        // 두 벡터 사이의 각도
        Debug.Log("Angle of V1, V45 = " + Vector3.Angle(v1, v45));
        Debug.Log("Angle of V1, V90 = " + Vector3.Angle(v1, v90));
        Debug.Log("Angle of V1, V135 = " + Vector3.Angle(v1, v135));

        /// <summary>
        /// 벡터의 내적에 대해서 설명했듯이,
        /// v1과 v45 사이의 각도는 90도 보다 작기 때문에
        /// 0보다 큰 값이 나왔고,
        /// v1과 v90 사이 각은 정확히 90도이기 때문에 0
        /// v1과 v135사이의 각은 90도보다 커서
        /// 0보다는 작은 값이 나온 것을 확인할 수 있다.
        /// 
        /// Vector3의 또 다른 함수인 Angle함수를 사용하면
        /// 두 벡터 사이의 각을 얻을 수 있다.
        /// 
        /// </summary>

    }

    // Update is called once per frame
    void Update()
    {

    }
}
