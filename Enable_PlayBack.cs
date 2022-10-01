using System.Collections;
using UnityEngine;


public class Enable_PlayBack : MonoBehaviour
{
     public GameObject One;
     public GameObject Two;

    void Awake()
    {

        StartCoroutine(_Start());
    }


    IEnumerator _Start() {


        One.SetActive(true);
        
        yield return new WaitForSecondsRealtime(1f);
        One.SetActive(false);
        StopCoroutine(_Start());
       

    }



    }
