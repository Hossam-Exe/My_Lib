using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins_layer : MonoBehaviour
{

    public MeshRenderer Rubice;
    public MeshRenderer Dice;
    public MeshRenderer beach;
    public MeshRenderer ball8;
    public MeshRenderer foot;
   





    void Update()
    {
        if (this.transform.position.y>= 300)
        {
               Rubice.enabled=false;
         }else
            Rubice.enabled = true;


        if (this.transform.position.y >= 370)
        {
            Dice.enabled = false;
        }
        else
            Dice.enabled = true;

        if (this.transform.position.y >= 420)
        {
            beach.enabled = false;
        }
        else
            beach.enabled = true;

        if (this.transform.position.y >= 470)
        {
            ball8.enabled = false;
        }
        else
            ball8.enabled = true;

        if (this.transform.position.y >= 520)
        {
            foot.enabled = false;
        }
        else
            foot.enabled = true;


       

    }
}
