using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterChange : MonoBehaviour
{

    [SerializeField]
    private Sprite[] _images;


    private Image _image;

    private int Rand_Max_Value;

    private int _index;


    void Awake()
    {
        Rand_Max_Value = _images.Length;
       

        _image=this.GetComponent<Image>();
    }

    void OnEnable()
    {
        _index = Random.Range(0, Rand_Max_Value);

        _image.sprite = _images[_index];
    }
}
