using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_Inven_for_safe : MonoBehaviour
{
    public Image targetImage;
    public Sprite toImage1; //바뀌어질 이미지
    public Sprite toImage2; //바뀌어질 이미지
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
        if(Inventory.spent == 1) {
            targetImage.sprite = toImage1; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
        } else if(Inventory.spent >= 2) {
            targetImage.sprite = toImage2;
            //해상도올려
        }
    }

}
