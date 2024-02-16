using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameBehavior : MonoBehaviour
{
    private int _ItemCollect = 0;
    private float _playerHP = 10f;
    public int MaxItems = 4;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    void Start()
    {
        ItemText.text += _ItemCollect;
        HealthText.text += _playerHP;
    }
    public int Items
    {
        get
        {
            return _ItemCollect;
        }
        set
        {
            _ItemCollect = value;
            ItemText.text = "Item Collected: " + Items;
            if (_ItemCollect >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
                WinButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else{
                ProgressText.text = "Item found, only " 
                + (MaxItems - _ItemCollect) + " more to go";
            }
        }
    }
    public float HP
    {
        get
        {
            return _playerHP;
        }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }


}
