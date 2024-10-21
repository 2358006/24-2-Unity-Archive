using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    /// <summary>
    /// Vector3.Distance �Լ�
    /// - �� �� ������ �Ÿ��� ����ϴ� �� ���Ǵ� �Լ�
    /// - Vector3 Ÿ���� �� ���� �Է����� �ް� �� �� ������ ����
    /// �Ÿ��� float ���·� ��ȯ
    /// - �� �Լ��� ��� ����� ��Ŭ���� �Ÿ� ������ ���
    /// 
    /// ������
    /// Vector3.Distance �Լ��� ���� ���߿��� �ſ� �߿��� ������
    /// �Ѵ�.
    /// Ư��, �� ��ü ���� �Ÿ��� �Ǵ��Ͽ� Ư�� �̺�Ʈ�� 
    /// Ʈ�����ϴµ� ���ȴ�.
    /// 
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 2f, 0f);
        Vector3 v2 = new Vector3(5f, 7f, 0f);

        // �� ���� v1, v2 ������ �Ÿ�
        Debug.Log("Distance of V1, V2 = " + Vector3.Distance(v1, v2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
