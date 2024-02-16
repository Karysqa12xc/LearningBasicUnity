using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public GameBehavior GameManager;
    void Start() 
    {
        GameManager = GameObject.Find("Game_Manager")
                    .GetComponent<GameBehavior>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            Debug.Log("Item Collection");
            GameManager.Items += 1;
        }
    }
    
}
