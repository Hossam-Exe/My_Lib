
using UnityEngine;

public class PS_Play_On : MonoBehaviour
{
    public ParticleSystem _particle_system;
    private void Start()
    {
        //_particle_system = this.GetComponent<ParticleSystem>();
    }

    private void OnEnable()
    {
        _particle_system.Play();
    }
}
