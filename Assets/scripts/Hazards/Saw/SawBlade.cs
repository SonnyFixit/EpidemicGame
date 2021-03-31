using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawBlade : MonoBehaviour
{
    [SerializeField]
    
    //Tablica punktów, pomiędzy którymi wędruje piła. Punktami mogą być zwyczajne empty objects.
    private Transform[] waypoints;
    
    
    //Zmiana, która działa jako indeks powyższej tablicy
    private int targetPoint;
    
    [SerializeField]
    private float speed;

    void Update()
    {
        //Dodanie rotacji do piły.
        transform.Rotate(0, 0, 100f * speed * Time.deltaTime);


        //Zmiana pozycji poprzez wskazanie pozycji piły oraz pozycji danego punktu, 
        transform.position = Vector2.MoveTowards(transform.position, waypoints[targetPoint].position, speed * Time.deltaTime);

        //Jeżeli piła jest wystarczająco blisko pozycji wybranego wcześniej punktu, to zostaje wybrany nowy.
        if (Vector2.Distance(transform.position, waypoints[targetPoint].position) < .1f)
        {

            //Jeżeli obecny indeks jest mniejszy od wielkości tablicy - 1, to nowo przypisany jest o jeden większy od poprzedniego
            if (targetPoint < waypoints.Length - 1)
            {
                targetPoint = targetPoint + 1;
            }
            else
            {
                targetPoint = 0;
            }
        }
    }
}
