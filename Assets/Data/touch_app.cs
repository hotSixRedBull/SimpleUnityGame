using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class touch_app : MonoBehaviour
{
    public Image targetImage;
    public Sprite toOpenAppThree;
    public Sprite toOpenAppFour;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.resolution == 5 && Inventory.blinkCountFive < 5) {
            if(time < 0.5f) {
                targetImage.color = new Color(1, 1, 1, 1 - time);
            } else {
                targetImage.color = new Color(1, 1, 1, time);
                if(time > 1f) {
                    time = 0;
                    Inventory.blinkCountFive = Inventory.blinkCountFive + 1;
                }
            }

            time += Time.deltaTime;
        }
    }

    public void touchApp() {
        Debug.Log("touchApp");
        Debug.Log("Inventory.ipadStep");
        Debug.Log(Inventory.ipadStep);
        Debug.Log("Inventory.resolution");
        Debug.Log(Inventory.resolution);
        if(Inventory.ipadStep == 4 && Inventory.resolution == 3) {
            targetImage.sprite = toOpenAppThree;
        } else if(Inventory.ipadStep == 4 && Inventory.resolution == 4) {
            targetImage.sprite = toOpenAppFour;
            if(Inventory.resolution <= 5) {
                Inventory.resolution = 5;
            }
        }
    }
}
