using UnityEngine;

public class LearningCurve513 : MonoBehaviour
{
    Transform camTransform513;

    // Start is called before the first frame update
    void Start()
    {
        camTransform513 = this.GetComponent<Transform>();
        Debug.Log(camTransform513.localPosition);   
    }
}
