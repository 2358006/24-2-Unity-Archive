using UnityEngine;

public class No1Vector2andVector3 : MonoBehaviour
{
    private void Awake()
    {
        // Vector2, Vector3
        Vector2 vector2 = new Vector2(); 

        vector2.x = 1f;
        vector2.y = 1f;

        Debug.Log("벡터 2 : v1 + v2 = " + (vector2.x, vector2.y));
    
        Vector3 vector3 = new Vector3();

        vector3.x = 1f; // (1, 0, 0)
        vector3.y = 1f; // (0, 1, 0)
        vector3.z = 1f; // (0, 0, 1)
        
        Debug.Log("벡터 3 : v1 + v2 + v3 = " + (vector3.x, vector3.y, vector3.z));
    }
}
