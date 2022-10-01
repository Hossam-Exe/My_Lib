using TMPro;
using UnityEngine;


public class Skins_script : MonoBehaviour
{

    public RectTransform not_enough;
    public GameObject not_enough_PF;
    public TextMeshProUGUI Gold;

    [Header("Basic")]
    public GameObject Red_cube_price;
    public GameObject Red_cube_owned;

    public GameObject Blue_Sphere_price;
    public GameObject Blue_Sphere_owned;

    public GameObject Yellow_Tri_price;
    public GameObject Yellow_Tri_owned;

    public GameObject Green_Pentagon_price;
    public GameObject Green_Pentagon_owned;

    public GameObject Pink_Star_price;
    public GameObject Pink_Star_owned;

    public GameObject Gradient_cube_price;
    public GameObject Gradient_cube_owned;

    public GameObject Gradient_Sphere_price;
    public GameObject Gradient_Sphere_owned;

    public GameObject Gradient_Tri_price;
    public GameObject Gradient_Tri_owned;

    public GameObject Gradient_Pentagon_price;
    public GameObject Gradient_Pentagon_owned;

    public GameObject Gradient_Star_price;
    public GameObject Gradient_Star_owned;

    int Frame_Amount = 3;


    void Start()
    {
       
        // Gold = GetComponentInChildren<TextMeshProUGUI>();
        Player_Data_Handler.LoadData_skins();
        Player_Data_Handler.LoadData_Traills();
        Player_Data_Handler.LoadData();
        Trail_Data_Handller.LoadData_Select();
       




    }
    void Update()
    {

        if (Time.frameCount % Frame_Amount == 0)
        {

            Gold.text = game_manager.Coin_value.ToString();
        }

    }



    #region Basic Fun
    
    public void Red_cube()
    {
        if (game_manager.Coin_value < 500f && Main_Traills.Red_Cube == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Red_cube_owned.SetActive(false);
        }
           

        if (game_manager.Coin_value >= 500f && Main_Traills.Red_Cube == false)
        {
            game_manager.Coin_value -= 500f;
            Main_Traills.Red_Cube = true;
            Red_cube_owned.SetActive(true);
            Red_cube_price.SetActive(false);
            Player_Data_Handler.SaveData_Traills();
        }

    }
    public void Blue_Sphere()
    {
        if (game_manager.Coin_value < 500f && Main_Traills.Blue_Sphere == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Blue_Sphere_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 500f && Main_Traills.Blue_Sphere == false)
        {
            game_manager.Coin_value -= 500f;
            Main_Traills.Blue_Sphere = true;
            Blue_Sphere_owned.SetActive(true);
            Blue_Sphere_price.SetActive(false);

        }

    }
    public void Yellow_Traingle()
    {
        if (game_manager.Coin_value < 500f && Main_Traills.Yellow_Triangle == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Yellow_Tri_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 500f && Main_Traills.Yellow_Triangle == false)
        {
            game_manager.Coin_value -= 500f;
            Main_Traills.Yellow_Triangle = true;
            Yellow_Tri_owned.SetActive(true);
            Yellow_Tri_price.SetActive(false);

        }

    }
    public void Green_Pentagon()
    {
        if (game_manager.Coin_value < 500f && Main_Traills.Green_Pentagon == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Green_Pentagon_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 500f && Main_Traills.Green_Pentagon == false)
        {
            game_manager.Coin_value -= 500f;
            Main_Traills.Green_Pentagon = true;
            Green_Pentagon_owned.SetActive(true);
            Green_Pentagon_price.SetActive(false);

        }

    }
    public void Pink_Star()
    {
        if (game_manager.Coin_value < 500f && Main_Traills.Pink_Star == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Pink_Star_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 500f && Main_Traills.Pink_Star == false)
        {
            game_manager.Coin_value -= 500f;
            Main_Traills.Pink_Star = true;
            Pink_Star_owned.SetActive(true);
            Pink_Star_price.SetActive(false);

        }

    }

    #endregion

    #region Basic Gradient
    public void Gradient_cube_fun()
    {
        if (game_manager.Coin_value < 750f && Main_Traills.Gradient_Cube == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient_cube_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 750f && Main_Traills.Gradient_Cube == false)
        {
            game_manager.Coin_value -= 750f;
            Main_Traills.Gradient_Cube = true;
            Gradient_cube_owned.SetActive(true);
            Gradient_cube_price.SetActive(false);

        }

    }
    public void Gradient_Sphere_fun()
    {
        if (game_manager.Coin_value < 750f && Main_Traills.Gradient_Sphere == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient_Sphere_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 750f && Main_Traills.Gradient_Sphere == false)
        {
            game_manager.Coin_value -= 750f;
            Main_Traills.Gradient_Sphere = true;
            Gradient_Sphere_owned.SetActive(true);
            Gradient_Sphere_price.SetActive(false);

        }
    }

    public void Gradient_Triangle_fun()
    {
        if (game_manager.Coin_value < 750f && Main_Traills.Gradient_Triangle == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient_Tri_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 750f && Main_Traills.Gradient_Triangle == false)
        {
            game_manager.Coin_value -= 750f;
            Main_Traills.Gradient_Triangle = true;
            Gradient_Tri_owned.SetActive(true);
            Gradient_Tri_price.SetActive(false);

        }
    }
    public void Gradient_Pentagon_fun()
    {
        if (game_manager.Coin_value < 750f && Main_Traills.Gradient_Pentagon == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient_Pentagon_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 750f && Main_Traills.Gradient_Pentagon == false)
        {
            game_manager.Coin_value -= 750f;
            Main_Traills.Gradient_Pentagon = true;
            Gradient_Pentagon_owned.SetActive(true);
            Gradient_Pentagon_price.SetActive(false);

        }
    }
    public void Gradient_Star_fun()
    {
        if (game_manager.Coin_value < 750f && Main_Traills.Gradient_Star == false)
        {
            Ui_Pool.Instance.Spawning("Energy_Required", not_enough.position, Quaternion.identity);

            Gradient_Star_owned.SetActive(false);
        }


        if (game_manager.Coin_value >= 750f && Main_Traills.Gradient_Star == false)
        {
            game_manager.Coin_value -= 750f;
            Main_Traills.Gradient_Star = true;
            Gradient_Star_owned.SetActive(true);
            Gradient_Star_price.SetActive(false);

        }
    }



    #endregion
    void OnDisable()
    {
        Player_Data_Handler.SaveData_Traills();
        Player_Data_Handler.SaveData();
        Player_Data_Handler.SaveData_skins();
        Trail_Data_Handller.SaveData_Select();
    }
}
   



