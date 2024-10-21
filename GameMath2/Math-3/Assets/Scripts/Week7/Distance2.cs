using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance2 : MonoBehaviour
{
    public Transform player;
    public float attackRange = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < attackRange)
        {
            Debug.Log("�÷��̾ ���� ���� ���� �ֽ��ϴ�. ������ �����մϴ�.");
            // ���⿡ ���� ������ �߰�
        }
    }
}
