using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class Restart_Timer : MonoBehaviour
{
    public UnityEvent _Event;
    public void Restart_()

    {
        _Event.Invoke();
        SceneManager.LoadScene(0);

    }



}

