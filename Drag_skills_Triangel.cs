using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine;
using UnityEngine.EventSystems;
using MoreMountains.NiceVibrations;

public class Drag_skills_Triangel : MonoBehaviour, IDragHandler, IEndDragHandler
     , IPointerDownHandler, IPointerUpHandler
{
    public GameObject Range_ui;
    public GameObject Time_Dely;
    public GameObject Post_Out;

    public AudioSource on_sfx;
    public AudioSource off_sfx;
    AudioSource Slow_clip;

    public GameObject Cube_fade;
    public GameObject shadow;
    public GameObject Ui_main;

    private Triangle_Pool _pooler;

    public GameObject Triangel;


    Camera cam;
    public RectTransform locapos;

    public VolumeProfile pro;
    private ChromaticAberration CA;

    bool IsReleased;
    void Awake()
    {
        _pooler= FindObjectOfType<Triangle_Pool>();
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
        if (this.transform.position.y <= 50)

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
                _pooler.Spawning("Triangle", rayhit.point + Vector3.up * 0.5f, Quaternion.identity);
               // Instantiate(Triangel, rayhit.point + Vector3.up * 0.5f, Triangel.transform.rotation);

            }
        }
        Ui_main.transform.position = locapos.position;
        Ui_main.SetActive(true);

        MMVibrationManager.Haptic(HapticTypes.LightImpact);


    }





    private void Update()
    {
        if (this.transform.position.y >= 50)
        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit1;

            if (Physics.Raycast(ray, out rayhit1, 6))
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


//    public GameObject Range_ui;
//    public GameObject Time_Dely;
//    public GameObject Post_Out;

//    public AudioSource on_sfx;
//    public AudioSource off_sfx;
//    AudioSource Slow_clip;

//    public GameObject Cube_fade;
//    public GameObject shadow;
//    public GameObject Ui_main;



//    public GameObject Triangel;


//    Camera cam;
//    public RectTransform locapos;

//    public VolumeProfile pro;
//    private ChromaticAberration CA;

//    void Awake()
//    {

//        cam = FindObjectOfType<Camera>();

//        Slow_clip = this.GetComponent<AudioSource>();
//        pro.TryGet(out CA);
//    }

//    public void OnDrag(PointerEventData eventData)
//    {

//        Time_Dely.SetActive(true);
//        Range_ui.SetActive(true);
//        CA.intensity.value = 1f;
//        Time.timeScale = 0.7f;



//        if (this.transform.position.y >= 50)
//        {
//            shadow.SetActive(true);
//            Cube_fade.SetActive(true);
//            Ui_main.SetActive(false);

//        }
//        if (this.transform.position.y <= 50)

//        {
//            shadow.SetActive(false);
//            Cube_fade.SetActive(false);
//            Ui_main.SetActive(true);

//            Ui_main.transform.position = transform.position;
//        }




//        transform.position = eventData.position;



//    }

//    public void OnEndDrag(PointerEventData eventData)
//    {
//        on_sfx.Stop();
//        off_sfx.PlayOneShot(off_sfx.clip);

//        Post_Out.SetActive(true);


//        Time_Dely.SetActive(false);
//        Range_ui.SetActive(false);
//        CA.intensity.value = 0f;
//        Time.timeScale = 1f;


//        Cube_fade.SetActive(false);
//        shadow.SetActive(false);

//        Ray ray = cam.ScreenPointToRay(eventData.position);
//        RaycastHit rayhit;

//        if (this.transform.position.y >= 50)
//        {
//            if (Physics.Raycast(ray, out rayhit, 6))
//            {

//                Instantiate(Triangel, rayhit.point + Vector3.up * 0.5f, Triangel.transform.rotation);

//            }
//        }
//        Ui_main.transform.position = locapos.position;
//        Ui_main.SetActive(true);

//        MMVibrationManager.Haptic(HapticTypes.LightImpact);


//    }





//    private void Update()
//    {
//        if (this.transform.position.y >= 50)
//        {

//            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
//            RaycastHit rayhit1;

//            if (Physics.Raycast(ray, out rayhit1, 6))
//            {
//                Cube_fade.transform.position = rayhit1.point + new Vector3(0, 1f, 0);
//            }
//            else
//            {
//                Cube_fade.SetActive(false);
//                shadow.SetActive(false);
//            }
//        }
//    }



//    public void OnPointerDown(PointerEventData eventData)
//    {
//        Slow_clip.Play();
//        off_sfx.Stop();
//        on_sfx.PlayOneShot(on_sfx.clip);
//    }

//    public void OnPointerUp(PointerEventData eventData)
//    {
//        Slow_clip.Stop();
//        Ui_main.transform.position = locapos.position;
//        Ui_main.SetActive(true);

//        Cube_fade.SetActive(false);
//        shadow.SetActive(false);
//    }
//}
