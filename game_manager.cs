using System.Collections;

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager : MonoBehaviour
{
    public static game_manager _ins;

    public Ad_Handller _AD_one;
    
    public float curtime;
    public float time = 7f;

    Image red_border;
   public AudioSource red_border_sfx;

    public int Scene_Rest;
    public int Scene_Next;

    public bool Hybrid = true;

    public static float life_value = 3;
    [SerializeField]
    public static float Coin_value = 0f;
    public float life_cur_value;
    [Header("UI")]
    TextMeshProUGUI Life_text;
    public Slider loading_hybrid;
    public TextMeshProUGUI Coin_text;
    public TextMeshProUGUI Coin_text_over;
    public GameObject over;
    public TextMeshProUGUI over_score;
    public TextMeshProUGUI Over_time;
    [Header("Shapes")]

    public GameObject Hybrid_Gaint;
    public GameObject hybrid_icon;
    



    public TextMeshProUGUI TextField_timer;
    public static float _CurTime;


    int Frame_Amount=3;
    private bool _isTextFieldTimerNotNull;
    private bool _isCoinTextNotNull;

   public int ADs_iNDEX;

    // Cor
    WaitForSeconds _wait_gaint;
    void Awake()
    {
        _ins = this;

        ADs_iNDEX = ES3.Load<int>("ad_index");

        ADs_iNDEX += 1;


        _wait_gaint = new WaitForSeconds(30f);

        Life_text = GameObject.FindGameObjectWithTag("Life_text").GetComponent<TextMeshProUGUI>();
     
       
            red_border = GameObject.FindGameObjectWithTag("Red_Border").GetComponent<Image>();


        InvokeRepeating("Gaint_fun", 240, 240);
        InvokeRepeating("TimeFun", 1, 1);
      
    }

    void Start()
    {
        life_value = 3;
        Lives_System.Live_Value -= 1;

        _isCoinTextNotNull = Coin_text != null;
        _isTextFieldTimerNotNull = TextField_timer != null;
      

        Time.timeScale = 1;
        Coin_value = Mathf.Abs(Coin_value);
        

        _CurTime = 0;

        life_value = life_cur_value;
        curtime = time;

        RewardSystem._onQuit();

    }


    void Update()
    {
        // GMAE TIME



        _CurTime += 1 * Time.deltaTime;
        // TimeFun();






        // Hybrid_Fun


        if (Hybrid == true)
        {
            StartCoroutine(Hybrid_Fun());
            life_cur_value += 1;
            curtime -= 1 * Time.deltaTime;
            loading_hybrid.value = curtime / 7;
        }







        if (Time.frameCount% Frame_Amount==0)
        {



            if (_isCoinTextNotNull)
            {
                Coin_text.text = Coin_value.ToString("0");
            }


       
            
            
                
                Life_text.text = life_value.ToString();




                if (life_value <= 0)
                {
                    gameover();
                    //StartCoroutine(Glitch_ienum());

                }
                if (life_value < 2)
                {
                    red_border.enabled=true;
                    red_border_sfx.enabled = true;
                }
                else if (life_value > 2)
                {
                    red_border.enabled = false;
                    red_border_sfx.enabled=false;
                }
        }

        

    }

    public void gameover()
    {
        over.SetActive(true);
        Coin_text_over.text = Coin_value.ToString();
        over_score.text = Score.uiscore.ToString("0");
        Over_time.text = TextField_timer.text;

        Player_Data_Handler.SaveScore();

        Time.timeScale = 0.1f;

        if (ADs_iNDEX >= 3)
        {
            _AD_one.ShowAd();
            ADs_iNDEX = 0;
        }

        ES3.Save<int>("ad_index", ADs_iNDEX);
    }
    public void gameover_resume()
    {
        if (Coin_value >= 50f)
        {
            Time.timeScale = 1f;
            over.SetActive(false);

            Coin_value -= 50f;

            life_value += 3;
        }
        


    }

    public void gameover_resume_AD_2()
    {
    
    }

        public void gameover_resume_AD()
    {
        
            Time.timeScale = 1f;
            over.SetActive(false);

           

            life_value += 3;
       



    }
    public void gameover2()
    {

        SceneManager.LoadScene(Scene_Rest);

    }
    public void damage()
    {

        life_value -= 1;


    }

    public void next()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene(1);
    }

    public void home()
    {
        SceneManager.LoadScene(0);

    }

    public void exit()
    {
        Application.Quit();
       
    }


    IEnumerator Hybrid_Fun()
    {
        while (Hybrid == true)
        {
            hybrid_icon.SetActive(true);
            yield return new WaitForSeconds(curtime);
            if (Hybrid_Drag.IsReleased)
            {
                curtime = time;
                hybrid_icon.SetActive(false);
                Hybrid = false;
            }
            
        }





    }

    
    void Gaint_fun()
    {
        
            StartCoroutine(Gaint());
       
    }
    IEnumerator Gaint()
    {
       
        Hybrid_Gaint.SetActive(true);
        yield return _wait_gaint;
       
        Hybrid_Gaint.SetActive(false);
        StopCoroutine(Gaint());
        


    }
    IEnumerator Glitch_ienum()
    {

        //Glitch_obj.SetActive(true);
       
        yield return new WaitForSecondsRealtime(0.5f);
        //Glitch_obj.SetActive(false);
        

       // 
        StopCoroutine(Glitch_ienum());

    }

   



    void TimeFun()
    {
        
        float min = (int)_CurTime / 60 % 60;
        float sec = (int)_CurTime % 60;


        string s1 = string.Format("{0:m mm}", min.ToString());
        string s2 = string.Format("{0:s ss}", sec.ToString());

        if (_isTextFieldTimerNotNull)
        {
            TextField_timer.text = s1 + "  :  " + s2;
        }
        

    }

    void OnDisable()
    {
        ES3.Save<int>("ad_index", ADs_iNDEX);
    }

    public void OnApplicationQuit()
    {
        ES3.Save<int>("ad_index", ADs_iNDEX);

        RewardSystem._onQuit();

    }

}
