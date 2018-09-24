using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {

    public int moneyNum;
    public GameObject storage;
    public Text lable;
    
    void Update()
    {
        moneyNum = storage.GetComponent<storageScript>().getBank();
        lable.text = "$" +moneyNum;
    }
}
