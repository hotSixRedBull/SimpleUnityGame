using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_number : MonoBehaviour
{
    public int value;
    public Image targetImage;
    public Sprite stepZero; //바뀌어질 이미지
    public Sprite stepOne; //바뀌어질 이미지
    public Sprite stepTwo; //바뀌어질 이미지
    public Sprite stepThree; //바뀌어질 이미지
    public Sprite stepFour; //바뀌어질 이미지
    public Sprite stepApp; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchNumber() {
        Debug.Log("touchNumber");
        if(Inventory.sawTheWindow == true) {
            if(Inventory.ipadStep == 0 && value == 2) {
                Inventory.ipadStep = 1;
                targetImage.sprite = stepOne;
            } else if(Inventory.ipadStep == 1 && value == 0) {
                Inventory.ipadStep = 2;
                targetImage.sprite = stepTwo;
            } else if(Inventory.ipadStep == 2 && value == 2) {
                Inventory.ipadStep = 3;
                targetImage.sprite = stepThree;
            } else if(Inventory.ipadStep == 3 && value == 0) {
                Inventory.ipadStep = 4;
                Inventory.resolution = 4;
                targetImage.sprite = stepApp;
            }
        }
    }
}
