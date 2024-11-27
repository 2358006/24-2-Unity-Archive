using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class GameBehaviour : MonoBehaviour
{
    public int maxItems = 4;

    public TMP_Text healthText;
    public TMP_Text itemText;
    public TMP_Text progressText;

    void Awake()
    {
        itemText.text += _itemsCollected;
        healthText.text += _playerHp;
    }

    public Button winButton;
    public Button lossButton;

    public void UpdateScene(string updatedText)
    {
        progressText.text = "updated Text";
        Time.timeScale = 0f;
    }

    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set
        {
            _itemsCollected = value;
            itemText.text = "Items : " + Items;

            if(_itemsCollected >= maxItems)
            {
                UpdateScene("You've found all the items!");
                winButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                progressText.text = "Item found only " + (maxItems - _itemsCollected) + "more to go" ;
            }
        }
    }
    private int _playerHp = 10;
    public int HP
    {
        get {return _playerHp; }
        set
        {
            _playerHp = value;
            healthText.text = "Health : " + HP;

            if(_playerHp <= 0)
            {
                UpdateScene("You want anther life with that?");
                lossButton.gameObject.SetActive(true);
            }
            else
            {
                progressText.text = "Ouch... that's got hunt.";
            }
            Debug.LogFormat ("Items : {0}", _playerHp);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
