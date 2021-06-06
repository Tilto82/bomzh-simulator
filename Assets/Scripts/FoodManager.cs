using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject otherGameObject;

    private ManagerNeeds managerNeeds;

    public void BuyMushrooms()
    {
        if (managerNeeds.money >= 100)
        {
            managerNeeds.money -= 100;
            managerNeeds.food += 10;
        }
    }

    public void EatPelmeni()
    {
        if (managerNeeds.money >= 250)
        {
            managerNeeds.money -= 250;
            managerNeeds.food += 25;
        }
    }

    public void EatInRestaraunt()
    {
        if (managerNeeds.money >= 500)
        {
            managerNeeds.money -= 500;
            managerNeeds.food += 50;
        }
    }

    public void EatInGlobalEliteRestaraunt()
    {
        if (managerNeeds.money >= 1000)
        {
            managerNeeds.money -= 1000;
            managerNeeds.food += 100;
        }
    }

    void Update()
    {
        managerNeeds = GetComponent<ManagerNeeds>();
        managerNeeds = otherGameObject.GetComponent<ManagerNeeds>();
    }
}
