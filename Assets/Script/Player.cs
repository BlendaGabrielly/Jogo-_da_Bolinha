using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float JumpForce;
    public Rigidbody2D rig;

    float diretion;

    void Update()
    {
        diretion=Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space)){
            rig.AddForce(Vector2.up*JumpForce,ForceMode2D.Impulse);
        }
    }
    void FixedUpdate(){
        rig.velocity=new Vector2(diretion*speed,rig.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.layer==6){
         GameController.insta.ShowGameOver();
         Destroy(gameObject);
      }
      if(collision.gameObject.layer==7){
         GameController.insta.Ganhou();
      }
    }
}
