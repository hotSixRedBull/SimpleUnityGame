using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다
using UnityEngine.SceneManagement;

public class Inventory_change : MonoBehaviour
{
    public string currentScene;
    public string myName;
    public Image slot1; //기존에 존제하는 이미지
    public Image slot2; //기존에 존제하는 이미지
    public Sprite empty; //바뀌어질 이미지
    public Sprite square; //바뀌어질 이미지
    public Sprite flashlightOff; //바뀌어질 이미지
    public Sprite flashlightOn; //바뀌어질 이미지
    public Sprite ipad; //바뀌어질 이미지

    public void touch() {
        Debug.Log("touched Inventory");
        Debug.Log("Inventory.status");
        Debug.Log(Inventory.status);
        switch(Inventory.status) {
            case 1:
                if(currentScene != "safe"){
                    break;
                }
                Debug.Log("Inventory.spent");
                Debug.Log(Inventory.spent);
                Inventory.spent = Inventory.spent + 1;
                Debug.Log("Inventory.spent");
                Debug.Log(Inventory.spent);
                if(Inventory.spent >= 2) {
                    Inventory.status = 4;
                } else {
                    Inventory.status = 0;
                }
                slot1.sprite = empty;
                slot2.sprite = empty;
                break;
            case 2:
                if(currentScene != "safe"){
                    break;
                }
                Inventory.spent = Inventory.spent + 1;
                Debug.Log("Inventory.spent raised");
                Debug.Log(Inventory.spent);
                Inventory.status = 1;
                slot1.sprite = empty;
                slot2.sprite = empty;
                break;
            case 3:
                if(currentScene != "safe"){
                    break;
                }
                Inventory.spent = Inventory.spent + 1;
                Debug.Log("Inventory.spent raised");
                Debug.Log(Inventory.spent);
                Inventory.status = 1;
                slot1.sprite = square;
                slot2.sprite = empty;
                break;
            case 4:
                slot1.sprite = empty;
                slot2.sprite = empty;
                break;
            case 5:
                if(currentScene != "window"){
                    break;
                }
                Inventory.status = 4;
                slot1.sprite = empty;
                slot2.sprite = empty;
                break;
            case 6:
                slot1.sprite = ipad;
                slot2.sprite = empty;
                break;
            case 7:
                if(Inventory.flashlightPower == true) {
                    slot1.sprite = flashlightOn;
                    if(myName == "slot1") {
                        //이동
                        SceneManager.LoadScene("flashlight");
                        SceneManager.SetActiveScene(SceneManager.GetSceneByName("flashlight"));
                    } else if(Inventory.sawTheWindow == true) {
                        SceneManager.LoadScene("ipad");
                        SceneManager.SetActiveScene(SceneManager.GetSceneByName("ipad"));
                    }
                } else {
                    slot1.sprite = flashlightOff;
                    if(myName == "slot1") {
                        //이동
                        SceneManager.LoadScene("flashlight");
                        SceneManager.SetActiveScene(SceneManager.GetSceneByName("flashlight"));
                    } else {
                        SceneManager.LoadScene("ipad");
                        SceneManager.SetActiveScene(SceneManager.GetSceneByName("ipad"));
                    }
                }
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
            0: 빈 상태
            1: 소파 녹색 주음, 의자 녹색 없음
            2: 의자 녹색 주음, 소파 녹색 없음
            3: 녹색 2개 주음
            4: 빈 상태
            5: 손전등 주음, 아이패드 없음
            6: 아이패드 주음, 손전등 없음
            7: 아이패드, 손전등 주음
        */
        switch(Inventory.status) {
            case 1:
                slot1.sprite = square;
                slot2.sprite = empty;
                break;
            case 2:
                slot1.sprite = square;
                slot2.sprite = empty;
                break;
            case 3:
                slot1.sprite = square;
                slot2.sprite = square;
                break;
            case 4:
                slot1.sprite = empty;
                slot2.sprite = empty;
                break;
            case 5:
                slot1.sprite = flashlightOff;
                slot2.sprite = empty;
                break;
            case 6:
                slot1.sprite = ipad;
                slot2.sprite = empty;
                break;
            case 7:
                if(Inventory.flashlightPower == true) {
                    slot1.sprite = flashlightOn;
                } else {
                    slot1.sprite = flashlightOff;
                }
                slot2.sprite = ipad;
                break;
        }
    }
}
