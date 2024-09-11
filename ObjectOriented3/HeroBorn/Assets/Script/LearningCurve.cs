    using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addAge = 1;


    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(30 + 1);
        // Debug.Log(currentAge + 1);

        ComputerAge();
    }

    // Update is called once per frame
    void Update()
    {

    }

/// <summary>
    /// 주석 추가 : CurrentAge와 AddedAge의 합을 출력한다.
    /// </summary>
    public void ComputerAge()
    {
    Debug.Log(currentAge + addAge);
    }
}