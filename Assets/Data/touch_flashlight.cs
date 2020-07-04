using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_flashlight : MonoBehaviour
{
    public Image targetImage;
    public Sprite OnImage; //바뀌어질 이미지
    public Sprite OffImage; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void touchFlashLight() {
        Debug.Log("touchFlashLight");
        Debug.Log("Inventory.flashlightPower");
        Debug.Log(Inventory.flashlightPower);
        if(Inventory.flashlightPower == true) {
            Inventory.flashlightPower = false;
            targetImage.sprite = OffImage;
        } else {
            Inventory.flashlightPower = true;
            targetImage.sprite = OnImage;
        }
    }
}
