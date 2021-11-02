using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ball : MonoBehaviour
{
    [FormerlySerializedAs("direction")]
    [SerializeField] 
    [Tooltip("direction and range of oscillate object")]
    
    Vector3 scale;
    float time;
    
    [SerializeField]
    [Tooltip("beating speed")]
    float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        time = 0;
        scale = new Vector3((float) 0.2, (float) 0.2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.localScale = scale*oscillate(time, speed);
    }
    
    float oscillate(float time, float speed)
    {
        return Mathf.Pow(Mathf.Cos(time * speed/ Mathf.PI)*(float)0.6,2)+1;
    }
}
