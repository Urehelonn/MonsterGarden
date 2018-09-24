using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trade : MonoBehaviour {

    public GameObject storage;
    public Items item1;
    public Items item2;
    public int price;
    public int type;

    public void tradeForGood()
    {
        switch (type)
        {
            //add item and remove moeny
            case 0:
                storage.GetComponent<storageScript>().bank -= price;
                storage.GetComponent<storageScript>().items.Add(item1);
                break;

            //add money remove item
            case 1:
                storage.GetComponent<storageScript>().bank += price;
                storage.GetComponent<storageScript>().items.Remove(item1);
                break;

            //add item remove item
            case 2:
                storage.GetComponent<storageScript>().items.Add(item1);
                storage.GetComponent<storageScript>().items.Remove(item2);
                break;
        }
    }

}
