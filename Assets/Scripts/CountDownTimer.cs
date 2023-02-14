using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CountDownTimer : MonoBehaviour
{
    [SerializeField] float currentTime = 0f;
    [SerializeField] float startingTime = 10f;
    [SerializeField] TMP_Text countDownUI;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownUI.text = currentTime.ToString("0.00");

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene(2);
        }
    }
}
