
using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using MoreMountains.NiceVibrations;

public class menu : MonoBehaviour
{
    public GameObject not_enough_PF;
    public GameObject Level_intro;
    public RectTransform not_enough;
    public TextMeshProUGUI lastscore;
    public RewardSystem _RS;


    

    //Mixers
    public AudioMixer menumixer;
    public AudioMixer menusfx;
    public Animator setdrop;
    public Toggle set;
    public Toggle sfxt;
    public Toggle mfxt;


    //Haptic
    public Toggle Haptic_Tog;

    //quality images
    public Image skulllow;
    public Image skullmed;
    public Image skullhigh;


    [Header("Menu_")]
    // Menu toggle
    public Toggle Play_tog;
    public Toggle Skins_tog;
    public Toggle Setting_tog;
    public Toggle Exit_tog;

    // Menu buttons
    public GameObject Play_obj;
    public GameObject Skins_obj;
    public GameObject Setting_obj;
    public GameObject Exit_obj;

    public TextMeshProUGUI level_intro_text;

    private void Start()
    {
        
        
        lastscore.text = Board.Num1.ToString();  
    }


    public void Menu_selector_play()
    {
        if (Play_tog.isOn == false)
        {
            Play_obj.SetActive(true);
            Skins_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
        else
        {
            Play_obj.SetActive(false);
            Skins_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);

        }

    }

    public void Menu_selector_Skins()
    {
        if (Skins_tog.isOn == false)
        {
            Skins_obj.SetActive(true);
            Play_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
        else
        {
            Play_obj.SetActive(false);
            Skins_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
    }
    public void Menu_selector_Setting()
    {
        if (Setting_tog.isOn == false)
        {
            Setting_obj.SetActive(true);
            Play_obj.SetActive(false);
           Skins_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
        else
        {
            Play_obj.SetActive(false);
            Skins_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
    }
    public void Menu_selector_Exit()
    {
        if (Exit_tog.isOn == false)
        {
            Exit_obj.SetActive(true);
            Play_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Skins_obj.SetActive(false);
        }
        else
        {
            Play_obj.SetActive(false);
            Skins_obj.SetActive(false);
            Setting_obj.SetActive(false);
            Exit_obj.SetActive(false);
        }
    }



    public void sfxtoggle()
    {
        if (sfxt.isOn == true)
        {

            
            
            menusfx.SetFloat("sfx",-80f);
           
        }
        else if (sfxt.isOn == false)
        {
            menusfx.SetFloat("sfx", 0f);
           
         
        }
    }
    public void mfxtoggle()
    {
        if (mfxt.isOn == true)
        {

            
          
             menumixer.SetFloat("mfx", 0f);
        
        }
        else
        {
          
;
              menumixer.SetFloat("mfx", -80f);
          

        }
    }





  

   
    public void setlow()
    {
        skulllow.enabled = true;
        skullmed.enabled = false;
        skullhigh.enabled = false;
        QualitySettings.SetQualityLevel(0);
    }
    public void setmedium()
    {
        skulllow.enabled = false;
        skullmed.enabled = true;
        skullhigh.enabled = false;
        QualitySettings.SetQualityLevel(1);
    }
    public void sethigh()
    {
        skulllow.enabled = false;
        skullmed.enabled = false;
        skullhigh.enabled = true;
        QualitySettings.SetQualityLevel(2);
    }

    public void Haptic_State()
    {
        if (Haptic_Tog.isOn == true)
        {

            MMVibrationManager.SetHapticsActive(false);
         }else
            MMVibrationManager.SetHapticsActive(true);

    }

    public void Haptic_()
    {

        MMVibrationManager.Haptic(HapticTypes.Success);


    }
    public void back()
    {

    }
    public void setclicked()
    {
        if (set.isOn == true)
        {
            setdrop.SetBool("clicked", true);
            //seton.enabled = false;
           // setoff.enabled = true;

        }
        else
        {
           // seton.enabled = true;
//setoff.enabled = false;
            setdrop.SetBool("clicked", false);
        }


    }

    public void play()
    {

        SceneManager.LoadScene(1);
    }
    public void play_endless()
    {
        if (Lives_System.Live_Value >= 1)
        {
            Level_intro.SetActive(true);


            if (First_Time.IsFirstTime == false)
            {
                //StartCoroutine(Load_scene("LVL41"));
                 SceneManager.LoadScene(("LVL41"));
                Lives_System.Live_Value -= 1;


            }
            else
            {
                _RS.RewardRestart();
                Player_Data_Handler.Restart_lives();
                //StartCoroutine(Load_scene("Tut"));
                SceneManager.LoadScene(("Tut"));
            }
           
               


        }
        else if (Lives_System.Live_Value <= 0)
        {
            Level_intro.SetActive(false);
            Ui_Pool.Instance.Spawning("Battery_Required", not_enough.position, Quaternion.identity);
            
        }
    }

    
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void exit()
    {
        Application.Quit();
       
    }
    public void OnApplicationQuit()
    {
        Player_Data_Handler.SaveData();
        Player_Data_Handler.SaveData_skins();
        Player_Data_Handler.SaveData_Traills();
       
    }

    public IEnumerator Load_scene(string SceneName)
    {

        AsyncOperation _async= SceneManager.LoadSceneAsync(SceneName);
       
        while (!_async.isDone)
        {
            float _progress = Mathf.Clamp01(_async.progress/0.9f );
            level_intro_text.text = _progress *100f + "%";
            yield return null;
            StopCoroutine(Load_scene(SceneName));
        }
        
    }
}
