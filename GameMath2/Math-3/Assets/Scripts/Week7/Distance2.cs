using UnityEngine;
using UnityEngine.Scripting;

public class Distance2 : MonoBehaviour
{
    public Transform player;
    public float attackRange = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 2f, 0f);
        Vector3 v2 = new Vector3(5f, 7f, 0f);

        // 두 벡터 v1, v2 사이의 거리
        Debug.Log("Distance of v1, v2 = " + Vector3.Distance(v1, v2));
    }
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer < attackRange)
        {
            Debug.Log("플레이어가 공격범위 내에 있다. 공격 시작함 ㅅㄱ");
            // 여기에 공격 ㄱㄱ
        }
    }
}
