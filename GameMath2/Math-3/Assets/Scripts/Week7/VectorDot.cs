using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorDot : MonoBehaviour
{
    /// <summary>
    /// 6. ������ ����
    /// ������ ������ ���Ϸ��� Vector3 Ŭ������ ���� �Լ���
    /// Dot �Լ��� ����ϸ� �˴ϴ�.
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 0f, 0f);
        Vector3 v45 = new Vector3(1f, 1f, 0);
        Vector3 v90 = new Vector3(0, 90, 0);
        Vector3 v135 = new Vector3(-1f, 1f, 0f);

        // ������ ����
        Debug.Log("V1, V45 = " + Vector3.Dot(v1, v45));
        Debug.Log("V1, V90 = " + Vector3.Dot(v1, v90));
        Debug.Log("V1, V135 = " + Vector3.Dot(v1, v135));

        // �� ���� ������ ����
        Debug.Log("Angle of V1, V45 = " + Vector3.Angle(v1, v45));
        Debug.Log("Angle of V1, V90 = " + Vector3.Angle(v1, v90));
        Debug.Log("Angle of V1, V135 = " + Vector3.Angle(v1, v135));

        /// <summary>
        /// ������ ������ ���ؼ� �����ߵ���,
        /// v1�� v45 ������ ������ 90�� ���� �۱� ������
        /// 0���� ū ���� ���԰�,
        /// v1�� v90 ���� ���� ��Ȯ�� 90���̱� ������ 0
        /// v1�� v135������ ���� 90������ Ŀ��
        /// 0���ٴ� ���� ���� ���� ���� Ȯ���� �� �ִ�.
        /// 
        /// Vector3�� �� �ٸ� �Լ��� Angle�Լ��� ����ϸ�
        /// �� ���� ������ ���� ���� �� �ִ�.
        /// 
        /// </summary>

    }

    // Update is called once per frame
    void Update()
    {

    }
}
