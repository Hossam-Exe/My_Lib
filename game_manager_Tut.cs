using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_manager_Tut : MonoBehaviour
{

    public float bcurtime;
    public float btime = 1f;

    public float curtime;
    public float time = 5f;
    Player_Move player;
    Image red_border;
   

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
    public GameObject over;
    public TextMeshProUGUI over_score;
    public TextMeshProUGUI Over_time;
    [Header("Shapes")]

    public GameObject Hybrid_Gaint;
    public GameObject hybrid_icon;
    public GameObject Glitch_obj;



    public TextMeshProUGUI TextField_timer;
    public static float _CurTime;

    
    void Awake()
    {
      
        Life_text = GameObject.FindGameObjectWithTag("Life_text").GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player_Move>();

        red_border = GameObject.FindGameObjectWithTag("Red_Border").GetComponent<Image>();

        SceneManager.LoadScene(3, LoadSceneMode.Additive);

        Invoke("scene_delay", 1f);
        //InvokeRepeating("Gaint_fun", 240, 240);

    }

    [System.Obsolete]
    void scene_delay()
    {
        
        SceneManager.UnloadScene(3);
    }
    void Start()
    {

        

        // Application.targetFrameRate = 60;
        bcurtime = btime;
        StartCoroutine(Counter());

        Lives_System.Live_Value -= 1;

        _CurTime = 0;

        life_value = life_cur_value;
        curtime = time;


        Time.timeScale = 0f;
    }


    void Update()
    {
        // GMAE TIME
     
        //TimeFun();





        //if (Coin_text != null)
        //{
        //    Coin_text.text = Coin_value.ToString("0");
        //}
       

        // Hybrid_Fun
        

        //if (Hybrid == true)
        //{
        //    StartCoroutine(Hybrid_Fun());
        //    life_cur_value += 1;
        //    curtime -= 1 * Time.deltaTime;
        //    loading_hybrid.value = curtime / 5;
        //}









       // over_score.text = Score.uiscore.ToString("0");
        //Over_time.text = TextField_timer.text;  
       // Life_text.text = life_value.ToString();

       

        if (life_value <= 0)
        {
           
          
            
        }
        if (life_value < 2)
        {
            red_border.enabled=true;
           
        }
        else if (life_value > 2)
        {
            red_border.enabled = false;

        }

    }

    public void gameover()
    {
        First_Time.IsFirstTime = false;
        Time.timeScale = 0f;
        over.SetActive(true);
        Player_Data_Handler.SaveFirstTime();


    }
    public void Play()
    {

        Time.timeScale = 1f;

    }
    public void damage()
    {

        life_value -= 1;


    }

    public void next()
    {

       //RestartAndroid();


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
            curtime = time;
            hybrid_icon.SetActive(false);
            Hybrid = false;
        }





    }




    IEnumerator Counter()
    {
        while (bcurtime >= 0)
        {
            bcurtime -= 1;
            yield return new WaitForSeconds(.5f);
            if (bcurtime <= 0)
            {
                player.enabled = true;
                StopCoroutine(Counter());

            }
        }








    }




    void TimeFun()
    {
        _CurTime += 1 * Time.deltaTime;
        float Min = (int)_CurTime / 60 % 60;
        float sec = (int)_CurTime % 60;

      
        string s2 = string.Format("{0:m mm}", Min.ToString());
        string s3 = string.Format("{0:s ss}", sec.ToString("0"));
        if (TextField_timer != null)
        {
            TextField_timer.text = s2 + "  :  " + s3;
        }
        

    }

    private static void RestartAndroid()
    {
        if (Application.isEditor) return;

        using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            const int kIntent_FLAG_ACTIVITY_CLEAR_TASK = 0x00008000;
            const int kIntent_FLAG_ACTIVITY_NEW_TASK = 0x10000000;

            var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            var pm = currentActivity.Call<AndroidJavaObject>("getPackageManager");
            var intent = pm.Call<AndroidJavaObject>("getLaunchIntentForPackage", Application.identifier);

            intent.Call<AndroidJavaObject>("setFlags", kIntent_FLAG_ACTIVITY_NEW_TASK | kIntent_FLAG_ACTIVITY_CLEAR_TASK);
            currentActivity.Call("startActivity", intent);
            currentActivity.Call("finish");
            var process = new AndroidJavaClass("android.os.Process");
            int pid = process.CallStatic<int>("myPid");
            process.CallStatic("killProcess", pid);
        }
    }


}
