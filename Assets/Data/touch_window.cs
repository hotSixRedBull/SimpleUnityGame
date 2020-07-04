using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_window : MonoBehaviour
{
    public Image targetImage;
    public Sprite toOpen; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchWindow() {
        Debug.Log("touchWindow");
        if(Inventory.flashlightPower == true) {
            targetImage.sprite = toOpen;
            Inventory.sawTheWindow = true;
            //해상도 올려
            if(Inventory.resolution <= 3) {
                Inventory.resolution = 3;
            }
        }
    }
}
