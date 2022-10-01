using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine;
using UnityEngine.EventSystems;
using MoreMountains.NiceVibrations;

public class Drag_skills_Sphere : MonoBehaviour, IDragHandler, IEndDragHandler
    , IPointerDownHandler, IPointerUpHandler
{
    public Sphere_Pool _sphere_pool;
    public Beach_Pool _beach_pool;
    public Ball8_Pool _ball8_pool;
    public Foot_Pool _foot_pool;
    public Basket_Pool _basket_pool;



    public GameObject Range_ui;
    public GameObject Time_Dely;

    public AudioSource on_sfx;
    public AudioSource off_sfx;
    AudioSource Slow_clip;

    public GameObject Post_Out;
    public GameObject Cube_fade;
    public GameObject shadow;
    public GameObject Ui_main;

    [SerializeField]
    private LayerMask Mask;

    public GameObject Ball;
    public GameObject Ball_football;
    public GameObject Ball_beachball;
    public GameObject Ball_basketball;
    public GameObject Ball_eyeball;


    

    Camera cam;
    public RectTransform locapos;
    public VolumeProfile pro;
    private ChromaticAberration CA;

    bool IsReleased;
    void Awake()
    {
       
        cam = FindObjectOfType<Camera>();
        Slow_clip = this.GetComponent<AudioSource>();
        pro.TryGet(out CA);
    }

    public void OnDrag(PointerEventData eventData)
    {

        IsReleased = false;


        Time_Dely.SetActive(true);
        Range_ui.SetActive(true);
        CA.intensity.value = 1f;

        Time.timeScale = 0.7f;
       
        

       


        if (this.transform.position.y >= 50)
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
        Time.timeScale = 1f;
        

        
        Cube_fade.SetActive(false);
        shadow.SetActive(false);
        
        Ray ray = cam.ScreenPointToRay(eventData.position);
        RaycastHit rayhit;

        if (this.transform.position.y >= 50)
        {
            if (Physics.Raycast(ray, out rayhit, 6))
            {


                if (Main_Loot_Skins.isfootball && Loot_Select_Logic5.Select_Sphere)
                {
                    _sphere_pool.gameObject.SetActive(false);
                    _beach_pool.gameObject.SetActive(false);
                    _ball8_pool.gameObject.SetActive(false);
                    _foot_pool.gameObject.SetActive(true);
                    _basket_pool.gameObject.SetActive(false);

                    _foot_pool.Spawning("Foot", rayhit.point + Vector3.up * 0.5f, Ball_football.transform.rotation);
                   
                }
                else if (Main_Loot_Skins.isbeach&&Loot_Select_Logic3.Select_Sphere)
                {
                    _sphere_pool.gameObject.SetActive(false);
                    _beach_pool.gameObject.SetActive(true);
                    _ball8_pool.gameObject.SetActive(false);
                    _foot_pool.gameObject.SetActive(false);
                    _basket_pool.gameObject.SetActive(false);

                    _beach_pool.Spawning("Beach",rayhit.point + Vector3.up * 0.5f, Ball_beachball.transform.rotation);
                    
                }
                else if (Main_Loot_Skins.isbasket && Loot_Select_Logic6.Select_Sphere)
                {
                    _sphere_pool.gameObject.SetActive(false);
                    _beach_pool.gameObject.SetActive(false);
                    _ball8_pool.gameObject.SetActive(false);
                    _foot_pool.gameObject.SetActive(false);
                    _basket_pool.gameObject.SetActive(true);

                    _basket_pool.Spawning("Basket", rayhit.point + Vector3.up * 0.5f, Ball_basketball.transform.rotation);
                  
                }
                else if (Main_Loot_Skins.isball8 && Loot_Select_Logic4.Select_Sphere)
                {
                    _sphere_pool.gameObject.SetActive(false);
                    _beach_pool.gameObject.SetActive(false);
                    _ball8_pool.gameObject.SetActive(true);
                    _foot_pool.gameObject.SetActive(false);
                    _basket_pool.gameObject.SetActive(false);

                    _ball8_pool.Spawning("Ball8", rayhit.point + Vector3.up * 0.5f, Ball_eyeball.transform.rotation);
                    
                }
                else
                {
                    _sphere_pool.gameObject.SetActive(true);
                    _beach_pool.gameObject.SetActive(false);
                    _ball8_pool.gameObject.SetActive(false);
                    _foot_pool.gameObject.SetActive(false);
                    _basket_pool.gameObject.SetActive(false);

                    _sphere_pool.Spawning("Sphere", rayhit.point + Vector3.up * 0.5f, Quaternion.identity);
                }
                


            }
        }
        Ui_main.transform.position = locapos.position;
        Ui_main.SetActive(true);
        //Cube_fade.SetActive(false);

        MMVibrationManager.Haptic(HapticTypes.LightImpact);


    }





    private void Update()
    {
        if (this.transform.position.y >= 50)
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
