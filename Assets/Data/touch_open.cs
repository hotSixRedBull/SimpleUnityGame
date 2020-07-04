using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_open : MonoBehaviour
{
    public Image targetImage;
    public Sprite appImageFour; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchOpen() {
        Debug.Log("touchOpen");
        Debug.Log("Inventory.ipadStep");
        Debug.Log(Inventory.ipadStep);
        Debug.Log("Inventory.resolution");
        Debug.Log(Inventory.resolution);
        if(Inventory.ipadStep == 4 && Inventory.resolution == 3) {
            targetImage.sprite = appImageFour;
            if(Inventory.resolution <= 4) {
                Inventory.resolution = 4;
            }
        }
    }
}
