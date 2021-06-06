using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerNeeds : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject otherGameObject;

    private JobManager jobManager;

    public Text enjoyText;
    public int enjoy = 100;

    public Text healthText;
    public int health = 90;

    public Text foodText;
    public int food = 70;

    public Text moneyText;
    public int money = 1000;

    public Text dayCountText;
    private int dayCount;

    public Text TextName;
    private InputField InputName;
    public string Name;
    private GameObject PanelName;

   

    public void SetName()
    {
        PanelName.SetActive(false);
        TextName.text += " " + InputName.text;
    }

    public void Restart()
    {
        health = 90;
        food = 70;
        money = 1000;
        dayCount = 0;
        jobManager.pay = 10;
        jobManager.currentJob = "";
    }

    public void Turn()
    {
        food -= 1;
        money += jobManager.pay;
        dayCount++;

    }



    public void MinusHealth()
    {
        if (food <= 0)
        {
            health -= 5;
        }
    }

    public void HealthCheck()
    {
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameOver, 3f);
            Restart();
        }
    }


    void Update()
    {
        if (health > 100)
        {
            health = 100;
        }

        if (health < 0)
        {
            health = 0;
        }

        if (food > 100)
        {
            food = 100;
        }

        if (food < 0)
        {
            food = 0;
        }

        if (enjoy > 100)
        {
            enjoy = 100;
        }

        if (enjoy < 0)
        {
            enjoy = 0;
        }
        jobManager = GetComponent<JobManager>();
        jobManager = otherGameObject.GetComponent<JobManager>();

        healthText.text = ((int)health).ToString();
        foodText.text = ((int)food).ToString();
        moneyText.text = ((int)money).ToString();
        dayCountText.text = ((int)dayCount).ToString();
        enjoyText.text = ((int)enjoy).ToString();
    }
}
