
using UnityEngine;

using UnityEngine.UI;


public class NotSelected : MonoBehaviour
{
   public GameObject TextField;
    RectTransform Local_pos;
    Coin_Shaker shaker;
   
    void Awake()
    {
        Local_pos = this.GetComponent<RectTransform>();
        shaker = this.GetComponent<Coin_Shaker>();
    }


    
    public void NotSelectedFun()
    {

        GameObject obj = Instantiate(TextField, Input.mousePosition, Local_pos.transform.rotation) ;
        
        obj.transform.SetParent(Local_pos.transform);

        Destroy(obj, 1.5f);






        
    }
   
}
