using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.GetComponent<Renderer>().enabled) // if on then off
            {
                gameObject.GetComponent<Renderer>().enabled = false;
            }
            else//if off then on
            {
                gameObject.GetComponent<Renderer>().enabled = true;
            }
        } 
    }
}
