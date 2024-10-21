using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorFunction : MonoBehaviour
{
    /*
     1. Vector3.back
        Vector3(0, 0, -1); �� �ǹ�
     
     2. Vector3.down
        Vector3(0, -1, 0); �� �ǹ�

     3. Vector3.forward
        Vector3(0, 0, 1);�� �ǹ�

     4. Vector3.left
        Vector3(-1, 0, 0);�� �ǹ�

     5. Vector3.negativeInfinity
        ���� ���Ѵ�

     6. Vector3.positiveInfinity
        ��� ���Ѵ�

     7. Vector3.one
        Vector3(1, 1, 1);�� �ǹ�

     8. Vector3.riht
        Vector3(1, 0, 0);�� �ǹ�
     
     9. Vector3.up
        Vector3(0, 1, 0);�� �ǹ�
    
    10. Vector3.zero
        Vector3(0, 0, 0);�� �ǹ�

    11. Vector3.magnitude
        �б� ���� ���̸� ��ȯ�մϴ�. float

    12. Vector3.normalized()
        ����ȭ��Ų��. ũ�Ⱑ 1�� ���͸� ��ȯ

    13. Vector3.sqrMagnitude
        ������ ���� ���� ��ȯ

    14. Vector3.Angle
        �� ���� ������ ������ ��ȯ�մϴ�.

    15. Vector3.Distance(x,y)
        �� ���� ������ ���̸� ��ȯ
        
    16. Vector3.Dot(v1, v2)
         �� ������ ������ ��ȯ

    17. Vector3.Max(v1, v2)
        �� ���� �� ���� ū ���� ��Ƽ� �ϳ��� ���ͷ� ����ϴ�.
        
    ex)

    Vector a = new Vector3(1,2,3);
    Vector b = new Vector3(4,3,2);

    Debug.Log("Max of a and b : " + Vector3.Max(a,b));

    18. Vector3.Min(v1, v2);
        �� ���� �� ���� ���� ���� ��Ƽ� �ϳ��� ���ͷ� ����ϴ�.

    ex)

    Vector a = new Vector3(1,2,3);
    Vector b = new Vector3(4,3,2);

    Debug.Log("Max of a and b : " + Vector3.Min(a,b));


    19. Vector3.Normalize
        ����ȭ��ŵ�ϴ�. 
        ������ ũ�⸦ 1�� ����ϴ�.
        ����ȭ�Ǹ� ���ʹ� ���� ������ ���������� ���̴� 1.0�Դϴ�.
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
