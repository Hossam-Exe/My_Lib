
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.PostProcessing;

[CreateAssetMenu]
public class DS_SO : ScriptableObject
{
    AudioSource Slow_clip;

    public GameObject Cube_fade;
    public GameObject shadow;
    public GameObject Ui_main;
    PostProcessVolume volume;

    ChromaticAberration post;

    public GameObject Cube;
    public GameObject box;
    public GameObject dice;
    public GameObject rubic;
    public GameObject lego;

    public static bool isbox = false;
    public static bool isdice = false;
    public static bool isrupic = false;
    public static bool islego = false;

    Camera cam;
    public RectTransform locapos;


    void Awake()
    {
        //volume = FindObjectOfType<PostProcessVolume>();
        cam = FindObjectOfType<Camera>();
        Slow_clip = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();


    }
 




    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    transform.position = locapos.position;
    //}


    //public void OnPointerDown(PointerEventData eventData)
    //{

    //}
}
