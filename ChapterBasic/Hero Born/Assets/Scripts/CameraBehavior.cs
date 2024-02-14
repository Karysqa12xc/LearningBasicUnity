using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Vector3 CamOffSet = new Vector3(0f, 1.2f, -2.6f);
    private Transform _target;

    // Start is called before the first frame update
    void Start()
    {
        _target = GameObject.Find("Player").transform;
    }

    void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CamOffSet);
        this.transform.LookAt(_target);
    }
}
