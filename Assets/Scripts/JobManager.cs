using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JobManager : MonoBehaviour
{
    public int pay = 10;

    public Text currentJobText;
    public string currentJob;

    public GameObject otherGameObject;

    private ManagerNeeds managerNeeds;

    public void BeBeggar()
    {   if (managerNeeds.money >= 1)
        {
            managerNeeds.money -= 1;
            pay = 10;
            currentJob = "Попрошайка";
        }
        
    }

    public void BeWaiter()
    {
        if (managerNeeds.money >= 1000)
        {
            managerNeeds.money -= 1000;
            pay = 50;
            currentJob = "Официант";
        }
    }

    public void Start()
    {
        BeBeggar();
    }

    public void BeManager()
    {
        if (managerNeeds.money >= 10000)
        {
            managerNeeds.money -= 10000;
            pay = 100;
            currentJob = "Менеджер";
        }
    }

    public void BeProgrammer()
    {
        if (managerNeeds.money >= 30000)
        {
            managerNeeds.money -= 30000;
            pay = 500;
            currentJob = "Программист";
        }
    }

    public void BePornActor()
    {
        if (managerNeeds.money >= 100000)
        {
            managerNeeds.money -= 100000;
            pay = 2000;
            currentJob = "Порноактер";
        }
    }

    //создать пассивные виды доходов
    //создать мендежер дома
    //менять фон при изменении дома


    void Update()
    {
        managerNeeds = GetComponent<ManagerNeeds>();
        managerNeeds = otherGameObject.GetComponent<ManagerNeeds>();

        currentJobText.text = ($"Работа - {currentJob}");
    }
}
