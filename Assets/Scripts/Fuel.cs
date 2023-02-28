using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fuel : MonoBehaviour
{

    public UnityEvent pickUpFuel;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpFuel.Invoke();
        }
    }
}
