using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    public float JumpVelocity = 5f;
    private bool _isJump;
    public float DistanceToGround = 0.5f;
    public LayerMask GroundMask;
    private CapsuleCollider _col;
    public GameObject Bullet;
    public float BulletSpeed = 100;
    private bool _isShooting;
    private float _vInput;
    private float _hInput;
    private Rigidbody _rb;
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
        _col = this.GetComponent<CapsuleCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        _isJump |= Input.GetKeyDown(KeyCode.Space);
        _isShooting |= Input.GetMouseButtonDown(0);
        // this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);

        // this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
    }
    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
        if (IsGrounded() && _isJump)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);

        }
        _isJump = false;
        if (_isShooting)
        {
            GameObject newBullet = Instantiate(
            Bullet
            , this.transform.position + new Vector3(1, 0 , 0)
            , this.transform.rotation);
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity = this.transform.forward * BulletSpeed;
        }
        _isShooting = false;
    }
    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(
        _col.bounds.center.x
        , _col.bounds.min.y
        , _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(
        _col.bounds.center
        , capsuleBottom
        , DistanceToGround
        , GroundMask
        , QueryTriggerInteraction.Ignore);
        return grounded;
    }

}
