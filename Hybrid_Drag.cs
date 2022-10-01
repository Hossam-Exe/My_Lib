
using UnityEngine;
using UnityEngine.EventSystems;


public class Hybrid_Drag : MonoBehaviour, IDragHandler, IEndDragHandler
     , IPointerDownHandler, IPointerUpHandler
{

    public static bool IsReleased;
    public AudioSource on_sfx;
    public AudioSource off_sfx;
    AudioSource Slow_clip;

    private Hybrid_Pool _hybrid_pool;

    public GameObject Cube_fade;
    public GameObject shadow;
    public GameObject Ui_main;
    [SerializeField]
    private LayerMask Mask;

    public GameObject HYBERID_SHAPE;
    Camera cam;
    public RectTransform locapos;

    void Awake()
    {
        _hybrid_pool = FindObjectOfType<Hybrid_Pool>();
        cam = FindObjectOfType<Camera>();
        Slow_clip = this.GetComponent<AudioSource>();

    }




    public void OnDrag(PointerEventData eventData)
    {
        Time.timeScale = 0.7f;

        IsReleased = false;


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
        Time.timeScale = 1f;
        on_sfx.Stop();
        off_sfx.PlayOneShot(off_sfx.clip);

        Cube_fade.SetActive(false);
        shadow.SetActive(false);



        Ray ray = cam.ScreenPointToRay(eventData.position);
        RaycastHit rayhit;


        if (Physics.Raycast(ray, out rayhit))
        {
            _hybrid_pool.Spawning("Hybrid", rayhit.point + Vector3.up * 0.5f, HYBERID_SHAPE.transform.rotation);
            //GameObject des = Instantiate(HYBERID_SHAPE, rayhit.point + Vector3.up * 0.5f, HYBERID_SHAPE.transform.rotation);
           

        }
        Ui_main.transform.position = locapos.position;
        Ui_main.SetActive(true);




    }



    private void Update()
    {
        if (this.transform.position.y >= 50)
        {

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit1;

            if (Physics.Raycast(ray, out rayhit1, Mask))
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
        IsReleased = true;
        Slow_clip.Stop();
        Ui_main.transform.position = locapos.position;
        Ui_main.SetActive(true);
        Cube_fade.SetActive(false);
        shadow.SetActive(false);
    }


}
