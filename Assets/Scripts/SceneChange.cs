using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string myScene;
    public string sceneTarget;
    private void Update() {

    }
    public void move() {
        SceneManager.LoadScene(sceneTarget);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneTarget));
        //SceneManager.UnloadSceneAsync(myScene);
    }
}
