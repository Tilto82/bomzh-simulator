using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
    public GameObject otherGameObject;

    private ManagerNeeds managerNeeds;

    public void BuyDoshik()
    {
        if (managerNeeds.money >= 80)
        {
            managerNeeds.money -= 80;
            managerNeeds.food += 5;
        }
    }

    public void EatPelmeni()
    {
        if (managerNeeds.money >= 230)
        {
            managerNeeds.money -= 230;
            managerNeeds.food += 15;
        }
    }

    public void EatInMcdonalda()
    {
        if (managerNeeds.money >= 450)
        {
            managerNeeds.money -= 450;
            managerNeeds.food += 30;
            managerNeeds.enjoy += 5;

        }
    }

    public void EatInRestaraunt()
    {
        if (managerNeeds.money >= 2000)
        {
            managerNeeds.money -= 2000;
            managerNeeds.enjoy += 10;
            managerNeeds.food += 50;
        }
    }

    public void EatInGlobalEliteRestaraunt()
    {
        if (managerNeeds.money >= 10000)
        {
            managerNeeds.money -= 10000;
            managerNeeds.food += 100;
            managerNeeds.enjoy += 30;
        }
    }

    void Update()
    {
        managerNeeds = GetComponent<ManagerNeeds>();
        managerNeeds = otherGameObject.GetComponent<ManagerNeeds>();
    }
}
