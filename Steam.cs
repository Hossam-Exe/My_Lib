
using UnityEngine;

public class Steam : MonoBehaviour
{
    [SerializeField]
    private float _ForceAmount;


    private Rigidbody _rigidbody;
    
   

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.CompareTag( "Cube") || other.gameObject.CompareTag( "Sphere") || other.gameObject.CompareTag("Star") ||
            other.gameObject.CompareTag("Triangel") || other.gameObject.CompareTag("Shape8"))
        {
            _rigidbody = other.gameObject.GetComponent<Rigidbody>();

            _rigidbody.AddForce(_ForceAmount, 0, 0);
           
        }
    }
    
}
