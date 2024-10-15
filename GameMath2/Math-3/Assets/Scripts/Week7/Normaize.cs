using UnityEngine;

public class Normaize : MonoBehaviour
{
    /// <summary>
    ///  5. 벡터의 정규화
    ///  Vector3 구조체의 normalized 프로퍼티를 이용하면
    ///  정규화된 단위벡터를 가져올 수 있다.
    ///  magnitude 프로퍼티를 사용하면 단위벡터의 길이가
    ///  1임을 확인 할 수 있다.
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3 (2f, 2f, 0f);
        // 정규화된 단위 벡터
        Vector3 normalizedVector = v1.normalized;
        Debug.Log("|| v1 || = " + normalizedVector);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
