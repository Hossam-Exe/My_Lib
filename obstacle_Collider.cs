using EZCameraShake;
using MoreMountains.NiceVibrations;
using System.Collections;
using UnityEngine;

public class obstacle_Collider : MonoBehaviour
{
  

    private Quest_Cube quest;
    public VFX_Pool _vfx_pool;

    Ui_Pool_Combo _Sky_pool;

    private Transform _point;

    Score_Shaker shaker;
    [Header("Audio")]
    public AudioSource wrong_clip;
    AudioSource Hit_clip;

    [Header("Prefab")]
    game_manager G_M;
    Player_Move _playermov;
    Collider Cube;
    public GameObject enter_fx;

    public GameObject Destroy_main_fx;
    public GameObject main_prefab;
    public GameObject model_des;
    public GameObject model_;

    public GameObject smash_fx;



    //Cor
    WaitForSeconds _wait_smasher;
    WaitForSeconds _wait_time;
    void Awake()
    {

        _wait_time = new WaitForSeconds(0.01f);
        _wait_smasher = new WaitForSeconds(0.2f);

        _Sky_pool = FindObjectOfType<Ui_Pool_Combo>();
        _point = GameObject.FindGameObjectWithTag("Sky_Point").GetComponent<Transform>();


        G_M = FindObjectOfType<game_manager>();
        _playermov = FindObjectOfType<Player_Move>();
        Hit_clip = this.GetComponent<AudioSource>();
        shaker = GameObject.FindGameObjectWithTag("Score_shake").GetComponent<Score_Shaker>();
        Cube = this.GetComponent<BoxCollider>();
        

        quest = GameObject.FindObjectOfType<Quest_Cube>();
    }




    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Cube"))
        {
            Hit();

            Destroy_eff();
            
           

            //Score Combo 
            Score_Combo.Combo_Up();
            Score_Combo.Combo_Fx();


            Score._ScoreUp();

            _Sky_pool.Spawning("Sky_Combo", _point.position);

            if(Score_Combo.Score_Index>0)
           

            if (quest != null)

            {
                quest.questfun();
            }

        }


        if
   (other.CompareTag("Sphere") || other.CompareTag("Star") || other.CompareTag("Triangel") || other.CompareTag("Shape8"))
        {
            wrong_clip.Play();
            CameraShaker.Instance.ShakeOnce(4f, 4f, 1f, 1f);
            G_M.damage();

            _vfx_pool.Spawning("Wrong", transform.position, Destroy_main_fx.transform.rotation);
            
           
            Cube.isTrigger = false;
            MMVibrationManager.Haptic(HapticTypes.HeavyImpact);
            Destroy_eff();

            //Score Combo 
            Score_Combo.Combo_Down();



        }
        if (other.CompareTag("Hybrid"))
        {
            Hit();
            MMVibrationManager.Haptic(HapticTypes.Success);
            Destroy_eff();

            Score._ScoreUp();
        }

        if (other.CompareTag("Smash"))
        {
            CameraShaker.Instance.ShakeOnce(1f, 1f, 1f, 1f);
            StartCoroutine(smasher());
        }



    }
    //Cleaner
    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Obstacle"))
        {

            Destroy_eff();
        }
    }
    public void Destroy_eff()
    {

        model_.SetActive(false);
        model_des.SetActive(true);
        Cube.enabled = false;


        _playermov.CurTimeCheck = _playermov.TimeCheck;

    }
    public void Hit()
    {

        shaker.Shake_score = true;
        Hit_clip.Play();


        _vfx_pool.Spawning("Enter", transform.position, enter_fx.transform.rotation);
        

        StartCoroutine(Time_Cor());
        IEnumerator Time_Cor()
        {


            Time.timeScale = 0.1f;
            yield return _wait_time;

            Time.timeScale = 1f;
        }

    }
    public IEnumerator smasher()
    {

        GameObject destroy2 = Instantiate(smash_fx, transform.position, smash_fx.transform.rotation);
        Destroy(destroy2, 2f);
        Destroy_eff();
        Time.timeScale = 0.4f;
        yield return _wait_smasher;

        Time.timeScale = 1f;
    }
    void OnDestroy()
    {
        Time.timeScale = 1f;
    }

    private void OnEnable()
    {
        Cube.isTrigger = true;
        model_.SetActive(true);
        model_des.SetActive(false);
        Cube.enabled = true;
    }



}
