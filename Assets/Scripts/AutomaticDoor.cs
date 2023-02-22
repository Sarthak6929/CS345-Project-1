using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AutomaticDoor : MonoBehaviour
{

    public GameObject movingDoor;

    public float maximumOpening = 50f;
    public float maximumClosing = 10f;

    public float movementSpeed = 10f;

    bool playerIsHere;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (movingDoor.transform.position.z < maximumOpening)
            {
                movingDoor.transform.Translate(movementSpeed * 0f, 0f, Time.deltaTime);
            }
        }
        else
        {
            if (movingDoor.transform.position.z > maximumClosing)
            {
                movingDoor.transform.Translate(-movementSpeed * 0f, 0f, Time.deltaTime);
            }
        }


    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}