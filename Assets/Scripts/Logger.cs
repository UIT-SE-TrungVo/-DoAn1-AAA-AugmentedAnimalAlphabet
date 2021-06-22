using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            Debug.Log("LOG!" + Time.deltaTime);
        }  
    }

    public void Active()
    {
        active = true;
    }

    public void Deactive()
    {
        active = false;
    }
}
