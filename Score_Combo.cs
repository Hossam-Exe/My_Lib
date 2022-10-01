using TMPro;
using UnityEngine;
using UnityEngine.UI;

public  class Score_Combo : MonoBehaviour
{
    
    public static int Score_Index = 0;

    public static AudioSource Fx_clip;
   
    public static TextMeshProUGUI Text_Combo;
    public static ParticleSystem Fx;

    public static ParticleSystem Fx2;

    
   
    void Awake()
    {


        

        Text_Combo = GameObject.FindGameObjectWithTag("Combo").GetComponent<TextMeshProUGUI>();
        Fx = GameObject.FindGameObjectWithTag("Combo_Fx").GetComponent<ParticleSystem>();
        Fx_clip = GameObject.FindGameObjectWithTag("Combo_Fx").GetComponent<AudioSource>();
        Fx2 = GameObject.FindGameObjectWithTag("Combo_Fx").GetComponentInChildren<ParticleSystem>();
       
       

    }
   

   public static void Combo_Up()
    {
        Score_Index += 1;
        Score.uiscore += Score_Index;
       

        


    }
    public static void Combo_Down()
    {
        Score_Index = 0;
        Text_Combo.text = (" ");
        Fx.Stop();
    }

    [System.Obsolete]
    public   static void Combo_Fx()    {
        if (Score_Index <= 0)
            return;
        switch (Score_Index)
        {
            case 0:
                Text_Combo.text = (" ");
                Fx.gameObject.SetActive(false);
                Fx.Stop();

                Fx_clip.pitch = 1f;
                Fx_clip.Stop();

                Fx.startColor = Color.clear;
                break;
            case 2:

                Text_Combo.text = ("2X");
                Fx.gameObject.SetActive(true);
                Fx.Play();

                Fx_clip.Play();

                Fx.startColor = Color.cyan;

                break;
            case 3:
                Text_Combo.text = ("3X");
                Fx2.Play();
                Fx_clip.pitch = 1.2f;
                Fx_clip.Play();

                Fx.startColor = Color.green;

                break;
            case 4:
                Text_Combo.text = ("4X");
                Fx2.Play();

                Fx_clip.pitch = 1.5f;
                Fx_clip.Play();
                Fx.startColor = Color.blue;
                break;
            case 5:
                Text_Combo.text = ("5X");
                Fx2.Play();
                Fx_clip.pitch = 1.8f;
                Fx_clip.Play();
                Fx.startColor = Color.red;
                break;

           
        }
    }
}
