using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorFunction : MonoBehaviour
{
    /*
     1. Vector3.back
        Vector3(0, 0, -1); 을 의미
     
     2. Vector3.down
        Vector3(0, -1, 0); 을 의미

     3. Vector3.forward
        Vector3(0, 0, 1);을 의미

     4. Vector3.left
        Vector3(-1, 0, 0);을 의미

     5. Vector3.negativeInfinity
        음수 무한대

     6. Vector3.positiveInfinity
        양수 무한대

     7. Vector3.one
        Vector3(1, 1, 1);을 의미

     8. Vector3.riht
        Vector3(1, 0, 0);을 의미
     
     9. Vector3.up
        Vector3(0, 1, 0);을 의미
    
    10. Vector3.zero
        Vector3(0, 0, 0);을 의미

    11. Vector3.magnitude
        읽기 전용 길이를 반환합니다. float

    12. Vector3.normalized()
        정규화시킨다. 크기가 1인 벡터를 반환

    13. Vector3.sqrMagnitude
        벡터의 길이 제곱 반환

    14. Vector3.Angle
        두 벡터 사이의 각도를 반환합니다.

    15. Vector3.Distance(x,y)
        두 벡터 사이의 길이를 반환
        
    16. Vector3.Dot(v1, v2)
         두 벡터의 내적을 반환

    17. Vector3.Max(v1, v2)
        두 벡터 중 가장 큰 수를 모아서 하나의 벡터로 만듭니다.
        
    ex)

    Vector a = new Vector3(1,2,3);
    Vector b = new Vector3(4,3,2);

    Debug.Log("Max of a and b : " + Vector3.Max(a,b));

    18. Vector3.Min(v1, v2);
        두 벡터 중 가장 작은 수를 모아서 하나의 벡터로 만듭니다.

    ex)

    Vector a = new Vector3(1,2,3);
    Vector b = new Vector3(4,3,2);

    Debug.Log("Max of a and b : " + Vector3.Min(a,b));


    19. Vector3.Normalize
        정규화시킵니다. 
        벡터의 크기를 1로 만듭니다.
        정규화되면 벡터는 같은 방향을 유지하지만 길이는 1.0입니다.
     */




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Vector3.back);
        Debug.Log(Vector3.positiveInfinity);
        Debug.Log(Vector3.zero);
        Debug.Log(Vector3.Magnitude(Vector3.back));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
