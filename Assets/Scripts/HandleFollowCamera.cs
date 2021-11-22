using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleFollowCamera : MonoBehaviour
{
    [SerializeField] GameObject driver = null;
    [SerializeField] Vector3 zOffset = new Vector3(0,0,10f);
    // Update is called once per frame
    void LateUpdate()
    {
        if(driver != null){
            transform.position = driver.transform.position + zOffset;
        }
    }
}
