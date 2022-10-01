using UnityEngine;

using System.Collections;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Shape_Pool : MonoBehaviour, IPooler
{
    public VFX_Pool _vfx_pool;
    public GameObject WallHit;

    AudioSource Des_clip;

    public GameObject des_fx;

    MeshRenderer model_;

    public GameObject model_des;

    public Collider collid;

    public float curtime;
    public float time = 2f;

    Player_Move _playermov;
    public Rigidbody rb;
    public float force = 200f;

    Vector3 Fx_up;
    public VolumeProfile pro;
   // private Bloom b;

    WaitForSeconds _wait_glow;
    WaitForSeconds _wait_delay;
    void Awake()
    {
        Fx_up = new Vector3(0, .5f, 0);
        _wait_glow = new WaitForSeconds(0.1f);
        _wait_delay = new WaitForSeconds(3f);

        _playermov = FindObjectOfType<Player_Move>();

      //  pro.TryGet(out b);

        rb = this.GetComponent<Rigidbody>();
        Des_clip = this.GetComponent<AudioSource>();
        model_ = this.GetComponentInChildren<MeshRenderer>();
        


    }

    private void OnEnable()
    {
        Shape_Enable();
    }
    public  void Shape_Enable()
    {
        this.gameObject.SetActive(true);
        model_.enabled = true; ;
        model_des.SetActive(false);
        collid.enabled = true;
    }

    //private void OnDisable()
    //{
    //   
    //}
    
    public void OnRePool()
    {

       
        curtime = time;
        _playermov.CurTimeCheck = _playermov.TimeCheck;
        //re
        if (_playermov.speed >= 3)
        {
            rb.AddForce(Vector3.forward * -force * 1.2f);
        }
        else if (_playermov.speed >= 4)
        {
            rb.AddForce(Vector3.forward * -force * 1.3f);
        }
        else if (_playermov.speed >= 5)
        {
            rb.AddForce(Vector3.forward * -force * 1.4f);
        }
        else if (_playermov.speed >= 6)
        {
            rb.AddForce(Vector3.forward * -force * 1.6f);
        }
        else
            rb.AddForce(Vector3.forward * -force);


        
       
    }


    




    void Update()
    {

        curtime -= 1 * Time.deltaTime;

        if (curtime <= 0f)
        {
            model_.enabled = false; ;
            model_des.SetActive(true);
            collid.enabled = false;
            Des_clip.Play();

            _vfx_pool.Spawning("Des_Fx", transform.position+Fx_up, des_fx.transform.rotation);
           // GameObject des_fxg = Instantiate(des_fx, transform.position, des_fx.transform.rotation);
           
            curtime = time;
           
            StartCoroutine(Delay());
        }



    }
    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Obs"))
        {
            model_.enabled = false; ;
            model_des.SetActive(true);

            Des_clip.Play();

            _vfx_pool.Spawning("Des_Fx", transform.position + Fx_up, des_fx.transform.rotation);
            collid.enabled = false;
            curtime = time;
           
          
        }


        if (other.CompareTag("Wall"))
        {
            StartCoroutine(glow());
            GameObject Obj = Instantiate(WallHit, transform.position, WallHit.transform.rotation);

            Destroy(Obj, 1f);
            
            

        }

    }
    IEnumerator glow()
    {

     //   b.threshold.value = 0f;

        yield return _wait_glow;
       // b.threshold.value = 3f;

    }
    IEnumerator Delay()
    {
        yield return _wait_delay;
        this.gameObject.SetActive(false);
        StopCoroutine(Delay());

    }


}
