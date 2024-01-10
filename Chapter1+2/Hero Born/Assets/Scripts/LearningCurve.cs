using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }
    /// <summary>
    /// Time to action - adding comments
    /// Computer a modified age integer
    /// </summary>
    void ComputeAge(){
        Debug.Log(CurrentAge + AddAge);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
