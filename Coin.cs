using UnityEngine;

public class Coin : MonoBehaviour
{
    //public GameObject coin_fx;


    //Coin_Shaker shaker;
    //private void Awake()
    //{
        
    //    shaker= GameObject.FindGameObjectWithTag("Coin_shake").GetComponent<Coin_Shaker>();
    //}
    //void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("Sphere") || other.gameObject.CompareTag("Star") ||
    //        other.gameObject.CompareTag("Triangel") || other.gameObject.CompareTag("Shape8") || other.gameObject.CompareTag("Hybrid"))

    //    {
    //        shaker.Shake = true;
            
    //        GameObject Coin_des = Instantiate(coin_fx, transform.position, coin_fx.transform.rotation);
    //        Destroy(Coin_des, 2f);
    //        game_manager.Coin_value += 1f;
    //        this.gameObject.SetActive(false);
    //        Destroy(gameObject, 1f);


    //    }
    //}




    public GameObject coin_fx;


    Coin_Shaker shaker;
    private void Awake()
    {

        shaker = GameObject.FindGameObjectWithTag("Coin_shake").GetComponent<Coin_Shaker>();
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Cube") || other.CompareTag("Sphere") || other.CompareTag("Star") ||
            other.CompareTag("Triangel") || other.CompareTag("Shape8") || other.CompareTag("Hybrid"))

        {
            shaker.Shake = true;

            GameObject Coin_des = Instantiate(coin_fx, transform.position, coin_fx.transform.rotation);
            Destroy(Coin_des, 2f);
            game_manager.Coin_value += 1f;
            this.gameObject.SetActive(false);
            gameObject.SetActive(false);


        }
    }


    private void OnEnable()
    {
        this.gameObject.SetActive(true);
    }

}
