using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerspeed= 80.0f;
    [SerializeField]float movespeed= 5.0f;
    [SerializeField]float slowspeed= 2.0f;
    [SerializeField]float boostspeed= 15.0f;

    

    void Start()
    {
        
    }


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerspeed*Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")*movespeed*Time.deltaTime;


        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }

    

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Boost")
        {
            movespeed=boostspeed;
        }

        else if(other.tag=="Bump")
        {
            movespeed=slowspeed;
        }
    }

    

}
