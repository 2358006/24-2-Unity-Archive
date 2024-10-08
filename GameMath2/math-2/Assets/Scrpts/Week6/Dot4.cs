using UnityEngine;

public class Dot4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 4. 벡터의 길이
        // 벡터의 길이는 Vector3 구조체에 포함되어있는 
        // magnitude 프로퍼티를 통해서 가져올 수 있다
        // 이것은 Vector2 에서도 똑같다.

        Vector3 v1 = new Vector3(2f, 2f, 0);

        // 벡터의 길이        
        Debug.Log("Lenght of v1 : " + (v1.magnitude));
    }
}