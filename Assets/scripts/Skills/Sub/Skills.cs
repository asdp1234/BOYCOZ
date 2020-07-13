using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    string skillname = "NONE";
    [Range(1,100)]
    int skilllevel;
    float currentxp, neededxp;


    void Levelup()
    {

        while(currentxp >= neededxp)
        {
            skilllevel++;
            currentxp -= neededxp;
            neededxp *= 1.2f;
        }  
        


    }


}
