using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daynightcycle : MonoBehaviour
{
    public Text Day;
    public Text Month;

    float timeincyclemins;// time of one whole cycle // mins
    public float springcycletime;
    public float summercycletime;
    public float wintercycletime;
    [Range(0, 1)]
    float timeofday = 0f;
    public GameObject Sun;
   public float currentHour;
    float currentMinute;
    [Range(1, 25)]
   public int day;
    [Range(1, 5)]
    public int month;
    string monthname;
    public  Light sunlight;
    float sunintencaty;
   //public Material lightcolour;
    //public Light light;
    // Use this for initialization
    void Start()
    {
        sunintencaty = sunlight.intensity;
        timeofday = 0.2f;
        
        //day = 1;
        //month = 1;
    }

    // Update is called once per frame
    void Update()
    {

        monthcheck();
        SunUpdate();

        currentHour = 24 * timeofday;
        currentMinute = 60 * (currentHour - Mathf.Floor(currentHour));


        Day.text = day.ToString();
        Month.text = monthname;

        timeofday += (Time.deltaTime / timeincyclemins);

    }

    void SunUpdate()
    {
        Sun.transform.localRotation = Quaternion.Euler((timeofday * 360f) - 90, 205, 0);// rotates around x axis and other 3 numbers are to do with sunrise and sunset.


        //___________________________________________________________________________________________

        Debug.Log("time of day");
        Debug.Log(currentHour+":"+currentMinute);


        if (currentHour >= 7.5f && currentHour <= 20.5)
        {
            //day time shops open
        }
        else
        {

        }

        // sun intencaty

        float intensityMultiplier = 1;
        if (timeofday <= 0.23f || timeofday >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        else if (timeofday <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((timeofday - 0.23f) * (1 / 0.02f));
        }
        else if (timeofday >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((timeofday - 0.73f) * (1 / 0.02f)));
        }

        sunlight.intensity = sunintencaty * intensityMultiplier;

    }

    void monthcheck()
    {

        if (timeofday >= 1)
        {
            timeofday = 0;
            day++;
            if (day == 5|| day == 6 || day == 7)
            {
                //red sun
            }
            else
            {
                
            }
        }
        if (day >= 26)
        {
            day = 1;
            month++;
            if (month > 5)
            {
                month = 1;
            }
        }

        if (month == 1)
        {
            monthname = "Mearst";
            timeincyclemins = springcycletime * 60;
        }
        if (month == 2)
        {
            monthname = "Crest";
            timeincyclemins = springcycletime * 60;
        }
        if (month == 3)
        {
            monthname = "Incun";
            timeincyclemins = summercycletime * 60;
            if (day == 5)
            {
               
            }
        }
        if (month == 4)
        {
            monthname = "Cemer";
            if (day <= 18)
            {
                timeincyclemins = summercycletime * 60;
            }
            else
            {
                timeincyclemins = wintercycletime * 60;
            }
            
        }
        if (month == 5)
        {
            monthname = "Noctu";
            timeincyclemins = wintercycletime * 60;
        }
    }

}
