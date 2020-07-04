using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다

public class updateResolution : MonoBehaviour
{
    public Image targetImage;
    public Sprite resTwo; //바뀌어질 이미지
    public Sprite resThree; //바뀌어질 이미지
    public Sprite resFour; //바뀌어질 이미지
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.resolution == 2) {
            targetImage.sprite = resTwo;
        } else if(Inventory.resolution == 3) {
            targetImage.sprite = resThree;
        } else if(Inventory.resolution >= 4) {
            targetImage.sprite = resFour;
        }
    }
}
