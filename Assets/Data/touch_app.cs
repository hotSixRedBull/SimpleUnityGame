using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_app : MonoBehaviour
{
    public Image targetImage;
    public Sprite toImage; //바뀌어질 이미지
    public Sprite toOpenApp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchApp() {
        if(Inventory.ipadStep == 4 && Inventory.resolution == 3) {
            targetImage.sprite = toImage;
            Inventory.resolution = 4;
        } else if(Inventory.ipadStep == 4 && Inventory.resolution == 4) {
            targetImage.sprite = toOpenApp;
        }
    }
}
