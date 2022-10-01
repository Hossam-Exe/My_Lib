using UnityEngine;

public class Data_Object : MonoBehaviour
{

    public int _bool;


    void Start()
    {
        DontDestroyOnLoad(gameObject);

    }




    void OnDisable()
    {
        Player_Data_Handler.SaveData_skins();


    }
    public void OnApplicationQuit()
    {
        Player_Data_Handler.SaveData_skins();
    }

}
