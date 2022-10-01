
using UnityEngine;

public class First_Time : MonoBehaviour
{
    public static bool IsFirstTime=true;

    


    void Awake()
    {
        Player_Data_Handler.LoadFirstTime();
        

    }
   

}
