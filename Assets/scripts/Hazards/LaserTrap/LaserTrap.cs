using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{

    private float timeTillSpawn;

    [SerializeField]
    private float startTimeTilSpawn;

    //Całość jest zrobiona jako empty game object - nazwany LaserTrap
    //Do niego jest przypisany skrypt LaserTrap. Do efektu lasera jest natomiast przypisany skrypt LaserDestroy
    
    public GameObject Laser;

    
    //Współrzędne miejsca, w którym pojawia się laser
    //Najlepiej podać jakiś empty object i pamiętać o jego rotacji - laser jest skierowany w dół, więc ten obiekt też musi miec podobną rotację. 
    public Transform whereToSpawn;



    private void Update()

    {

        //Skrypt opiera się na "odliczeniu".
        //Jeżeli timeTillSpawn jest równy albo mniejszy od zera, wtedy lasera pojawia się w określonym miejscu, przyjmując pozycję oraz rotację tego wskazanego w inspektorze punktu

        if (timeTillSpawn <= 0)

        {
            Instantiate(Laser, whereToSpawn.position, whereToSpawn.rotation);

            timeTillSpawn = startTimeTilSpawn;
        }

        else

        {

            //W innym przypadku "odliczany" jest czas
            
            timeTillSpawn -= Time.deltaTime;
            

        }

    }
}

