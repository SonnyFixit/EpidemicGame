using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GardenScript : MonoBehaviour
{
    public GameObject destroyVirusModal;
    bool virusCollision ;
    

    public GameObject toxicCLoud;
    public GameObject portalHome;
    public static bool virusDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        destroyVirusModal.SetActive(false);
        virusCollision = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && (virusCollision))
        {
            
            
            VirusActionFinish();
            Debug.Log("BOOOOM");
            Instantiate(toxicCLoud, transform.position, Quaternion.Euler(0, 0, 0));
            Instantiate(portalHome, new Vector3(-16.52708f, -1.36f, 0f), Quaternion.Euler(0, 0, 0));


            Destroy(gameObject, 2);
            virusDead = true;

            
            
        }

    }


    // Show or hide virus modal, set collision

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            VirusActionStart();
            virusCollision = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            VirusActionFinish();
            virusCollision = false;
        }
    }

    void VirusActionStart()
    {
        destroyVirusModal.SetActive(true);
    }

    void VirusActionFinish()
    {
        destroyVirusModal.SetActive(false);
    }
}
