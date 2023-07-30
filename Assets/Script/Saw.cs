using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed;
    private bool dirRig=true;
    public float moveTime;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(dirRig){
         transform.Translate(Vector2.right*speed*Time.deltaTime);
       }else{
         transform.Translate(Vector2.left*speed*Time.deltaTime);
       } 
       timer+=Time.deltaTime;
       if(timer>=moveTime){
        dirRig=!dirRig;
        timer=0f;
       }
    }
 
    }

