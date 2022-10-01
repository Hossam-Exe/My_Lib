using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch_Handler : MonoBehaviour
{
    [SerializeField]
    private float Time=0.5f;
    private void OnEnable()
    {
        StartCoroutine(reuse());
    }
    private void OnDisable()
    {
        StopCoroutine(reuse());
    }
    IEnumerator reuse()
    {
        this.gameObject.SetActive(true);
        yield return new WaitForSeconds(Time);
        this.gameObject.SetActive(false);
    }
}
