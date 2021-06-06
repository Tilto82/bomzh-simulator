using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealManager : MonoBehaviour
{
    public GameObject otherGameObject;

    private ManagerNeeds managerNeeds;

    public void BuyHerbals()
    {
        if (managerNeeds.money >= 100)
        {
            managerNeeds.money -= 100;
            managerNeeds.health += 10;
        }
    }

    public void BuyAnalgin()
    {
        if (managerNeeds.money >= 250)
        {
            managerNeeds.money -= 250;
            managerNeeds.health += 25;
        }
    }

    public void GoInHospital()
    {
        if (managerNeeds.money >= 500)
        {
            managerNeeds.money -= 500;
            managerNeeds.health += 50;
        }
    }

    public void GoInEliteHospital()
    {
        if (managerNeeds.money >= 1000)
        {
            managerNeeds.money -= 1000;
            managerNeeds.health += 100;
        }
    }

    void Update()
    {
        managerNeeds = GetComponent<ManagerNeeds>();
        managerNeeds = otherGameObject.GetComponent<ManagerNeeds>();
        
    }
}
