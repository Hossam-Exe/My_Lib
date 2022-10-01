
using UnityEngine;
using TMPro;

public class Indicator_Quest_Sphere : MonoBehaviour
{
    private Quest_Sphere quest;
    private TextMeshProUGUI text;
    void Awake()
    {
        
        quest = GameObject.FindObjectOfType<Quest_Sphere>();
        text = this.GetComponent<TextMeshProUGUI>();
    }

   
    void Update()
    {
        if (quest == null)
            return;


        if (quest.Target > 0)
        {
            text.enabled = true;
        }

            if (quest.Target <= 0)
        {
            text.enabled = false;
            return;
        }else
        
        text.text = quest.Target.ToString();
    }
}
