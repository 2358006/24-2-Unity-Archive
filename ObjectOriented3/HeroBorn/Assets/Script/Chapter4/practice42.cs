using UnityEngine;

public class practice42 : MonoBehaviour
{
    public bool hasDungeonKey = false;
    public string weaponType = "Arcane Staff";

    // Start is called before the first frame update
    void Start()
    {
        if(!hasDungeonKey)
        {
            Debug.Log("You may not enter without the sacred key.");
        }
        if (weaponType != "LongSword")
        {
            Debug.Log("You don't appear to have the right typ weapon...");
        }
    }
}
