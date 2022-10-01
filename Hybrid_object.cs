using UnityEngine;

public class Hybrid_object : MonoBehaviour
{
    game_manager G_M;
    public GameObject Destroy_main_fx;
    public GameObject main_obj;
    void Start()
    {
        G_M = FindObjectOfType<game_manager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Sphere") || other.gameObject.CompareTag("Cube") ||
            other.gameObject.CompareTag("Triangel") || other.gameObject.CompareTag("Shape8") || other.gameObject.CompareTag("Star"))
        {
            G_M.Hybrid = true;
            GameObject destroy = Instantiate(Destroy_main_fx, transform.position, Destroy_main_fx.transform.rotation);
            Destroy(destroy, 1f);
            Destroy(main_obj);
           game_manager.life_value += 1;
        }


    }
}
