using UnityEngine;
public class VectorCross : MonoBehaviour
{
    void Start()
    {
        Vector3 v1 = new Vector3(2f, 0f, 0f);
        Vector3 v2 = new Vector3(0f, 0f, 2f);

        // 벡터의 외적
        Debug.Log("v1 * v2 = " + Vector3.Cross(v1, v2));
    }
}
