using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private WheelCollider[] wheels;
    [SerializeField] private Transform[] wheelsTransform;

    //[SerializeField] private List<WheelCollider> wheelCollidersList = new List<WheelCollider>(); if i wanted to make a list


    [SerializeField] private float motorPower = 20f;
    [SerializeField] private float steerPower = 25;

    [SerializeField] private GameObject centerMass;
    [SerializeField] private Rigidbody body;


    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.centerOfMass = centerMass.transform.localPosition;
    }

    private void FixedUpdate()
    {
        foreach (var wheel in wheels)
        {
            wheel.motorTorque = Input.GetAxis("Vertical") * motorPower * 500 * Time.deltaTime;
        }

        for(int i = 0; i < wheels.Length; i++)
        {
            if(i < 2)
            {
                wheels[i].steerAngle = Input.GetAxis("Horizontal") * steerPower;
            }

            UpdateWheel(wheels[i], wheelsTransform[i]);
        }

          
    }



    void UpdateWheel(WheelCollider col, Transform trans)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;
    }
}
