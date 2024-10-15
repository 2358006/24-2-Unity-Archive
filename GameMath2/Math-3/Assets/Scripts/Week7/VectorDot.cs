using UnityEngine;

public class VectorDot : MonoBehaviour
{
    /// <summary>
    ///  6. Vector의 내적
    ///  벡터의 내적을 구하려면 Vector3 클래스
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
    Vector3 v1 = new Vector3(2f, 0f, 0f);
    Vector3 v45 = new Vector3(1f, 1f, 0f);
    Vector3 v90 = new Vector3(0f, 90f, 0f);
    Vector3 v135 = new Vector3(-1f, 1f, 0f);
        
        // 벡터의 내적
        Debug.Log("v1 v45 = " + Vector3.Dot(v1, v45));
        Debug.Log("v1 v90 = " + Vector3.Dot(v1, v90));
        Debug.Log("v1 v135 = " + Vector3.Dot(v1, v135));

        // 두 벡터 사이의 각도
        Debug.Log("Angle Degree of v1, v45 = " + Vector3.Angle(v1, v45));
        Debug.Log("Angle Degree of v1, v90 = " + Vector3.Angle(v1, v90));
        Debug.Log("Angle Degree of v1, v135 = " + Vector3.Angle(v1, v135));

        ///<summary>
        /// 벡터의 내적에 대해서 설명했듯,
        /// v1과 v45 사이에 각도는 90도 보다 작기 때문에
        /// 0보다 큰 값이 나왔고,
        /// v1과 v90 사이 각은 정확히 90도이기 때문에 0
        /// v1과 v135 사이의 각은 90도 보다 커서 
        /// 0보다 작은 값이 나온 것을 확인 할 수 있다.
        ///
        /// vector3의 또다른 함수인 Angle 함수를 사용하면
        /// 두 벡터 사이의 각을 얻을 수 있다. 
        ///</summary>

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
