using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour, IManger
{
    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public void Initialize()
    {
        _state = "Data Manager initialize";
        Debug.Log(_state);
    }

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }
}
