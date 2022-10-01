using EZCameraShake;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move : MonoBehaviour
{
    
    [SerializeField]
    float Speedingtime;
    [SerializeField]
    float min;
    [SerializeField]
    float max;


    //public Animator anim_glow;
    //public Animator anim_glow2;

    public PS_COLOR _ps_color;

    public Image mana_image;

    public float TimeCheck = 20f;
    public float CurTimeCheck { get; set; }


    //  public Transform main;
    Rigidbody rb;
    public float speed = 1f;
   public float lastspeed;

    Vector3 _NewV3  ;


    //Cor
    WaitForSeconds _wait_pacing;
    void Awake()
    {
       

        _wait_pacing = new WaitForSeconds(15f);


      

        rb = this.GetComponent<Rigidbody>();

        

       
    }
    private void Start()
    {
        
            Player_Data_Handler.LoadData();
            Player_Data_Handler.LoadData_skins();
       
       

        
        CurTimeCheck = TimeCheck;


        _NewV3 = new Vector3(0, 0, 1);
       
        if (First_Time.IsFirstTime == false)
        {
            speed = 2f;
        }

        lastspeed = speed;
        Score.uiscore = 0;
        InvokeRepeating("Speed_fun", 180, Speedingtime);
    }

   
    void Update()
    {
      
        transform.position += _NewV3 * Time.smoothDeltaTime * -speed;



        Mana();

        
       



    }
    //void OnEnable()
    //{
    //  Player_Data_Handler.LoadData();
    //}

    void Mana()
    {
        CurTimeCheck -= 1f * Time.smoothDeltaTime;
        mana_image.fillAmount = CurTimeCheck / TimeCheck;
        if (CurTimeCheck <= 0)
        {
            CameraShaker.Instance.ShakeOnce(3f, 3f, 1f, 1f);
            game_manager.life_value -= 1;
            CurTimeCheck = TimeCheck;
        }
    }
    void OnDisable()
    {
        
        Player_Data_Handler.SaveData();
        Player_Data_Handler.SaveData_skins();
        //System.GC.Collect();
        
    }

    public void timescale()
    {
        Time.timeScale = 1;
    }
    public void OnApplicationQuit()
    {
        Player_Data_Handler.SaveData();
        Player_Data_Handler.SaveData_skins();
        Player_Data_Handler.SaveData_Traills();
       
      
    }


    void Speed_fun()
    {

        StartCoroutine(Speed_Pacing());

    }
    IEnumerator Speed_Pacing()
    {
        _ps_color._isSpeed = true;
        _ps_color._speed_up();

        lastspeed = speed;
        speed += 0.15f;
        //Glitch_obj.SetActive(true);
        speed += Random.Range(min, max);
        
        yield return _wait_pacing;


        _ps_color._delay();
        _ps_color._isSpeed = false;
        speed = lastspeed ;
        //Glitch_obj.SetActive(true);
        StopCoroutine(Speed_Pacing());



    }
}
