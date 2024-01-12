using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class LearningCurve : MonoBehaviour
{
    int[] topPlayerScores = { 713, 549, 984 };
    int PlayerLives = 3;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        // FindPartyMember();
        // ItemInventory();
        HealthStatus();
    }
    public void ItemInventory()
    {
        int currentGold = 0;
        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5},
            {"Antidote", 7},
            {"Aspirin", 1}
        };
        foreach(KeyValuePair<string, int> kvp in ItemInventory){
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
            currentGold += kvp.Value;
        }
        Debug.LogFormat("Current Gold: {0}", currentGold);
        ItemInventory.Add("Throwing Knife", 3);
        Debug.LogFormat("Items: {0}", ItemInventory.Count);    
        int numberOfPotions = ItemInventory["Potion"];
        Debug.LogFormat("Numbers of Potions: {0}", numberOfPotions); 
        if(ItemInventory.ContainsKey("Aspirin")){
            ItemInventory["Aspirin"] = 3;
        }
        ItemInventory.Remove("AntiDote");
    }
    public void FindPartyMember( )
    {
        List<string> QuestPartyMember =
        new List<string>(){
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        for (int i = 0; i < QuestPartyMember.Count; i++)
        {
            Debug.LogFormat($"Index {i} - {QuestPartyMember[i]}");
            if(QuestPartyMember[i] == "Merlin the Wise"){
                Debug.Log("Glad you're here Merlin");
            }
        }
        foreach(string partyMember in QuestPartyMember){
            Debug.LogFormat("{0} - Here", partyMember);
        }

    }
    public void HealthStatus( )
    {
        while(PlayerLives > 0){
            Debug.Log("Still alive");
            PlayerLives--;
        }
        Debug.Log("Player KO'd....");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
