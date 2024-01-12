using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddAge = 1;
    public float Pi = 3.14f;
    public string FirstName = "Nam";
    public bool IsAuthor = false;
    public bool hasDungeonKey = false;
    public bool weaponEquipped = true;
    public int CurrentGold = 32;
    public string weaponType = "Arcane Staff";
    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";
    string CharacterAttack = "Attack";
    int DiceRoll = 7;
    // Start is called before the first frame update
    void Start()
    {
        if (hasDungeonKey)
        {
            Debug.Log("You process the sacred key - enter.");
        }
        else
        {
            Debug.Log("You have not proved yourself yet.");
        }
        Thievery();
        if (!hasDungeonKey)
        {
            Debug.Log("You may not enter without the sacred key");
        }
        if (weaponType != "LongSword")
        {
            Debug.Log("You don't appear to have the right type of weapon...");
        }
        if (weaponEquipped)
        {
            if (weaponType == "LongSword")
            {
                Debug.Log("For the queen!");
            }
        }
        else
        {
            Debug.Log("Fists aren't going to work against armor...");
        }
        OpenTreasureChamber();
        PrintCharacterAction();
        RollDice();
    }
    /// <summary>
    /// Time to action - adding comments
    /// Computer a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddAge);
        Debug.LogFormat($"Text goes here, add {CurrentAge}");
    }
    /// <summary>
    /// Test declare method
    /// </summary>
    public void GenerateCharacter()
    {
        Debug.Log("Character: Spike");
    }
    public int GenerateCharacter(string name, int level)
    {
        // Debug.LogFormat("Character: {0} - Level: {1}"
        // , name, level);
        return level += 5;
    }
    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not ,ucj there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }

    }
    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }

    }
    public void PrintCharacterAction()
    {
        switch (CharacterAttack)
        {
            case "Heal":
                Debug.Log("Point sent");
                break;
            case "Attack":
                Debug.Log("To arms");
                break;
            default:
                Debug.Log("Shields up");
                break;
        }
    }
    public void RollDice()
    {
        switch (DiceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20: 
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
