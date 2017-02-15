using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    // Use this for initialization
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //Some other code
            return experience;
        }
        set
        {
            //Some other code
            experience = value;
        }
    }
    //public int Level
    //{
    //    get
    //    {
    //        return experience * 8 - 1000;
    //    }
    //    set
    //    {
    //        experience = value;
    //    }
    //}
}
