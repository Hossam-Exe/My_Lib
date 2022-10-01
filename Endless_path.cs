
using UnityEngine;

public class Endless_path : MonoBehaviour,IPooler
{
    


    private const string _0 = "Floor0";
    private const string _1 = "Floor1";
    private const string _2 = "Floor2";
    private const string _3 = "Floor3";
    private const string _4 = "Floor4";
    private const string _5 = "Floor5";
    private const string _6 = "Floor6";
    private const string _7 = "Floor7";
    private const string _8 = "Floor8";
    private const string _9 = "Floor9";
    private const string _10 = "Floor10";
    private const string _11 = "Floor11";
    private const string _12 = "Floor12";
    private const string _13 = "Floor13";
    private const string _14 = "Floor14";
    private const string _15 = "Floor15";
    private const string _16 = "Floor16";
   
    // public float traget;

    public Transform spwan_point;
    public GameObject[] floornext;

    public Player_Move movespeed;
    
    public game_manager G_m;
    int floor_index;
     
    private string[] Pool_name = new string[17];

    public GameObject[] _Pf_list = new GameObject[17];

    int _rando;
    private void Start()
    {
        #region Floor_arr
        Pool_name[0] = _0;
        Pool_name[1] = _1;
        Pool_name[2] = _2;
        Pool_name[3] = _3;
        Pool_name[4] = _4;
        Pool_name[5] = _5;
        Pool_name[6] = _6;
        Pool_name[7] = _7;
        Pool_name[8] = _8;
        Pool_name[9] = _9;
        Pool_name[10] = _10;
        Pool_name[11] = _11;
        Pool_name[12] = _12;
        Pool_name[13] = _13;
        Pool_name[14] = _14;
        Pool_name[15] = _15;
        Pool_name[16] = _16;

        #endregion
       

    }

    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Obstacle_For"))
        {

        
          
                OnRePool();
           







        }
    }


   
    public void OnRePool()
    {
        Check_Collider.ins._last_number = Check_Collider.ins._cur_number;

       floor_index = Random.Range(0, Pool_name.Length);
        
        Check_Collider.ins._cur_number = floor_index;

        

        
        if (Check_Collider.ins._cur_number!= Check_Collider.ins._last_number)
        {

            if (Main_Loot_Skins.Instance.Rubic && Main_Loot_Skins.isrupic == false)
            {

                if (Check_Collider.ins._is_rubic_done)
                {
                     _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                        
                        Object_Pool.Instance.
                                            Spawning(Pool_name[2], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_rubic_done = true;
                    Object_Pool.Instance.Spawning(Pool_name[0], spwan_point.position, Quaternion.identity);
                }
                   
            }
            else if (Main_Loot_Skins.Instance.Dice && Main_Loot_Skins.isdice == false)
            {

                if (Check_Collider.ins._is_dice_done)
                {
                    _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                       
                        Object_Pool.Instance.
                                            Spawning(Pool_name[6], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_dice_done = true;
                   Object_Pool.Instance.Spawning(Pool_name[5], spwan_point.position, Quaternion.identity);
                }
               
            }
            else if (Main_Loot_Skins.Instance.Basket && Main_Loot_Skins.isbasket == false)
            {
                if (Check_Collider.ins._is_Basket_done)
                {
                    _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                       
                        Object_Pool.Instance.
                                            Spawning(Pool_name[3], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_Basket_done = true;
                    Object_Pool.Instance.Spawning(Pool_name[1], spwan_point.position, Quaternion.identity);
                }
               
            }
            else if (Main_Loot_Skins.Instance.Beach && Main_Loot_Skins.isbeach == false)
            {
                if (Check_Collider.ins._is_Beach_done)
                {
                    _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                       
                        Object_Pool.Instance.
                                            Spawning(Pool_name[4], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_Beach_done = true;
                    Object_Pool.Instance.Spawning(Pool_name[2], spwan_point.position, Quaternion.identity);
                }
            }
            else if (Main_Loot_Skins.Instance.Football && Main_Loot_Skins.isfootball == false)
            {
                if (Check_Collider.ins._is_Football_done)
                {
                    _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                       
                        Object_Pool.Instance.
                                            Spawning(Pool_name[9], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_Football_done = true;
                    Object_Pool.Instance.Spawning(Pool_name[3], spwan_point.position, Quaternion.identity);
                }
            }
            else if (Main_Loot_Skins.Instance.ball_8 && Main_Loot_Skins.isball8 == false)
            {
                if (Check_Collider.ins._is_ball_8_done)
                {
                    _rando = Random.Range(0, 15);

                    if (_rando != Check_Collider.ins._last_number)
                    {

                        Object_Pool.Instance.
                                            Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);

                    }
                    else
                    {
                        
                        Object_Pool.Instance.
                                            Spawning(Pool_name[5], spwan_point.position, Quaternion.identity);
                    }
                }
                else
                {
                    Check_Collider.ins._is_ball_8_done = true;
                    Object_Pool.Instance.Spawning(Pool_name[4], spwan_point.position, Quaternion.identity);
                }
            }
            else if (Bouns.isBouns == false && game_manager._CurTime >= 270
                 || Bouns.isBouns2 == false && game_manager._CurTime >= 540
                 || Bouns.isBouns3 == false && game_manager._CurTime >= 1080)
            {

                Object_Pool.Instance.Spawning(Pool_name[7], spwan_point.position, Quaternion.identity);
            }
            else
            {

                Object_Pool.Instance.Spawning(Pool_name[floor_index], spwan_point.position, Quaternion.identity);

            }

        }
        else
        {


            _rando = Random.Range(0, 15);

            if (_rando != Check_Collider.ins._last_number)
            {

                Object_Pool.Instance.
                                    Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);
               
            }
            else
            {
                _rando = Random.Range(0, 15);
                Object_Pool.Instance.
                                    Spawning(Pool_name[_rando], spwan_point.position, Quaternion.identity);
                
            }


        }

        

        


    }
}
