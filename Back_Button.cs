using UnityEngine.Events;
using UnityEngine;

public class Back_Button : MonoBehaviour
{
    public UnityEvent Home_Button;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            this.gameObject.SetActive(false);
            Home_Button.Invoke();
        }
    }
}
