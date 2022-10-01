using UnityEngine;

public class Hybrid : MonoBehaviour, IPooler
{
    AudioSource Des_clip;
    public VFX_Pool _vfx_pool;
    public GameObject des_fx;

   // public MeshRenderer model_;

   // public GameObject model_des;

    Collider collid;
    Player_Move _playermov;
    public float curtime;
    public float time = 2f;

    Rigidbody rb;
    public float force = 200f;

    void Awake()
    {


        rb = GetComponent<Rigidbody>();
      //  Des_clip = this.GetComponent<AudioSource>();
        collid = this.GetComponent<SphereCollider>();
        _playermov = FindObjectOfType<Player_Move>();
    }

    private void OnEnable()
    {
        Shape_Enable();
    }
    public void Shape_Enable()
    {
        this.gameObject.SetActive(true);
        //OnRePool();
        collid.enabled = true;
    }


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
           // model_.enabled = true; ;
          //  model_des.SetActive(true);

          //  Des_clip.Play();

            _vfx_pool.Spawning("Des_Fx", transform.position , Quaternion.identity);
            collid.enabled = false;
            curtime = time;
            this.gameObject.SetActive(false);

        }




    }

   
}
