using System.Collections;

using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Menu_Post : MonoBehaviour
{

    public VolumeProfile pro;
    private ChromaticAberration CA;
    private LensDistortion LD;
    [SerializeField]
    private float time;


    WaitForSeconds _wait_post;

    private void Start()
    {

        _wait_post = new WaitForSeconds(time);

        pro.TryGet(out CA);
        pro.TryGet(out LD);
        
    }
    private void OnEnable()
    {
        PostFun();
    }
    private void Update()
    {
        if (LD.intensity.value>=-0.6f)
        {
            LD.intensity.value -= 0.6f *5f* Time.deltaTime;
        }




        CA.intensity.value = Random.Range(0f, 1f);
    }
    public void PostFun()
    {
        StartCoroutine(PostCor());
        
    }

    IEnumerator PostCor()
    {

        
        this.gameObject.SetActive(true);
        yield return _wait_post;
        
        this.gameObject.SetActive(false);
        

    }
    private void OnDisable()
    {

        LD.intensity.value = 0f;
        CA.intensity.value = 0f;
        StopCoroutine(PostCor());
    }
}

