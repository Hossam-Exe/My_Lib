using UnityEngine;


public class VFX_RePool : MonoBehaviour, IPooler
{


    private void Start()
    {
        Invoke("active", 2f);
    }





    public void OnRePool()
    {

        Invoke("active", 1f);
        


        
       
    }


    

    void active()
    {
        this.gameObject.SetActive(false);
    }


    


}
