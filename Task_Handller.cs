
using UnityEngine;

public class Task_Handller : MonoBehaviour
{
    public GameObject Text_red;
    public GameObject Text_Blue;
    public GameObject Text_Yellow;
    public GameObject Text_Green;
    public GameObject Text_Pink;

    public static int rnd;
    void Start()
    {


        rnd = Random.Range(0, 5);


        if (rnd==0)
        {
            Text_red.SetActive(true);
            Text_Blue.SetActive(false);
            Text_Yellow.SetActive(false);
            Text_Green.SetActive(false);
            Text_Pink.SetActive(false);

        }else if (rnd == 1)
        {
            Text_red.SetActive(false);
            Text_Blue.SetActive(true);
            Text_Yellow.SetActive(false);
            Text_Green.SetActive(false);
            Text_Pink.SetActive(false);
        }
        else if(rnd == 2)
        {
            Text_red.SetActive(false);
            Text_Blue.SetActive(false);
            Text_Yellow.SetActive(true);
            Text_Green.SetActive(false);
            Text_Pink.SetActive(false);
        }
        else if (rnd == 3)
        {
            Text_red.SetActive(false);
            Text_Blue.SetActive(false);
            Text_Yellow.SetActive(false);
            Text_Green.SetActive(true);
            Text_Pink.SetActive(false);
        }
        else if (rnd == 4)
        {
            Text_red.SetActive(false);
            Text_Blue.SetActive(false);
            Text_Yellow.SetActive(false);
            Text_Green.SetActive(false);
            Text_Pink.SetActive(true);
        }
    }

  
}
