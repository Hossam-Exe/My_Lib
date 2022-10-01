
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [Header("-------------")]
    
    public TextMeshProUGUI TextField;
    float _CurTime;
    [Space]
    [Header("-------------")]
    [SerializeField]
    float _TimeInMin = 5;

    
    void Awake()
    {
        TextField = this.GetComponent<TextMeshProUGUI>();
        _CurTime = _TimeInMin;
       

    }


    void Update()
    {
        _CurTime -= 1 * Time.deltaTime;


        if (_CurTime<=0)
        {
            _CurTime = _TimeInMin;
            Lives_System.Live_Value += 1;
        }
        TimeFun();

    }


    void TimeFun()
    {
        float Hours = (int)_CurTime / 3600 %24 ;
        float Min = (int)_CurTime / 60 % 60;
        float sec = (int)_CurTime%60;

        string s1 = string.Format("{0:h H}", Hours.ToString());
        string s2 = string.Format("{0:m mm}", Min.ToString());
        string s3 = string.Format("{0:s ss}", sec.ToString());
        TextField.text = s1 + "  :  " + s2 + "  :  " + s3;

    }


}
    
