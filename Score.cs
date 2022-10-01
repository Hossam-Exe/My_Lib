
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    


    public static TextMeshProUGUI _Score;
    public static float uiscore = 0;
    
    
    void Start()
    {
        _Score = this.GetComponent<TextMeshProUGUI>();

        uiscore = 0;


    }

   

    public static void _ScoreUp()
    {
        uiscore += 1;
        _Score.text = uiscore.ToString("0");
        
    }


}
