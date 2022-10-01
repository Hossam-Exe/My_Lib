using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PS_COLOR : MonoBehaviour
{
    public ParticleSystem _PS;
    public Image _blur_image;
    public ParticleSystem _PS2;
    public Image _blur_image2;
    public Gradient [] _color;
    public Color _image_color1;
    public Color _image_color2;
    public Color _image_color3;
    public Color _image_color4;
    int _rand;



    public Gradient _speed_up_gradient;
    public Color _image_color_speed;

    public bool _isSpeed;
    void Start()
    {
       


        


        InvokeRepeating("_delay", 3, 10);
;    }

    

    public void _delay()
    {
        if (_isSpeed == false)
        {
            _rand = Random.Range(0, _color.Length);

            switch (_rand)
            {
                case 0:
                    _blur_image.color = _image_color1;
                    _blur_image2.color = _image_color1;
                    break;
                case 1:
                    _blur_image.color = _image_color2;
                    _blur_image2.color = _image_color2;
                    break;
                case 2:
                    _blur_image.color = _image_color3;
                    _blur_image2.color = _image_color3;
                    break;
                case 3:
                    _blur_image.color = _image_color4;
                    _blur_image2.color = _image_color4;
                    break;
                default:
                    break;
            }


            var _main = _PS.main;
            var _main2 = _PS2.main;
            _main.startColor = _color[_rand];
            _main2.startColor = _color[_rand];
        }
       
    }

    public  void _speed_up()
    {
        if (_isSpeed == true)
        {
            var _main = _PS.main;
            var _main2 = _PS2.main;
            _blur_image.color = _image_color_speed;
            _blur_image2.color = _image_color_speed;
            _main.startColor = _speed_up_gradient;
            _main2.startColor = _speed_up_gradient;
        }
    }

}
