using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storageScript : MonoBehaviour {

    public int bank;
    public List<Items> items;
    
    private void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public int getBank()
    {
        return bank;
    }
}
