using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addAge = 1;

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        ComputerAge();
        Debug.Log($"A string can have variables like {firstName} inserted directly");   
        Debug.LogFormat("A string can have variables like {0} inserted directly", firstName);
    }

    /// <summary>
    /// 주석 추가 : CurrentAge와 AddedAge의 합을 출력한다.
    /// </summary>
    public void ComputerAge()
    {
    Debug.Log(currentAge + addAge);
    }

    // Update is called once per frame
    void Update()
    {

    }
}