using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drop_Select : MonoBehaviour
{
    private Dropdown Main_Drop;
    public Image Selected_image;
    public Image StockImage;
    void Start()
    {
        Main_Drop = this.GetComponent<Dropdown>();
    }

   
    void Update()
    {
        
    }
}
