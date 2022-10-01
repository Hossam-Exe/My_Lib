using UnityEngine;

public class Score_Shaker : MonoBehaviour
{
    [SerializeField]
    public bool Shake_score;

    [SerializeField]
    private Vector3 Start_Pos;
    [SerializeField]
    private float Shake_Amount;
    [SerializeField]
    private float Shake_Drop_Amount;
    [SerializeField]
    private float Shake_REST;


    private Animator _Animator_score;


    private void Awake()
    {
        Shake_score = false;

        Shake_REST = Shake_Amount;
        Start_Pos = this.transform.localPosition;
        _Animator_score = GameObject.FindGameObjectWithTag("Score_shake").GetComponent<Animator>();

    }


    private void Update()
    {
        #region Pos_Shake

        if (Shake_score == false)
        {
            Shake_Amount = Shake_REST;
            _Animator_score.SetBool("_SHAKE", false);
            Shake_score = false;

        }
        if (Shake_score)
        {

            _Animator_score.SetBool("_SHAKE", true);



            if (Shake_Amount > 0)
            {
                Shake_Amount -= Shake_Drop_Amount * Time.deltaTime;
                Vector3 rand_dir = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1)).normalized;
                transform.localPosition = Start_Pos + rand_dir * Shake_Amount;
            }
            if (Shake_Amount <= 0)
            {
                Shake_score = false;
                _Animator_score.SetBool("_SHAKE", false);

            }
        }
        #endregion



    }

}