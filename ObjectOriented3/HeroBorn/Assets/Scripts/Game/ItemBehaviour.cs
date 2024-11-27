using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehaviour : MonoBehaviour
{
    public GameBehaviour gameManager;
    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("아이템 딸깍");

            gameManager.Items +=1;
        }
    }
}
