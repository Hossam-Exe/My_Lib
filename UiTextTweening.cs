 using System.Collections;
using UnityEngine;
using TMPro;



public class UiTextTweening : MonoBehaviour,IPooler
{


    [SerializeField]
    float Delay;

    public Animator _ainm;

    void Start()
    {
        
    }
    void OnEnable()
    {
        _ainm.SetInteger("_rand", Random.Range(0, 4));
       
    }


    void _collider()
    {
       
    }

    void _delay()
    {


        

        this.gameObject.SetActive(false);
        
    }

    public void OnRePool()
    {
        Invoke("_delay", Delay);
       
    }
}
