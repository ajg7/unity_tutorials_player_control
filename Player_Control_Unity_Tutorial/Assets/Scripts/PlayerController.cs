using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [Range(0.0f, 10.0f)]
    [SerializeField] float turnSpeed = 7f;
    [SerializeField] float horizontalSpeed;
    [SerializeField] float forwardSpeed;
    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        forwardSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalSpeed);
    }
}
