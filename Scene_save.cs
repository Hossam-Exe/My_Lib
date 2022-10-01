using UnityEngine;

public class Scene_save : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Player_Data_Handler.LoadData_scene();
    }



    public void OnApplicationQuit()
    {

        Player_Data_Handler.SaveData_scene();
    }
}
