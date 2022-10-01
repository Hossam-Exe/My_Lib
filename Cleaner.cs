using UnityEngine;

public class Cleaner : MonoBehaviour
{
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Next"))
        {
            
             other.transform.root.gameObject.SetActive(false);
             
           
        }
    }
   

   
}
