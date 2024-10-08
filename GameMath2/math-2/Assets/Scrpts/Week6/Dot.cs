using UnityEngine;

public class Dot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 vector2 = new Vector2(); // Vector2 구조체

        /// <summary>
        /// Vector2 구조체는 2차원 평면 공간에 속하는 벡터
        /// 그래서 X축 좌표를 표시하기 위한 X 변수와 Y축 좌표를 표시하기 위한 Y 변수를 가진다.
        /// </summary>

        vector2.x = 1f;
        vector2.y = 1f;
        Debug.Log("v1 + v2 = " + (vector2.x + vector2.y));

        Vector3 vector3 = new Vector3(); // Vector3 구조체

        /// <summary>
        /// Vector3 구조체는 Vector2 구조체에 Z축을 더해 Z변수 까지 가진다.         
        ///</summary>
        
        vector3.x = 1f;
        vector3.y = 1f;
        vector3.z = 1f;
        Debug.Log("v1 + v2 + v3 = " + (vector3.x + vector3.y + vector3.z));

                /// <summary>
        /// 
        /// </summary>
    }
}
