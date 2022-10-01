using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tut_EndScene : MonoBehaviour
{
    public game_manager_Tut Gm;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle_For"))
        {

            Gm.gameover();
        }
    }
}
