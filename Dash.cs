using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dash : MonoBehaviour
{
    private Camera cam;
    public Transform Tran_Point;
    private Shape_Main main_script;
    public GameObject Pointer_ui;
    public GameObject dash_eff;
    private float Distance_abs;
    [SerializeField]
    private float Dash_Force=300f;

 
 
    private void Start()
    {
      
        cam = FindObjectOfType<Camera>();
        main_script = this.GetComponent<Shape_Main>();
        Pointer_ui.SetActive(false);
    }

   

    private void Update()
    {
      //float distance=  Tran_Point.position.magnitude - this.transform.position.magnitude;
      //  Distance_abs = Mathf.Abs(distance);
      //  if (Distance_abs >= 0.3f)
      //  {
           
      //  }
      //  else
           

           
        
        

        if (Input.GetMouseButton(0))
        {

            Time.timeScale = 0.3f;

          
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;

            if (Physics.Raycast(ray, out rayhit))
            {
                Tran_Point.position = rayhit.point;
                transform.LookAt(Tran_Point);

                Pointer_ui.SetActive(true);
            }






        }
        else
            if (Input.GetMouseButtonUp(0))
        {
            Time.timeScale = 1f;
            GameObject obj = Instantiate(dash_eff, transform.position,Quaternion.identity);

            Destroy(obj, 1f);
            main_script.rb.AddForce(transform.forward * Dash_Force);
            Pointer_ui.SetActive(false);
           
        }

        


    }
}
