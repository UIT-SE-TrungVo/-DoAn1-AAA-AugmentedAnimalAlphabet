using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    const float speed = 50;
    const float DISTANCE = 50;
    float oldMouseY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        if (Input.GetMouseButtonDown(0))
        {
            oldMouseY = mouse.y;
        }
        else if (Input.GetMouseButton(0))
        {
            float distance = mouse.y - oldMouseY;
            oldMouseY = mouse.y;
            //if (distance > DISTANCE) distance = DISTANCE;
            float offset = distance / DISTANCE;
            Debug.Log("Offset y" + offset);
            this.transform.Rotate(0, -offset * speed, 0);
        } 
    }
}
