using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CountDownTimer : MonoBehaviour
{
    [SerializeField] float currentTime = 0f;
    [SerializeField] float startingTime = 10f;
    [SerializeField] float startingTrafficTime = 5f;
    [SerializeField] float trafficTime = 0f;
    public GameObject noLight;
    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;
    public GameObject cage;
    [SerializeField] private Image fuelBar;
    [SerializeField] private Slider fuelSlider;
    [SerializeField] private Color fuelColor;


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
            SetFuelBar();
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
            SceneManager.LoadScene(4);
        }
    }
  
    void OnEnable()
    {
        Fuel.onPickUpFuel += AddTime;
    }
    void OnDisable()
    {
        Fuel.onPickUpFuel -= AddTime;
    }

    public void AddTime()
    {
        currentTime += 1.75f ;
    }

    private void SetFuelBar()
    {
        fuelSlider.value = currentTime;
        if (currentTime <= 6.66f)
        {
            fuelBar.color = fuelColor;
        }
        if (currentTime <= 3.33f)
        {
            fuelBar.color = Color.red;
        }
    }
}
