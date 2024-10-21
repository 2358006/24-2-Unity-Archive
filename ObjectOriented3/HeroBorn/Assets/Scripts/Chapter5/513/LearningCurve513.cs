using UnityEngine;

public class LearningCurve513
{
    public Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);
    }
}
