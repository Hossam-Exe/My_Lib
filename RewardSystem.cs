
using System;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class RewardSystem : MonoBehaviour
{
    public UnityEvent OnDayChange;
    public UnityEvent OnDayStill;


    [Header("References")]
    public TextMeshProUGUI TextCoin;
    public GameObject Day1_Reach_Fx;
    public GameObject Day2_Reach_Fx;
    public GameObject Day3_Reach_Fx;
    public GameObject Day4_Reach_Fx;
    public GameObject Day5_Reach_Fx;


    public Button Day1_Reach_BT;
    public Button Day2_Reach_BT;
    public Button Day3_Reach_BT;
    public Button Day4_Reach_BT;
    public Button Day5_Reach_BT;

    [Header("Days Reward Amount")]
    [SerializeField]
    private float Reward_Amount_Day_1;
    [SerializeField]
    private float Reward_Amount_Day_2;
    [SerializeField]
    private float Reward_Amount_Day_3;
    [SerializeField]
    private float Reward_Amount_Day_4;
    [SerializeField]
    private float Reward_Amount_Day_5;


    public static string Day_index;
    TimeSpan ts;


    public static bool Day_1_bool = false;
    public static bool Day_2_bool = false;
    public static bool Day_3_bool = false;
    public static bool Day_4_bool = false;
    public static bool Day_5_bool = false;


    public static bool Day_1_IsCollect = false;
    public static bool Day_2_IsCollect = false;
    public static bool Day_3_IsCollect = false;
    public static bool Day_4_IsCollect = false;
    public static bool Day_5_IsCollect = false;

    void Start()
    {
        

        Reward_Data_Save.LoadDays();

        TextCoin.text = game_manager.Coin_value.ToString();


        Days_Passed();

        _OnStart();

    }

    
  
    void Update()
    {
        TextCoin.text = game_manager.Coin_value.ToString();
    }

    void Days_Passed()
    {
       

        DateTime date_quit = DateTime.Parse(Day_index);
        DateTime now = DateTime.Now.Date;


        

        if (now > date_quit)
        {
            ts = now - date_quit;


            

            if (ts.Days >= 1)
            {
                Day1_Reach_Fx.SetActive(true);
                Day_1_bool = true;
                Day1_Reach_BT.enabled = true;
                
            }
             if (ts.Days >= 1 && Day_1_IsCollect == true)
            {
                Day2_Reach_Fx.SetActive(true);
                Day_2_bool = true;
                Day2_Reach_BT.enabled = true;
                
            }
             if (ts.Days >= 1 && Day_1_IsCollect == true && Day_2_IsCollect == true)
            {
                Day3_Reach_Fx.SetActive(true);
                Day_3_bool = true;
                Day3_Reach_BT.enabled = true;
               
            }
             if (ts.Days >= 1 && Day_1_IsCollect == true && Day_2_IsCollect == true && Day_3_IsCollect == true)
            {
                Day4_Reach_Fx.SetActive(true);
                Day_4_bool = true;
                Day4_Reach_BT.enabled = true;
                
            }
             if (ts.Days >= 1 && Day_1_IsCollect == true 
                && Day_2_IsCollect == true && Day_3_IsCollect == true && Day_4_IsCollect == true)
            {
                Day5_Reach_Fx.SetActive(true);
                Day_5_bool = true;
                Day5_Reach_BT.enabled = true;




            }



        }
    }


  public  void RewardRestart()
    {


            Day5_Reach_Fx.SetActive(false);
            Day4_Reach_Fx.SetActive(false);
            Day3_Reach_Fx.SetActive(false);
            Day2_Reach_Fx.SetActive(false);
            Day1_Reach_Fx.SetActive(false);


            Reward_Data_Save.Rest();
            
        
    }


    void _OnStart()
    {

        if (ts.Days >= 1)
        {

            OnDayChange.Invoke();

        }
        else if (ts.Days <= 0)
        {
            OnDayStill.Invoke();
        }

        if (Day_1_IsCollect)
        {
            Day1_Reach_BT.enabled = false;
            Day1_Reach_Fx.SetActive(false);
        }

        if (Day_2_IsCollect)
        {
            Day2_Reach_BT.enabled = false;
            Day2_Reach_Fx.SetActive(false);
        }

        if (Day_3_IsCollect)
        {
            Day3_Reach_BT.enabled = false;
            Day3_Reach_Fx.SetActive(false);
        }

        if (Day_4_IsCollect)
        {
            Day4_Reach_BT.enabled = false;
            Day4_Reach_Fx.SetActive(false);
        }

        if (Day_5_IsCollect)
        {
            Day5_Reach_BT.enabled = false;
            Day5_Reach_Fx.SetActive(false);
        }


    }

    public void Day_one()
    {

        if (Day_1_bool && Day_1_IsCollect==false)
        {
            Day_1_IsCollect = true;

            Day1_Reach_BT.enabled = false;
            Day1_Reach_Fx.SetActive(false);

            

            game_manager.Coin_value += Reward_Amount_Day_1;

            Player_Data_Handler.SaveData();
        }

    }
    public void Day_Two()
    {

        if (Day_2_bool && Day_2_IsCollect == false)
        {

            Day_2_IsCollect = true;

            Day2_Reach_BT.enabled = false;
            Day2_Reach_Fx.SetActive(false);

            game_manager.Coin_value += Reward_Amount_Day_2;

            Player_Data_Handler.SaveData();


        }

    }
    public void Day_There()
    {

        if (Day_3_bool && Day_3_IsCollect == false)
        {

            Day_3_IsCollect = true;


            Day3_Reach_BT.enabled = false;
            Day3_Reach_Fx.SetActive(false);

            game_manager.Coin_value += Reward_Amount_Day_3;

            Player_Data_Handler.SaveData();
        }

    }
    public void Day_Four()
    {

        if (Day_4_bool && Day_4_IsCollect == false)
        {

            Day_4_IsCollect = true;

            Day4_Reach_BT.enabled = false;
            Day4_Reach_Fx.SetActive(false);

            game_manager.Coin_value += Reward_Amount_Day_4;

            Player_Data_Handler.SaveData();
        }

    }
    public void Day_Five()
    {

        if (Day_5_bool && Day_5_IsCollect == false)
        {

            Day_5_IsCollect = true;

            Day5_Reach_BT.enabled = false;
            Day5_Reach_Fx.SetActive(false);

            Day5_Reach_Fx.SetActive(false);
            game_manager.Coin_value += Reward_Amount_Day_5;
           
            RewardRestart();
            Player_Data_Handler.SaveData();
        }

    }

    public void OnApplicationQuit()
    {
        DateTime Quit_now = DateTime.Now.Date;
        Day_index = Quit_now.ToString();
        Reward_Data_Save.SaveDays();
        
    }


    public static void _onQuit()
    {
        DateTime Quit_now = DateTime.Now.Date;
        Day_index = Quit_now.ToString();
        Reward_Data_Save.SaveDays();
    }






    //
    #region Saving Class

  
    // Saving Class
    public class Reward_Data_Save 
    {

      

        public static void SaveDays()
        {

            ES3.Save<string>("Days", RewardSystem.Day_index);

            ES3.Save<bool>("Day_1_bool", RewardSystem.Day_1_bool);
            ES3.Save<bool>("Day_2_bool", RewardSystem.Day_2_bool);
            ES3.Save<bool>("Day_3_bool", RewardSystem.Day_3_bool);
            ES3.Save<bool>("Day_4_bool", RewardSystem.Day_4_bool);
            ES3.Save<bool>("Day_5_bool", RewardSystem.Day_5_bool);


            ES3.Save<bool>("Day_1_IsCollect", RewardSystem.Day_1_IsCollect);
            ES3.Save<bool>("Day_2_IsCollect", RewardSystem.Day_2_IsCollect);
            ES3.Save<bool>("Day_3_IsCollect", RewardSystem.Day_3_IsCollect);
            ES3.Save<bool>("Day_4_IsCollect", RewardSystem.Day_4_IsCollect);
            ES3.Save<bool>("Day_5_IsCollect", RewardSystem.Day_5_IsCollect);


        }
        public static void LoadDays()
        {


            RewardSystem.Day_index = ES3.Load<string>("Days");


            RewardSystem.Day_1_bool = ES3.Load<bool>("Day_1_bool");
            RewardSystem.Day_2_bool = ES3.Load<bool>("Day_2_bool");
            RewardSystem.Day_3_bool = ES3.Load<bool>("Day_3_bool");
            RewardSystem.Day_4_bool = ES3.Load<bool>("Day_4_bool");
            RewardSystem.Day_5_bool = ES3.Load<bool>("Day_5_bool");


            RewardSystem.Day_1_IsCollect = ES3.Load<bool>("Day_1_IsCollect");
            RewardSystem.Day_2_IsCollect = ES3.Load<bool>("Day_2_IsCollect");
            RewardSystem.Day_3_IsCollect = ES3.Load<bool>("Day_3_IsCollect");
            RewardSystem.Day_4_IsCollect = ES3.Load<bool>("Day_4_IsCollect");
            RewardSystem.Day_5_IsCollect = ES3.Load<bool>("Day_5_IsCollect");


        }

        public static void Rest()
        {
            RewardSystem.Day_index = ("");

          
            RewardSystem.Day_1_bool = false;
            RewardSystem.Day_2_bool = false;
            RewardSystem.Day_3_bool = false;
            RewardSystem.Day_4_bool = false;
            RewardSystem.Day_5_bool = false;



            RewardSystem.Day_1_IsCollect = false;
            RewardSystem.Day_2_IsCollect = false;
            RewardSystem.Day_3_IsCollect = false;
            RewardSystem.Day_4_IsCollect = false;
            RewardSystem.Day_5_IsCollect = false;


        }



    }
    #endregion
}
