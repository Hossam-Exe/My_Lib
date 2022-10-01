using EZCameraShake;
using MoreMountains.NiceVibrations;
using System.Collections;
using UnityEngine;

public class obstacle_Sphere : MonoBehaviour
{
  

    Quest_Sphere quest;
    public VFX_Pool _vfx_pool;

    Ui_Pool_Combo _Sky_pool;

    private Transform _point;

    [Header("Audio")]
    public AudioSource wrong_clip;
    AudioSource Hit_clip;
    Score_Shaker shaker;
    [Header("Prefab")]
    game_manager G_M;
    Collider Sphere;
    public GameObject enter_fx;
    public GameObject Destroy_main_fx;
    public GameObject main_prefab;
    public GameObject model_des;
    public GameObject model_;

    public GameObject smash_fx;
    Player_Move _playermov;

    public bool ostacle;

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
        Hit_clip = this.GetComponent<AudioSource>();
        _playermov = FindObjectOfType<Player_Move>();
        Sphere = this.GetComponent<BoxCollider>();
        quest = quest = GameObject.FindObjectOfType<Quest_Sphere>();
        shaker = GameObject.FindGameObjectWithTag("Score_shake").GetComponent<Score_Shaker>();
    }





    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Sphere"))
        {
            Hit();

            Destroy_eff();

            
            //Score Combo 
            Score_Combo.Combo_Up();
            Score_Combo.Combo_Fx();


            Score._ScoreUp();

            _Sky_pool.Spawning("Sky_Combo", _point.position);

            if (quest != null)

            {
                quest.questfun();
            }
        }

        if
   (other.CompareTag("Cube") || other.CompareTag("Star") || other.CompareTag("Triangel") ||
        other.CompareTag("Shape8"))
        {
            wrong_clip.Play();
            CameraShaker.Instance.ShakeOnce(4f, 4f, 1f, 1f);
            G_M.damage();
            _vfx_pool.Spawning("Wrong", transform.position, Destroy_main_fx.transform.rotation);
            Sphere.isTrigger = false;
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
        Sphere.enabled = false;

        _playermov.CurTimeCheck = _playermov.TimeCheck;
    }
    public void Hit()
    {
        shaker.Shake_score = true;

        StartCoroutine(Time_Cor());
        IEnumerator Time_Cor()
        {


            Time.timeScale = 0.1f;
            yield return _wait_time;

            Time.timeScale = 1f;
        }
        Hit_clip.Play();


        _vfx_pool.Spawning("Enter", transform.position, enter_fx.transform.rotation);

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
        Sphere.isTrigger = true;
        model_.SetActive(true);
        model_des.SetActive(false);
        Sphere.enabled = true;
    }


}
