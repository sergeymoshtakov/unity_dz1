using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    //public void Start()
    //{
    //    print($"Player speed = {_speed}");
    //}

    public void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    print($"Player speed = {_speed}");
        //}

        var verticalInput = Input.GetAxis("Vertical");
        var movementVector = new Vector3(0f, 0f, verticalInput * _speed * Time.deltaTime);

        transform.Translate(movementVector);
    }
}
