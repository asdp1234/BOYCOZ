using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorSkills : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    string skillname = "NONE";
    [Range(1, 10),SerializeField]
    int skilllevel;
    

    void Levelup()
    {
        skilllevel++;
    }
}
