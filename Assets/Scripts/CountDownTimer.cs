using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CountDownTimer : MonoBehaviour
{
    public static float currentTime = 0f;
    public float startingTime = 10f;
    public float startingTrafficTime = 8f;
    public float trafficTime = 0f;

    public GameObject noLight;
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    public GameObject cage;

    
    

    [SerializeField] TMP_Text countDownUI;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        trafficTime = startingTrafficTime;
        

    }

    // Update is called once per frame
    void Update()
    {
        trafficTime -= 1 * Time.deltaTime;
        

        if (trafficTime <= 5)
        {
            noLight.SetActive(false);
        }
        if (trafficTime <= 3)
        {
            redLight.SetActive(false);
        }
        if (trafficTime <= 1)
        {
            yellowLight.SetActive(false);
            CountingDown();
            Time.timeScale = 1;
            cage.SetActive(false);
        }
        if (trafficTime <= 0)
        {
            greenLight.SetActive(false);
            
        }
        
    }

    public void CountingDown()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownUI.text = currentTime.ToString("0.00");

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(3);
        }
    }

    public void Checkpoint()
    {
        currentTime += 10;
        
        
        

    }
}
