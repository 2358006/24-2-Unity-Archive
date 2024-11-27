using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehaviour : MonoBehaviour
{
    public GameObject Bullet;
    public float bulletSpeed = 100f;
    private bool _isShooting;

    public float distanceGround = 0.1f;
    public LayerMask groundLayer;
    private CapsuleCollider _col;

    public float moveSpeed = 10f;
    public float rotateSpeed =  75f;

    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;

    public float jumpVelocity = 5f;
    private bool _isJumping;

    private GameBehaviour _gameManager;
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameBehaviour>();
    }
    void Update()
    {
        _isJumping |= Input.GetKeyDown(KeyCode.J);
        _isShooting |= Input.GetKeyDown(KeyCode.Space);
        _vInput = Input.GetAxisRaw("Vertical") * moveSpeed;
        _hInput = Input.GetAxisRaw("Horizontal") * moveSpeed;

        // this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        // this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if(IsGround() && _isJumping)
        {
            _rb.AddForce(Vector3.up *jumpVelocity, ForceMode.Impulse);
        }
        _isJumping = false;

        if (_isShooting)
        {
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0, 0, 1), this.transform.rotation);
            Rigidbody bulletRB =  newBullet.GetComponent<Rigidbody>();
            bulletRB.velocity = this.transform.forward * bulletSpeed;
        }
        _isShooting = false;

        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    private bool IsGround()
    {
        Vector3 capsuleBottom = new Vector3 (_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, distanceGround, groundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            _gameManager.HP -= 1;
        }
    }
}
