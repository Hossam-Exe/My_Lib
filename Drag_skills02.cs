using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine;
using UnityEngine.EventSystems;
using MoreMountains.NiceVibrations;

public class Drag_skills02 : MonoBehaviour, IDragHandler,
    IEndDragHandler,IPointerDownHandler,IPointerUpHandler
{


    public  Cube_Pool _cube_Pool;
    public Rubic_Pool _rubic_pool;
    public Dice_Pool _dice_pool;
    public static Drag_skills02 Instance;

    
    public GameObject Range_ui;
    
    public GameObject Post_Out;

    public AudioSource on_sfx;
    public AudioSource off_sfx;
    AudioSource Slow_clip;

    public GameObject Time_Dely;
    public Animator anim;

    public GameObject Cube_fade;
    public GameObject shadow;
    public GameObject Ui_main;
    [SerializeField]
    private LayerMask Mask;

    public GameObject Cube;
    
    public GameObject dice;
    public GameObject rubic;
    

   
   
   

    Camera cam;
    public RectTransform locapos;


    public VolumeProfile pro;
    private ChromaticAberration CA;

    bool IsReleased;
    void Awake()
    {
        Instance = this;
        cam = FindObjectOfType<Camera>();
        Slow_clip = this.GetComponent<AudioSource>();
        //_cube_Pool = FindObjectOfType<Cube_Pool>();
        //_rubic_pool = FindObjectOfType<Rubic_Pool>();
        //_dice_pool = FindObjectOfType<Dice_Pool>();
;        pro.TryGet(out CA);

    }
    
    public void OnDrag(PointerEventData eventData)
    {
        IsReleased = false;

        Time_Dely.SetActive(true);
        Range_ui.SetActive(true);
        CA.intensity.value=1f;
        Time.timeScale = 0.7f;
       

       



        if (this.transform.position.y>=50)
         {
           shadow.SetActive(true);
           Cube_fade.SetActive(true);
            Ui_main.SetActive(false);
            
        }
        if (this.transform.position.y <=50)

        {
            shadow.SetActive(false);
            Cube_fade.SetActive(false);
            Ui_main.SetActive(true);
            
            Ui_main.transform.position = transform.position;
        }


        transform.position = eventData.position;



    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
            on_sfx.Stop();
            off_sfx.PlayOneShot(off_sfx.clip);

            Post_Out.SetActive(true);


            Time_Dely.SetActive(false);
            Range_ui.SetActive(false);
            CA.intensity.value = 0f;
            Cube_fade.SetActive(false);
            Time.timeScale = 1f;


            shadow.SetActive(false);


            Ray ray = cam.ScreenPointToRay(eventData.position);
            RaycastHit rayhit;

        if (this.transform.position.y >= 50)
        {
            if (Physics.Raycast(ray, out rayhit, 6))
            {

                if (Main_Loot_Skins.isdice && Loot_Select_Logic2.Select_Cube)
                {

                    _cube_Pool.gameObject.SetActive(false);
                    _rubic_pool.gameObject.SetActive(false);
                    _dice_pool.gameObject.SetActive(true);

                    _dice_pool.Spawning("Dice", rayhit.point + Vector3.up * 0.5f, dice.transform.rotation);


                }
                else if (Main_Loot_Skins.isrupic && Loot_Select_Logic.Select_Cube)
                {
                    _cube_Pool.gameObject.SetActive(false);
                    _rubic_pool.gameObject.SetActive(true);
                    _dice_pool.gameObject.SetActive(false);

                    _rubic_pool.Spawning("Rubic", rayhit.point + Vector3.up * 0.5f, rubic.transform.rotation);

                }
                else
                {
                    _cube_Pool.gameObject.SetActive(true);
                    _rubic_pool.gameObject.SetActive(false);
                    _dice_pool.gameObject.SetActive(false);

                    _cube_Pool.Spawning("Cube", rayhit.point + Vector3.up * 0.5f, Quaternion.identity);
                }
                 


            }
        }
            Ui_main.transform.position = locapos.position;
            Ui_main.SetActive(true);

            MMVibrationManager.Haptic(HapticTypes.LightImpact);

        
    }



    private void Update()
    {
       
        if (this.transform.position.y >= 50 )
        {
           
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit1;

            if (Physics.Raycast(ray, out rayhit1,6))
            {
                Cube_fade.transform.position = rayhit1.point + new Vector3(0, 1f, 0);
            }
            else
            {
                Cube_fade.SetActive(false);
                shadow.SetActive(false);
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Slow_clip.Play();
        off_sfx.Stop();
        on_sfx.PlayOneShot(on_sfx.clip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Slow_clip.Stop();
        Ui_main.transform.position = locapos.position;
        Ui_main.SetActive(true);
        IsReleased = true;
        Cube_fade.SetActive(false);
            shadow.SetActive(false);
        
    }




   



}
