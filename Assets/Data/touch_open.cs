using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_open : MonoBehaviour
{
    public Image targetImage;
    public Sprite openImageFour; //바뀌어질 이미지
    public Sprite appImageFour; //바뀌어질 이미지
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.resolution == 4 && Inventory.blinkCountFour < 5) {
            if(time < 0.5f) {
                targetImage.color = new Color(1, 1, 1, 1 - time);
            } else {
                targetImage.color = new Color(1, 1, 1, time);
                if(time > 1f) {
                    time = 0;
                    Inventory.blinkCountFour = Inventory.blinkCountFour + 1;
                }
            }

            time += Time.deltaTime;
        }
    }

    public void touchOpen() {
        Debug.Log("touchOpen");
        Debug.Log("Inventory.ipadStep");
        Debug.Log(Inventory.ipadStep);
        Debug.Log("Inventory.resolution");
        Debug.Log(Inventory.resolution);
        if(Inventory.ipadStep == 4 && Inventory.resolution == 3) {
            targetImage.sprite = openImageFour;
            if(Inventory.resolution <= 4) {
                Inventory.resolution = 4;
            }
        } else if(Inventory.ipadStep == 4 && Inventory.resolution == 4) {
            targetImage.sprite = appImageFour;
            if(Inventory.resolution <= 5) {
                Inventory.resolution = 5;
            }
        }
    }
}
