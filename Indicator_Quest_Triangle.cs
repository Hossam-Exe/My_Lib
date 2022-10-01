
using UnityEngine;
using TMPro;

public class Indicator_Quest_Triangle : MonoBehaviour
{
    private Quest_Triangle quest;
    private TextMeshProUGUI text;
    void Awake()
    {
        quest = GameObject.FindObjectOfType<Quest_Triangle>();
        text = this.GetComponent<TextMeshProUGUI>();
    }

   
    void Update()
    {
        if (quest == null)
            return;

        if (quest.Target > 0)
        {
            text.enabled=true;
          
        }

            if (quest.Target <= 0)
        {
            text.enabled = false;
            return;
        }else
        
        text.text = quest.Target.ToString();
    }
}
