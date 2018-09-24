using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {
    public string newScene;

    public void onClick()
    {
        Debug.Log("button");
        SceneManager.LoadScene(newScene);
    }
}
