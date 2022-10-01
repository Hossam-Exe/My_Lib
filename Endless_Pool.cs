using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless_Pool : MonoBehaviour
{
    // public float traget;

    public Transform spwan_point;
    public GameObject[] floornext;

    public Player_Move movespeed;

    public game_manager G_m;

    




    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Obstacle_For"))
        {
            
            movespeed.speed +=   0.05f;
            int floor_index = Random.Range(0, floornext.Length);


            if (Main_Loot_Skins.Instance.Rubic && Main_Loot_Skins.isrupic == false)
            {
                Instantiate(floornext[0], spwan_point.position, Quaternion.identity);
            }
            else if (Main_Loot_Skins.Instance.Dice && Main_Loot_Skins.isdice == false)
            {
                Instantiate(floornext[5], spwan_point.position, Quaternion.identity);
            }
            else if (Main_Loot_Skins.Instance.Basket && Main_Loot_Skins.isbasket == false)
            {
                Instantiate(floornext[1], spwan_point.position, Quaternion.identity);
            }
            else if (Main_Loot_Skins.Instance.Beach && Main_Loot_Skins.isbeach == false)
            {
                Instantiate(floornext[2], spwan_point.position, Quaternion.identity);
            }
            else if(Main_Loot_Skins.Instance.Football && Main_Loot_Skins.isfootball == false)
            {
                Instantiate(floornext[3], spwan_point.position, Quaternion.identity);
            }
            else if (Main_Loot_Skins.Instance.ball_8 && Main_Loot_Skins.isball8 == false)
            {
                Instantiate(floornext[4], spwan_point.position, Quaternion.identity);
            }
            else if (Bouns.isBouns==false&&game_manager._CurTime>=270
                 || Bouns.isBouns2 == false && game_manager._CurTime >= 540
                 || Bouns.isBouns3 == false && game_manager._CurTime >= 1080)
            {
                Instantiate(floornext[7], spwan_point.position, Quaternion.identity);
            }
            else
            {
                GameObject floor_pre = Instantiate(floornext[floor_index], spwan_point.position, Quaternion.identity);
            }
               







           
        }
    }
}
