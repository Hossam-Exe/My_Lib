
using UnityEngine;

public class Ui_WorldSpace_Cam : MonoBehaviour
{


    private Canvas _canvas;

    private Camera _camera;

    void Start()
    {
        _camera = Camera.main.GetComponent<Camera>();
        _canvas = this.GetComponent<Canvas>();
        _canvas.worldCamera = _camera;



    }

}

