using UnityEngine;

public class LearningCurve414 : MonoBehaviour
{
    public int playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        HealthStatus();
    }

    public void HealthStatus()
    {
        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }
        Debug.Log("Player KO'd...");
    }
}
