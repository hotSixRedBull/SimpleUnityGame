using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_chair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void touchChair() {
        if(Inventory.status == 1) {
            Inventory.status = 3;
        } else {
            Inventory.status = 2;
        }
    }
}
