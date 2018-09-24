using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Seed{
    public bool isThere = false;
    public int maxLv = 0;
    public List<int> involveRoute;
    public int pic = 0;
    public GameObject spot;

    public Seed(){}
    public Seed(int maxLv, List<int> invlveRoute, int pic)
    {
        this.maxLv = maxLv;
        foreach(int i in involveRoute)
        {
            this.involveRoute.Add(i);
        }
        this.pic = pic;
    }
}
