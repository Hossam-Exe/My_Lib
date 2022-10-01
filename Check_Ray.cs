using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Ray : MonoBehaviour
{
    public  bool _isNothing;
    public  Transform _point_spwan;


    void Awake()
    {
        //_isNothing = false;
        //Invoke("Start_Delay", 0.2f);
    }
    private void FixedUpdate()
    {

        
            
            RaycastHit rayhit1;

            if (Physics.Raycast(transform.position,-Vector3.up, out rayhit1))
            {
              if (rayhit1.collider.tag != "Nothing")
                return;
                 if (rayhit1.collider.tag == "Nothing")
                 {
                

                  if(_isNothing == true )
                  {
                    Debug.Log("nothing");

                    Object_Pool.Instance.Spawning("Floor1", _point_spwan.position, Quaternion.identity);
                    _isNothing = false;

                   // StartCoroutine(Re_Delay());
                  }
                
                 }
           
            
            }
            
        
    }

    void Start_Delay()
    {
        _isNothing = true;
    }

    IEnumerator Re_Delay()
    {
        yield return new WaitForSeconds(3);
        if (_isNothing == false)
        {
            _isNothing = true;
            StopCoroutine(Re_Delay());
        }
        
    }
}

   
