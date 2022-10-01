
using UnityEngine;
using TMPro;

public class Indicator_Quest : MonoBehaviour
{
    private Quest_Cube quest;
    private TextMeshProUGUI text;
    void Awake()
    {

        text = this.GetComponent<TextMeshProUGUI>();
        quest = GameObject.FindObjectOfType<Quest_Cube>();
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
        }
        else

            text.text = quest.Target.ToString();
    }
}
