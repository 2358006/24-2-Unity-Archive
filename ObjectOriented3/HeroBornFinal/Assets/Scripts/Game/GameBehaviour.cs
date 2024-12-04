using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameBehaviour : MonoBehaviour
{
    public int maxItems = 4;
    public int maxEnemys = 4;

    public TMP_Text healthText;
    public TMP_Text itemText;
    public TMP_Text enemyText;
    public TMP_Text progressText;

    void Awake()
    {
        itemText.text += _itemsCollected;
        healthText.text += _playerHp;
        enemyText.text += _enemyCount;
        progressText.text = "Lego Lego";
    }

    public Button winButton;
    public Button lossButton;

    public void UpdateScene(string updatedText)
    {
        progressText.text = updatedText;
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
        }
    }

    private int _enemyCount = 0;
    public int Enemys
    {
        get { return _enemyCount; }
        set
        {
            _enemyCount = value;
            enemyText.text = "Enemy : " + Enemys;

            if (_enemyCount >= maxEnemys)
            {
                UpdateScene("You've kill all enemys");
                winButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                progressText.text = "U can kill " + (maxEnemys - _enemyCount) + " enemys.";
            }
        }
    }



    private int _playerHp = 10;
    public int HP
    {
        get { return _playerHp; }
        set
        {
            _playerHp = value;
            healthText.text = "Health : " + HP;

            if (_playerHp <= 0)
            {
                UpdateScene("You want anther life with that?");
                lossButton.gameObject.SetActive(true);
            }
            else
            {
                progressText.text = "Ouch... that's got hunt.";
            }
            Debug.LogFormat("Items : {0}", _playerHp);
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
