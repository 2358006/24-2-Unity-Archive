using System.Data;
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
        int characterLevel = 10;
        int nextSkillLevel = GenerateCharacter("Spike", characterLevel);
        // ComputerAge();

        // Debug.LogFormat("A string can have variables like {0} inserted directly", firstName);
        // Debug.Log($"A string can have variables like {firstName} inserted directly");   
        
        Debug.Log(nextSkillLevel);
        Debug.Log("Choose a character");
        GenerateCharacter("Spike", characterLevel);
        Debug.Log("A fine choice.");
    }

    /// <summary>
    /// 주석 추가 : CurrentAge와 AddedAge의 합을 출력한다.
    /// </summary>
    public void ComputerAge()
    {
        Debug.Log(currentAge + addAge);
    }

/*
    public void GenerateCharacter(string name, int level)
    {
        // Debug.Log("Character : Spike");
        Debug.LogFormat("character : {0} - Level : {1}", name, level);
    }
*/

public int GenerateCharacter(string name, int level)
    {
        // Debug.Log("Character : Spike");
        Debug.LogFormat("character : {0} - Level : {1}", name, level);

        return level += 5;
    }



    // Update is called once per frame
    void Update()
    {

    }
}