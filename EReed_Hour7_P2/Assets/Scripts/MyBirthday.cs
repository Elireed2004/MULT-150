using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int month = 2;           // February
        int birthdayDay = 13;    // your birthday: Feb 13th

        int year = DateTime.Now.Year;
        int daysInMonth = DateTime.DaysInMonth(year, month);

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
