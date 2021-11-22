using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleDriverCollision : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D other) {
        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionExit2D(Collision2D other) {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
