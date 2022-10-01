
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Lives_System : MonoBehaviour
{
    [Header("-------------")]

    public Text TextField;
    public Text TextValue;
    public TextMeshProUGUI TextCoin;
    float _CurTime;
    [Space]
    [Header("-------------")]
    [SerializeField]
    float _TimeInMin = 120;


    TimeSpan ts;



    public static int Live_Value;
    public static string Live_Time_Passed;
    public RectTransform not_enough;
    public GameObject not_enough_PF;

    void Awake()
    {
       
        
       






        if (First_Time.IsFirstTime)
        {
            Live_Value += 5;
        }

        _CurTime = _TimeInMin;


    }


    private void Start()
    {

        TextValue.gameObject.SetActive(true);
        TextValue.enabled = true;

        Time_Passed();


    }
    void Update()
    {

       


        TextValue.text = Live_Value.ToString();
        TextCoin.text = game_manager.Coin_value.ToString();

        if (Live_Value <= 0)
        {
            Live_Value = 0;

        }

        if (Live_Value >= 5)
        {
            TextField.enabled = false;
            Live_Value = 5;
            return;
        }

        if (Live_Value <= 5)
        {
            TextField.enabled = true;
            _CurTime -= 1 * Time.deltaTime;


            if (_CurTime <= 0)
            {
                _CurTime = _TimeInMin;
                Live_Value += 1;
            }
            TimeFun();
        }



    }

    void Time_Passed()
    {
        Player_Data_Handler.Load_Time_Passed();

        DateTime date_quit = DateTime.Parse(Live_Time_Passed);
        DateTime now = DateTime.Now;

        if (now > date_quit)
        {
            ts = now - date_quit;

            

            if (Live_Value <= 3)
            {
                //if (ts.Minutes >= 3)
                //{
                //    Live_Value -= 3;
                //}
                //else if (ts.Minutes >= 2)
                //{
                //    Live_Value -= 2;
                //}
                //else 
                
                if(ts.Minutes >= 1)
                {
                   

                    Live_Value += 1;
                    TextValue.text = Live_Value.ToString();
                }
            } 
            

        }
    }


    public void BuyOne()
    {
        if (game_manager.Coin_value >= 10f && Live_Value <= 4)
        {
            game_manager.Coin_value -= 10f;
            Live_Value += 1;

        }
        else if (game_manager.Coin_value < 10f)
        {
            Ui_Pool.Instance.Spawning("Battery", not_enough.position, Quaternion.identity);

        }
    }

    public void BuyTwo()
    {
        if (game_manager.Coin_value >= 20f && Live_Value <= 4)
        {
            game_manager.Coin_value -= 20f;
            Live_Value += 2;

        }
        else if (game_manager.Coin_value < 20f)
        {
            Ui_Pool.Instance.Spawning("Battery", not_enough.position, Quaternion.identity);
        }
    }

    public void BuyFull()
    {
        if (game_manager.Coin_value >= 50f && Live_Value <= 4)
        {
            game_manager.Coin_value -= 50f;
            Live_Value += 5;

        }
        else if (game_manager.Coin_value < 50f)
        {
            Ui_Pool.Instance.Spawning("Battery", not_enough.position, Quaternion.identity);
        }
    }

    public void Buy_Ad()
    {
      

          Live_Value += 5;


    }


    void TimeFun()
    {

        float Min = (int)_CurTime / 60 % 60;
        float sec = (int)_CurTime % 60;

        string s1 = string.Format("{0:m mm}", Min.ToString());
        string s2 = string.Format("{0:s ss}", sec.ToString());
        TextField.text = s1 + "  :  " + s2;

    }

    public void OnApplicationQuit()
    {
        DateTime Quit_now = DateTime.Now;
        Live_Time_Passed = Quit_now.ToString();
        Player_Data_Handler.Save_Time_Passed();
    }
}
