using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_sofa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void touchSofa() {
        if(Inventory.status == 2) {
            Inventory.status = 3;
        } else {
            Inventory.status = 1;
        }
    }
}
