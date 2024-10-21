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
            Debug.Log("플레이어가 공격 범위 내에 있습니다. 공격을 시작합니다.");
            // 여기에 공격 로직을 추가
        }
    }
}
