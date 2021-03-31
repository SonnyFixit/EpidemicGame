using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public DealDamage dealDamageScript;
    public Animator animator;
    public float speed = 80f;


    float horizontalMove = 0f;
    bool isJummp = false;

    //private void OnEnable()
    //{
    //    SceneManager.sceneLoaded += FindStartingPosition;
    //}

    //private void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= FindStartingPosition;
    //}


    void Update()
    {


        this.horizontalMove = Input.GetAxisRaw("Horizontal") * this.speed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {

            this.isJummp = true;
            animator.SetBool("IsJumping", true);
        }


    }

    public void onLanding()
    {

        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(this.horizontalMove * Time.fixedDeltaTime, this.isJummp);
        this.isJummp = false;

    }

    public void StopPlayer()
    {
        speed = 0f;
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "EnemyArea")
    //    {
    //        Debug.Log("enemy area");
    //        enemyScript.OnEnemyStartMove();
    //    }
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "EnemyArea")
    //    {
    //        enemyScript.OnenemyEndMove();
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "SawBlade2")
        {
            Debug.Log("Entered blade");

            if (dealDamageScript)
            {
                dealDamageScript.SendDamage(1);
            }
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Laser")
        {

            
            {
                Debug.Log("Entered laser");

                if (dealDamageScript)
                {
                    dealDamageScript.SendDamage(1);
                }
            }
        }





        //private void FindStartingPosition(Scene scene, LoadSceneMode sceneMode)
        //{
        //    transform.position = GameObject.FindGameObjectWithTag("StartPos").transform.position;
        //}
    }
}

