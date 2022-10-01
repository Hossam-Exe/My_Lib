
using UnityEngine;

public  class Coin_Shaker : MonoBehaviour
{
    [SerializeField]
    public  bool Shake;
  
    [SerializeField]
    private Vector3 Start_Pos;
    [SerializeField]
    private float Shake_Amount;
    [SerializeField]
    private float Shake_Drop_Amount;
    [SerializeField]
    private float Shake_REST;


    private Animator _Animator_coin;
   

    private void Awake()
    {
        Shake = false;
       
        Shake_REST = Shake_Amount;
        Start_Pos = this.transform.localPosition;
        _Animator_coin = GameObject.FindGameObjectWithTag("Coin_shake").GetComponent<Animator>();
      
    }
    

    private void Update()
    {
        #region Pos_Shake

        if (Shake == false)
        {
            Shake_Amount = Shake_REST;
            _Animator_coin.SetBool("_SHAKE", false);
            Shake = false;

        }
        if (Shake)
        {

            _Animator_coin.SetBool("_SHAKE", true);



            if (Shake_Amount > 0)
            {
                Shake_Amount -= Shake_Drop_Amount * Time.deltaTime;
                Vector3 rand_dir = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1)).normalized;
                transform.localPosition = Start_Pos + rand_dir * Shake_Amount;
            }
            if (Shake_Amount <= 0)
            {
                Shake = false;
                _Animator_coin.SetBool("_SHAKE", false);

            }
        }
        #endregion

        

    }

}
