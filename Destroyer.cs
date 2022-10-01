using UnityEngine;


public class Destroyer : MonoBehaviour {



    //   bool isObjDestoy = false;

    //   private void OnBecameInvisible()
    //{
    //	if (isObjDestoy)
    //	{
    //		Destroy (transform.root.gameObject, 5f);

    //	}
    //   }

    //   private void OnBecameVisible()
    //{
    //	isObjDestoy = true;
    //}


    bool isObjDestoy = false;

    private void OnBecameInvisible()
    {

        //Invoke("ReDisable", 1f);
        //if (isObjDestoy)
        //{


        //}
        //else


    }

    private void OnBecameVisible()
    {


        //isObjDestoy = true;


       //ReEable();

    }


    void ReEable()
    {

        transform.root.gameObject.SetActive(true);
        isObjDestoy = false;

    }
    void ReDisable()
    {

        transform.root.gameObject.SetActive(false);


    }
}
