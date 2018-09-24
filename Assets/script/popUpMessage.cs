using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUpMessage : MonoBehaviour {

    public Text tx;
    public string msg;
    public float delay;

    private void Start()
    {
        tx.enabled = false;
    }
    public void showMessage()
    {
        StartCoroutine(ShowMessage());
    }

    IEnumerator ShowMessage()
    {
        tx.text = msg;
        tx.enabled = true;
        yield return new WaitForSeconds(delay);
        tx.enabled = false;
    }
}
