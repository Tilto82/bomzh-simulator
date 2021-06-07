using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnjoyManager : MonoBehaviour
{
    public GameObject otherGameObject;
    private ManagerNeeds managerNeeds;

    public void DrinkVodka()
    {
        if (managerNeeds.money >= 1000)
        {
            managerNeeds.money -= 1000;
            managerNeeds.enjoy += 5;
            managerNeeds.health -= 10;
        }
    }
    public void GotoCinema()
    {
        if (managerNeeds.money >= 2500)
        {
            managerNeeds.money -= 2500;
            managerNeeds.enjoy += 15;
        }
    }

    public void GotoAtractions()
    {
        if (managerNeeds.money >= 4500)
        {
            managerNeeds.money -= 4500;
            managerNeeds.enjoy += 30;
        }
    }

    public void GotoGamingClub()
    {
        if (managerNeeds.money >= 8500)
        {
            managerNeeds.money -= 8500;
            managerNeeds.enjoy += 60;
        }
    }
    void Update()
    {
        managerNeeds = GetComponent<ManagerNeeds>();
        managerNeeds = otherGameObject.GetComponent<ManagerNeeds>();

    }
}
