
using UnityEngine;

public class Screen_Setting : MonoBehaviour
{
    private void Start()
    {

        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
        
        Screen.SetResolution(Screen.width,Screen.height, true);
        
       
    }
}
