using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LearningCurve : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;
    // Start is called before the first frame update
    void Start()
    {
        CamTransform = this.GetComponent<Transform>();
        // DirectionLight = GameObject.Find("Directional Light");
        // LightTransform = GameObject
        //                 .Find("Directional Light")
        //                 .GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);
        Debug.Log(CamTransform.localPosition);
        // Character hero = new Character();
        // Character hero2 = hero;
        // hero2.Name = "Vua không xương";
        // hero2.PrintStatsInfo();
        // hero.PrintStatsInfo();
        // Character heroine = new Character("Nam");
        // heroine.PrintStatsInfo();
        // Weapon bow = new Weapon("Hunting Bow", 4);
        // Weapon warBow = bow;
        // warBow.Name = "War Bow";
        // warBow.PrintWeaponStats();
        // bow.PrintWeaponStats();
        // Paladin knight = new Paladin("Sir Arthur", bow);
        // knight.PrintStatsInfo();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
