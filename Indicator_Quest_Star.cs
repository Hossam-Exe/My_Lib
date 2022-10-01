
using UnityEngine;
using TMPro;

public class Indicator_Quest_Star : MonoBehaviour
{
    private Quest_Star quest;
    private TextMeshProUGUI text;
    void Awake()
    {
        quest = GameObject.FindObjectOfType<Quest_Star>();
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
