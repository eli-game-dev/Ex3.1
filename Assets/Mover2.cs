using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("direction and range of oscillate object")]
    Vector3 direction;
    
    [SerializeField]
    [Tooltip("location of object")]
    Vector3 location;
    float time;
    
    [SerializeField]
    [Tooltip("oscillate speed")]
    float speed; 
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        time = 0;
        direction = new Vector3(0, 2, 0);
        location = new Vector3(4, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.position = location+direction*oscillate(time, speed);
    }
    
    // help in https://forum.unity.com/threads/simple-oscillation-of-a-variable.503906/
    float oscillate(float time, float speed)
    {
        return Mathf.Cos(time * speed/ Mathf.PI);
    }

}
