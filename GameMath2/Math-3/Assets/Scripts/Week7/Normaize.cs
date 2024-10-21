using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normaize : MonoBehaviour
{
    /// <summary>
    /// 5. ������ ����ȭ
    /// Vector3 ����ü�� normalized ������Ƽ�� �̿��ϸ�
    /// ����ȭ�� �������͸� ������ �� �ֽ��ϴ�.
    /// magnitude ������Ƽ�� ����ϸ� ���� ������ ���̰�
    /// 1���� Ȯ�� �� �� �ֽ��ϴ�.
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 2f, 0f);

        // ����ȭ�� ���� ����
        Vector3 nomalizedVector = v1.normalized;
        Debug.Log("||v1|| = " + nomalizedVector);

        // v1�� ����
        Debug.Log("length of v1 = " + v1.magnitude);

        // ���� ������ ���� Ȯ��
        Debug.Log("length of ||v1|| = " + nomalizedVector.magnitude);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
