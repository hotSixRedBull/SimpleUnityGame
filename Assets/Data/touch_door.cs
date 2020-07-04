using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class touch_door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchDoor() {
        if(Inventory.resolution == 5) {
            SceneManager.LoadScene("MainPage");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainPage"));
        }
    }
}
