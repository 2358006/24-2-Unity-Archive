using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� �۵�");
    }

    // Update is called once per frame
    void Update()
    {
        BallMovingX();
    }

    public void BallMovingX()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        Vector3 nextpos = vec * 10 * Time.deltaTime;
        transform.position += nextpos;

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� �̵���");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� �̵���");
        }
    }
}