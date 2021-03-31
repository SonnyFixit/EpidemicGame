using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeponScript : MonoBehaviour
{
    public Transform firePoint;
    //public GameObject impactEffect;
    public LineRenderer lineRenderer;
    public GameObject bulletPrefab;
    public Animator animator;
   // public bool IsShooting = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
           // IsShooting = true;
            
            Shoot();
            //IsShooting = false;
           
        }

        if(Input.GetKeyUp(KeyCode.X))
        {
            animator.SetBool("IsShooting", false);
        }
    }

    void Shoot()
    {
        animator.SetBool("IsShooting", true);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //animator.SetBool("IsShooting", false);
        //RaycastHit2D hitInfo =  Physics2D.Raycast(firePoint.position, firePoint.right);

        //if (hitInfo)
        //{

        //    Enemy enemy = hitInfo.transform.GetComponent<Enemy>();

        //    if(enemy != null)
        //    {
        //        enemy.TakeDamage();
        //        Debug.Log("HIT ENEMY");
        //    }

        //    //Instantiate(impactEffect, hitInfo.point, Quaternion.identity);

        //    lineRenderer.SetPosition(0, firePoint.position);
        //    lineRenderer.SetPosition(1, hitInfo.point);
        //}
        //else
        //{
        //    lineRenderer.SetPosition(0, firePoint.position);
        //    lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        //}

        //lineRenderer.enabled = true;

        //yield return new WaitForSeconds(0.1f);

        //lineRenderer.enabled = false;
    }
}
