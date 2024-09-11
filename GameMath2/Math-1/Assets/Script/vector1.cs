using UnityEngine;

public class vector1 : MonoBehaviour
{
    // private float speed = 5.0f;
    // public float speed = 5.0f;
    [SerializeField]
    private float speed = 5.0f;

    // private Vector3 vecDierection = new Vector3(1, 0, 0);
    private Vector3 vecDierection1 = Vector3.right; // 오른쪽 
    // private Vector3 vecDierection = new Vector3(-1, 0, 0);
    private Vector3 vecDierection2 = Vector3.left; // 왼쪽
    // private Vector3 vecDierection = new Vector3(0, 1, 0);
    private Vector3 vecDierection3 = Vector3.up; // 위
    // private Vector3 vecDierection = new Vector3(0, -1, 0);
    private Vector3 vecDierection4 = Vector3.down; // 아래
    // private Vector3 vecDierection = new Vector3(0, 0, 1);
    private Vector3 vecDierection5 = Vector3.forward; // 앞
    // private Vector3 vecDierection = new Vector3(0, 0, -1);
    private Vector3 vecDierection6 = Vector3.back; // 뒤


    private void Awake()
    {
        // 1. Awake() 함수에서 이동 구현 (1회 호출)
        // - 이동 / 회전 / 크기를 조절하는 "Transform" 컴포넌트를 조작하여
        // 오브젝트를 이동 / 회전 / 크기 구현

        // 새로운 위치 = 현재 위치 + (방향 * 속도)

        // transform.position = transform.position + nrw Vector3(1, 0, 0) * 5;
        transform.position = transform.position + vecDierection1 * speed;
        transform.position = transform.position + vecDierection3 * speed;
        transform.position = transform.position + vecDierection5 * speed;
        transform.position = transform.position + vecDierection6 * speed;
        transform.position = transform.position + vecDierection4 * speed;
        transform.position = transform.position + vecDierection2 * speed;


        // 1 단위 방향, 두 점 사이의 거리, 각도 등의 연산을 위한 프로퍼티
        // Vector3.right : 오른쪽 방향 new Vector3(1, 0, 0)
    }

    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
