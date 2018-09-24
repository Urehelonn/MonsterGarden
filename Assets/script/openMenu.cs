using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openMenu : MonoBehaviour {

    public GameObject switchScene;

    void OnMouseDown()
    {
        // this object was clicked - do something       
        Debug.Log("touched georage");
        SceneManager.LoadScene("MenuPageScene");
    }
}
