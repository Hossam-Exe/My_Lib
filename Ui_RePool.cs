using UnityEngine;


public class Ui_RePool : MonoBehaviour, IPooler
{

    
    

   

   
    
    public void OnRePool()
    {

        Invoke("active", 1f);
        


        
       
    }


    

    void active()
    {
        this.gameObject.SetActive(false);
    }


    


}
