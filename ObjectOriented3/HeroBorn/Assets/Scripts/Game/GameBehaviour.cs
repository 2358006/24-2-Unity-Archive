using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameBehaviour : MonoBehaviour
{
    public int maxItems = 4;
    public TMP_Text healthText;
    public TMP_Text itemText;
    public TMP_Text progressText;
    public Button winButton;
    private int _itemsCollected = 0;
    private int _playerHp = 10;
    void Start()
    {
        itemText.text += _itemsCollected;
        healthText.text += _playerHp;
    }

    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            itemText.text = "Items : " + Items;

            if(_itemsCollected >= maxItems)
            {
                progressText.text = "You've found all the items!";
                winButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                progressText.text = "Item found only " + (maxItems - _itemsCollected) + "more to go" ;
            }
        }
    }
    public int HP
    {
        get {return _playerHp; }
        set
        {
            _playerHp = value;
            healthText.text = "Health : " + HP;
            Debug.LogFormat ("Items : {0}", _playerHp);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
