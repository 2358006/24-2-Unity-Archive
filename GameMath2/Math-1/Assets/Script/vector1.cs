using UnityEngine;

public class vector1 : MonoBehaviour
{
    // private float speed = 5.0f;
    // public float speed = 5.0f;
    [SerializeField]
    private float speed = 5.0f;

    // private Vector3 vecDierection = new Vector3(1, 0, 0);
    private Vector3 vecDierection1 = Vector3.right; // ������ 
    // private Vector3 vecDierection = new Vector3(-1, 0, 0);
    private Vector3 vecDierection2 = Vector3.left; // ����
    // private Vector3 vecDierection = new Vector3(0, 1, 0);
    private Vector3 vecDierection3 = Vector3.up; // ��
    // private Vector3 vecDierection = new Vector3(0, -1, 0);
    private Vector3 vecDierection4 = Vector3.down; // �Ʒ�
    // private Vector3 vecDierection = new Vector3(0, 0, 1);
    private Vector3 vecDierection5 = Vector3.forward; // ��
    // private Vector3 vecDierection = new Vector3(0, 0, -1);
    private Vector3 vecDierection6 = Vector3.back; // ��


    private void Awake()
    {
        // 1. Awake() �Լ����� �̵� ���� (1ȸ ȣ��)
        // - �̵� / ȸ�� / ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ�
        // ������Ʈ�� �̵� / ȸ�� / ũ�� ����

        // ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)

        // transform.position = transform.position + nrw Vector3(1, 0, 0) * 5;
        transform.position = transform.position + vecDierection1 * speed;
        transform.position = transform.position + vecDierection3 * speed;
        transform.position = transform.position + vecDierection5 * speed;
        transform.position = transform.position + vecDierection6 * speed;
        transform.position = transform.position + vecDierection4 * speed;
        transform.position = transform.position + vecDierection2 * speed;


        // 1 ���� ����, �� �� ������ �Ÿ�, ���� ���� ������ ���� ������Ƽ
        // Vector3.right : ������ ���� new Vector3(1, 0, 0)
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
