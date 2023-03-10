using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Intro : MonoBehaviour
{
    public GameObject uiObject;

    // Intiliase text
    void Start()
    {
        uiObject.SetActive(false);

    }
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(7);
        Destroy(uiObject);
        Destroy(gameObject);

    }
}
