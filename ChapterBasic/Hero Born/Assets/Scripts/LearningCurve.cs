using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    int[] topPlayerScores = { 713, 549, 984 };

    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = topPlayerScores.Length;
        List<string> QuestPartyMember =
        new List<string>(){
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        QuestPartyMember.Add("Craven the Necromancer");
        QuestPartyMember.Insert(1, "Tanis the Thief");
        Debug.LogFormat("Party Members: {0}",
            QuestPartyMember.Count);
        QuestPartyMember.RemoveAt(0);
        Debug.LogFormat("Party Members: {0}",
           QuestPartyMember.Count);
        ItemInventory();
    }
    public void ItemInventory()
    {
        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5},
            {"Antidote", 7},
            {"Aspirin", 1}
        };
        ItemInventory.Add("Throwing Knife", 3);
        Debug.LogFormat("Items: {0}", ItemInventory.Count);    
        int numberOfPotions = ItemInventory["Potion"];
        Debug.LogFormat("Numbers of Potions: {0}", numberOfPotions); 
        if(ItemInventory.ContainsKey("Aspirin")){
            ItemInventory["Aspirin"] = 3;
        }
        ItemInventory.Remove("AntiDote");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
