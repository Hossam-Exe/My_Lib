using TMPro;
using UnityEngine;


public class Skins_scriptTwo : MonoBehaviour
{

    public RectTransform not_enough;
    public GameObject not_enough_PF;
   

    [Header("Gradient")]

    public GameObject Gradient1_price;
    public GameObject Gradient1_owned;

    public GameObject Gradient2_price;
    public GameObject Gradient2_owned;

    public GameObject Gradient3_price;
    public GameObject Gradient3_owned;

    public GameObject Gradient4_price;
    public GameObject Gradient4_owned;

    public GameObject Gradient5_price;
    public GameObject Gradient5_owned;

    public GameObject Gradient6_price;
    public GameObject Gradient6_owned;

    public GameObject Gradient7_price;
    public GameObject Gradient7_owned;

    public GameObject Gradient8_price;
    public GameObject Gradient8_owned;

    public GameObject Gradient9_price;
    public GameObject Gradient9_owned;

    public GameObject Gradient10_price;
    public GameObject Gradient10_owned;


    [Header("Lgend")]

    public GameObject Snow_price;
    public GameObject Snow_owned;

    public GameObject Dust_price;
    public GameObject Dust_owned;

    public GameObject Lighting_price;
    public GameObject Lighting_owned;

    public GameObject FireBall_price;
    public GameObject FireBall_owned;

    



    #region Gradient one  Fun
    
    public void Gradient1_Fun()
    {
        if (game_manager.Coin_value < 5000f && Main_Traills.Gradient_1 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient1_owned.SetActive(false);
        }
           

        if (game_manager.Coin_value >= 5000f && Main_Traills.Gradient_1 == false)
        {
            game_manager.Coin_value -= 5000f;
            Main_Traills.Gradient_1 = true;
            Gradient1_owned.SetActive(true);
            Gradient1_price.SetActive(false);

        }

    }
    public void Gradient2_Fun()
    {
        if (game_manager.Coin_value < 5000f && Main_Traills.Gradient_2 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient2_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 5000f && Main_Traills.Gradient_2 == false)
        {
            game_manager.Coin_value -= 5000f;
            Main_Traills.Gradient_2 = true;
            Gradient2_owned.SetActive(true);
            Gradient2_price.SetActive(false);

        }

    }
    public void Gradient3_Fun()
    {
        if (game_manager.Coin_value < 5000f && Main_Traills.Gradient_3 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient3_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 5000f && Main_Traills.Gradient_3 == false)
        {
            game_manager.Coin_value -= 5000f;
            Main_Traills.Gradient_3 = true;
            Gradient3_owned.SetActive(true);
            Gradient3_price.SetActive(false);

        }

    }
    public void Gradient4_Fun()
    {
        if (game_manager.Coin_value < 5000f && Main_Traills.Gradient_4 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient4_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 5000f && Main_Traills.Gradient_4 == false)
        {
            game_manager.Coin_value -= 5000f;
            Main_Traills.Gradient_4 = true;
            Gradient4_owned.SetActive(true);
            Gradient4_price.SetActive(false);

        }

    }
    public void Gradient5_Fun()
    {
        if (game_manager.Coin_value < 5000f && Main_Traills.Gradient_5 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient5_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 5000f && Main_Traills.Gradient_5 == false)
        {
            game_manager.Coin_value -= 5000f;
            Main_Traills.Gradient_5 = true;
            Gradient5_owned.SetActive(true);
            Gradient5_price.SetActive(false);

        }

    }


    #endregion

    #region Gradient Two  Fun

    public void Gradient6_Fun()
    {
        if (game_manager.Coin_value < 7000f && Main_Traills.Gradient_6 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient6_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 7000f && Main_Traills.Gradient_6 == false)
        {
            game_manager.Coin_value -= 7000f;
            Main_Traills.Gradient_6 = true;
            Gradient6_owned.SetActive(true);
            Gradient6_price.SetActive(false);

        }

    }
    public void Gradient7_Fun()
    {
        if (game_manager.Coin_value < 7000f && Main_Traills.Gradient_7 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient7_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 7000f && Main_Traills.Gradient_7 == false)
        {
            game_manager.Coin_value -= 7000f;
            Main_Traills.Gradient_7 = true;
            Gradient7_owned.SetActive(true);
            Gradient7_price.SetActive(false);

        }

    }

    public void Gradient8_Fun()
    {
        if (game_manager.Coin_value < 7000f && Main_Traills.Gradient_8 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient8_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 7000f && Main_Traills.Gradient_8 == false)
        {
            game_manager.Coin_value -= 7000f;
            Main_Traills.Gradient_8 = true;
            Gradient8_owned.SetActive(true);
            Gradient8_price.SetActive(false);

        }

    }

    public void Gradient9_Fun()
    {
        if (game_manager.Coin_value < 7000f && Main_Traills.Gradient_9 == false)
        {
             Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient9_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 7000f && Main_Traills.Gradient_9 == false)
        {
            game_manager.Coin_value -= 7000f;
            Main_Traills.Gradient_9 = true;
            Gradient9_owned.SetActive(true);
            Gradient9_price.SetActive(false);

        }

    }

    public void Gradient10_Fun()
    {
        if (game_manager.Coin_value < 7000f && Main_Traills.Gradient_10 == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient10_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 7000f && Main_Traills.Gradient_10 == false)
        {
            game_manager.Coin_value -= 7000f;
            Main_Traills.Gradient_10 = true;
            Gradient10_owned.SetActive(true);
            Gradient10_price.SetActive(false);

        }

    }

    #endregion

    #region Lgend  Fun

    public void Snow_Fun()
    {
        if (game_manager.Coin_value < 9000f && Main_Traills.Snow == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Snow_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 9000f && Main_Traills.Snow == false)
        {
            game_manager.Coin_value -= 9000f;
            Main_Traills.Snow = true;
            Snow_owned.SetActive(true);
            Snow_price.SetActive(false);

        }

    }

    public void Dust_Fun()
    {
        if (game_manager.Coin_value < 9000f && Main_Traills.Dust == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Dust_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 9000f && Main_Traills.Dust == false)
        {
            game_manager.Coin_value -= 9000f;
            Main_Traills.Dust = true;
            Dust_owned.SetActive(true);
            Dust_price.SetActive(false);

        }

    }

    public void Lighting_Fun()
    {
        if (game_manager.Coin_value < 9000f && Main_Traills.Lighting == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Lighting_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 9000f && Main_Traills.Lighting == false)
        {
            game_manager.Coin_value -= 9000f;
            Main_Traills.Lighting = true;
            Lighting_owned.SetActive(true);
            Lighting_price.SetActive(false);

        }

    }

    public void FireBall_Fun()
    {
        if (game_manager.Coin_value < 9000f && Main_Traills.Fire_ball == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            FireBall_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 9000f && Main_Traills.Fire_ball == false)
        {
            game_manager.Coin_value -= 9000f;
            Main_Traills.Fire_ball = true;
            FireBall_owned.SetActive(true);
            FireBall_price.SetActive(false);

        }

    }
    #endregion

    void OnDisable()
    {
        Player_Data_Handler.SaveData_Traills();
        Player_Data_Handler.SaveData();
        Player_Data_Handler.SaveData_skins();
    }
}
   



