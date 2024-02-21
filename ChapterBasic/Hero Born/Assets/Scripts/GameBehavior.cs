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
    private string _state;
    public int MaxItems = 4;
    public Text HealthText;
    public Text ItemText;
    public Text ProgressText;
    public Button WinButton;
    public Button LossButton;
    public Stack<string> LootStack = new Stack<string>();
    public Queue<string> activePlayers = new Queue<string>();
    public HashSet<string> people = new HashSet<string>(){
        "Joe",
        "Joan",
        "Hank",
    };
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
        //? Stack
        LootStack.Push("Sword of Doom");
        LootStack.Push("HP Boost");
        LootStack.Push("Golden Key");
        LootStack.Push("Pair of Winged Boots");
        LootStack.Push("Mythril Bracer");
        //? Queue
        activePlayers.Enqueue("Harrison");
        activePlayers.Enqueue("Alex");
        activePlayers.Enqueue("Haley");
    }
    public void PrintLootReport()
    {
        var currentItem = LootStack.Pop();
        var nextItem = LootStack.Peek();
        var firstPlayer = activePlayers.Peek();
        var getPlayer = activePlayers.Dequeue();
        Debug.LogFormat("The first player is {0} and we take it out of queue {1}", firstPlayer, getPlayer);
        Debug.LogFormat("You got a {0}! You've got a good chance of finding a {1} next!", currentItem, nextItem);
        Debug.LogFormat("There are {0} random loot items waiting for you", LootStack.Count);
    }
}
