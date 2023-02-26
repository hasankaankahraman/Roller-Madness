using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    [SerializeField] private Text timeText;
    [SerializeField] private GameObject Winpanel;
    [SerializeField] private GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTheTimer();
        if(Time.time >= 2 && gameover == false)
        {
            Winpanel.gameObject.SetActive(true);
            gameover.gameObject.SetActive(false);
        }

        if (gameover == true)
        {
            Winpanel.gameObject.SetActive(false);
            gameover.gameObject.SetActive(true);
        }
    }

    private void UpdateTheTimer()
    {
        timeText.text = "Time : " + (int)Time.time;

        Enemy enemymanager = FindObjectOfType<Enemy>();
    }
}
