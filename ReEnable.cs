
using UnityEngine;

public class ReEnable : MonoBehaviour
{

    [Header("Time")]
    [SerializeField]
    private float Time_Amount;



    void OnEnable()
    {
        Invoke("_ReEnable",Time_Amount);
    }


    void _ReEnable()
    {
        this.gameObject.SetActive(false);
    }

}
