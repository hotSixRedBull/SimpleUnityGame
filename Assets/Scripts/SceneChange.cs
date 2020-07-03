using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneTarget;
    private void Update() {
        if(Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(sceneTarget);
        }
    }
}
