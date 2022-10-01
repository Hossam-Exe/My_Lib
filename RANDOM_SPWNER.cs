using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM_SPWNER : MonoBehaviour
{


    public  GameObject [] Prefabs;
    public Transform[] Spwan_List;

    public void rand()
    {
        int index_Prefabs = Random.Range(0, Prefabs.Length);

        int index_Spwan_List = Random.Range(0, Spwan_List.Length);

        
            Instantiate(Prefabs[index_Prefabs], Spwan_List[index_Spwan_List].position, Quaternion.identity);
       
            
                
            
        

       
               
            
                
                        
        
           
       
        

    }
}
