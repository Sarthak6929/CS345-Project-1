using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public Stage2 stage2Script;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10.0f)
        {
            stage2Script.LooseLevel();
        }

    }
}
