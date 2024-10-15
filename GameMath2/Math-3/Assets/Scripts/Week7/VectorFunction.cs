using UnityEngine;

public class VectorFunction : MonoBehaviour
{
    /*
    1. Vctor3.back
    Vector3(0, 0, -1);을 의미

    2. Vector3.down
    Vector3(0, -1, 0);을 의미

    3. Vector3.forward
    Vector3(0, 0, 1);을 의미

    4. Vector3.left
    Vector3(-1, 0,  0);을 의미

    5. Vector3.negativeInfinity
    음수 무한대

    6.  Vector3.positiveInfinity
    양수 무한대

    7. Vector3.one
    Vector3(1, 1, 1); 의미

    8. Vector3.right
    Vector3(1, 0,  0);을 의미

    9. Vector3.UP
    Vector3(0, 1, 0);을 의미
    
    10. Vector3.zero
    Vector3(0, 0, 0) 의미

    11. Vector3.Magnitude
    읽기 전용 길이 반환 float

    12. 
    */
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.back);
        Debug.Log(Vector3.positiveInfinity);
        Debug.Log(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
