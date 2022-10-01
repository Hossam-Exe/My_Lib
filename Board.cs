using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Board : MonoBehaviour
{
    public static Board Instance;

    public static float _curscore;
    public static float Num1 = 0;
    public static float Num2 = 0;
    public static float Num3 = 0;
    public static float Num4 = 0;

    public TextMeshProUGUI end1_text;
    public TextMeshProUGUI end2_text;
    public TextMeshProUGUI end3_text;
    public TextMeshProUGUI end4_text;

    private void Awake()
    {
        Instance = this;
       
    }
    void Start()
    {

        Player_Data_Handler.LoadScore();








        

        if (_curscore <= Num1 && _curscore <= Num2 && _curscore <= Num3)
        {
            Num4 = _curscore;
            end4_text.text = Num4.ToString();
        }
        else


        if (_curscore <= Num1 && _curscore <= Num2)
        {
            Num3 = _curscore;
            end3_text.text = Num3.ToString();
        }else

        if (_curscore <= Num1)
        {
            Num2 = _curscore;
            end2_text.text = Num2.ToString();
        }
        else

        if (_curscore >= Num1)
        {
            Num1 = _curscore;
            end1_text.text = Num1.ToString();
        }
        


        end1_text.text = Num1.ToString();
        end2_text.text = Num2.ToString();
        end3_text.text = Num3.ToString();
        end4_text.text = Num4.ToString();





        Player_Data_Handler.SaveScore();


    }

   

}
