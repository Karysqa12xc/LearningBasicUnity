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
    int CharacterLevel = 32;
    // Start is called before the first frame update
    void Start()
    {
        int myInteger = 3;
        float myFloat = myInteger;
        int explicitConversion = (int)3.14;
        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted directly");
        Debug.Log(myInteger);
        Debug.Log(myFloat);
        Debug.Log(explicitConversion);
        GenerateCharacter();
        int NextLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log(CharacterLevel);
        Debug.Log(NextLevel);
    }
    /// <summary>
    /// Time to action - adding comments
    /// Computer a modified age integer
    /// </summary>
    void ComputeAge(){
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
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
