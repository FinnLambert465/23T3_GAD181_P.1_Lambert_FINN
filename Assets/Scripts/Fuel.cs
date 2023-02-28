using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fuel : MonoBehaviour
{

    [SerializeField] private GameObject fuel;

    public delegate void pickUpFuel();
    public static event pickUpFuel onPickUpFuel;


    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (onPickUpFuel != null)
            {
                onPickUpFuel();
                fuel.SetActive(false);
            }
            
        }
    }
}
