using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public GameObject countdown;
    public float tenSecTimer = 0f;
    public GameObject pickup;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            countdown.GetComponent<CountDownTimer>().Checkpoint();
            

        }
    }

}
