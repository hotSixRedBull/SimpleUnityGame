using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_safe : MonoBehaviour
{
    public Image targetImage;
    public Sprite toOpen; //바뀌어질 이미지
    public Sprite getFlashlight; //바뀌어질 이미지
    public Sprite toEmpty; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        statusCheck();
    }

    public void statusCheck() {
        if(Inventory.status == 4) {
            targetImage.sprite = toOpen; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
        } else if(Inventory.status == 5) {
            targetImage.sprite = getFlashlight; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
        } else if(Inventory.status == 7) {
            targetImage.sprite = toEmpty;
            if(Inventory.resolution <= 2) {
                Inventory.resolution = 2;
            }
        }
    }

    public void touchSafe() {
        Debug.Log("touchSafe");
        Debug.Log("Inventory.status");
        Debug.Log(Inventory.status);
        if(Inventory.status == 4) {
            Inventory.status = 5;
        } else if(Inventory.status == 5) {
            Inventory.status = 7;
        }
    }
}
