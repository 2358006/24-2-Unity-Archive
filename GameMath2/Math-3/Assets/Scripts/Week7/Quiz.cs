using UnityEngine;
public class Quiz : MonoBehaviour
{
    void Start()
    {
        Quiz1();
        Quiz2();
        Quiz3();
        Quiz4();
    }

    void Quiz1()
    {
        Vector3 v1a = new Vector3(1, 3, 4);
        Vector3 v1b = new Vector3(2, 7, 5);
        Debug.Log("1. a * b = " + Vector3.Cross(v1a, v1b));
    }

    void Quiz2()
    {
        Vector3 v2a = new Vector3(2, 8, -3);
        Vector3 v2b = new Vector3(-4, 3, 5);
        Debug.Log("2.  a * b = " + Vector3.Cross(v2a, v2b));
    }

    void Quiz3()
    {
        Vector3 v3a = new Vector3(-1, 5, 3);
        Vector3 v3b = new Vector3(-4, -3, -9);
        Debug.Log("3. a * b = " + Vector3.Cross(v3a, v3b));
    }

    void Quiz4()
    {
        Vector3 v4a = new Vector3(5, 9, 10);
        Vector3 v4b = new Vector3(-4, -7, -8);
        Debug.Log("4. a * b = " + Vector3.Cross(v4a, v4b));
    }

}
