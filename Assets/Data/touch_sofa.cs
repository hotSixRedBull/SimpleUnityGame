using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_sofa : MonoBehaviour
{
    public Image targetImage;
    public Sprite toImage; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.resolution == 1) {
            statusCheck();
        }
    }
    
    public void statusCheck() {
        if(Inventory.status == 1 || Inventory.status >= 3) {
            targetImage.sprite = toImage; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
        }
    }

    public void touchSofa() {
        Debug.Log("touchSofa");
        if(Inventory.status == 2) {
            Debug.Log("333");
            Inventory.status = 3;
        } else {
            Debug.Log("111");
            Inventory.status = 1;
        }
    }
}
