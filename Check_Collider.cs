using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Collider : MonoBehaviour
{

    public static Check_Collider ins;
    public int _cur_number;
    public int _last_number;

    public bool _is_rubic_done;
    public bool _is_dice_done;
    public bool _is_Basket_done;
    public bool _is_Beach_done;
    public bool _is_Football_done;
    public bool _is_ball_8_done;

    void Start()
    {
        ins = this;
    }


   
}
