using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorSkills : MonoBehaviour
{
    // Start is called before the first frame update
    string skillname = "NONE";
    [Range(1, 10)]
    int skilllevel;
    

    void Levelup()
    {
        skilllevel++;
    }
}
