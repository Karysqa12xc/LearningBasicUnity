using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using CustomExtensions;
public class GameBehavior : MonoBehaviour, IManger
{
    private int _ItemCollect = 0;
    private float _playerHP = 10f;
    public int MaxItems = 4;
    private string _state;
    private string _testTxt;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    public Button LossButton;
    void Start()
    {
        ItemText.text += _ItemCollect;
        HealthText.text += _playerHP;
        Initialize();
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
                WinButton.gameObject.SetActive(true);
                UpdateScene("You've found all the items!");
            }
            else
            {
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
            if (_playerHP <= 0)
            {
                LossButton.gameObject.SetActive(true);
                UpdateScene("You want another life with that?");
            }
            else
            {
                ProgressText.text = "It's hurt";
            }
        }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void RestartGame()
    {
        Utilities.RestartLevel(0);
    }
    public void UpdateScene(string updateText)
    {
        ProgressText.text = updateText;
        Time.timeScale = 0f;
    }

    public void Initialize()
    {
        _state = "Game Manager initialize";
        _state.FancyDebug();
        Debug.Log(_state);
    }
}
