using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("speed rotation and direction('-' for left and '+' for right)")]
     float Speed;
     float rotSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Speed = 30;
        rotSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotSpeed = rotSpeed + Time.deltaTime*Speed;
        transform.rotation =  Quaternion.Euler(0, 0, rotSpeed) ;
    }
}
