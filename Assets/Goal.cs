using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Stage2 stage2Script;

    private void OnTriggerEnter(Collider other)
    {
        stage2Script.WinLevel();
    }
}
