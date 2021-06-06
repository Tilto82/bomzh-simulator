using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyScript1 : MonoBehaviour
// добавить точное время
// ограничение колличества мастурбации
{
    public int lvlhappy;
    private ManagerNeeds manager;
    public GameObject othergameobject;
    public bool haveTV;
    public bool havehouse;
    public void Walk()
    {
        manager.food -= 10;
        lvlhappy += 15;
     
    }
    public void watchTV()
    {
        if (haveTV == true && havehouse == true)
        {
            lvlhappy += 25;
        } 
    }
    public void masturbation()
    {
        if (havehouse == true)
        {
            lvlhappy += 30;
        }
    }


    void Update()
    {
        manager = GetComponent<ManagerNeeds>();
        manager = othergameobject.GetComponent<ManagerNeeds>();
        
    }
}
