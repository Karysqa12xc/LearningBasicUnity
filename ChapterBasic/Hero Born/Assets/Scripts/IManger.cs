using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IManger
{
    string State { get; set; }
    void Initialize();
}
