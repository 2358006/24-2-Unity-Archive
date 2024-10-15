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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
