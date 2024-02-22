using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable<T> : MonoBehaviour where T : MonoBehaviour
{
    public int OnScreenDelay;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, OnScreenDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
