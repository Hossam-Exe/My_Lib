using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Data_Handler : MonoBehaviour
{
    public static Player_Data_Handler Instance;
    void Awake()
    {
        Instance = this;
    }
    public static void SaveScore()
    {


        ES3.Save<float>("Score_Cur", Score.uiscore);


        ES3.Save<float>("Score1", Board.Num1);

        ES3.Save<float>("Score2", Board.Num2);
        ES3.Save<float>("Score3", Board.Num3);
        ES3.Save<float>("Score4", Board.Num4);


    }
    public static void LoadScore()
    {
        Board._curscore= ES3.Load<float>("Score_Cur");

        Board.Num1 = ES3.Load<float>("Score1");
        Board.Num2 = ES3.Load<float>("Score2");
        Board.Num3 = ES3.Load<float>("Score3");
        Board.Num4 = ES3.Load<float>("Score4");



    }

    public void scorerest()
    {
        Board._curscore = 0;

        Board.Num1 = 0;
        Board.Num2 = 0;
        Board.Num3 = 0;
        Board.Num4 = 0;
    }
    public static void SaveFirstTime()
    {


        ES3.Save<bool>("First",First_Time.IsFirstTime);
    }
    public static void LoadFirstTime()
    {

        First_Time.IsFirstTime = ES3.Load<bool>("First");



    }
    public static void SaveData()
    {

        ES3.Save<float>("cash", game_manager.Coin_value);

        ES3.Save<int>("Live", Lives_System.Live_Value);

        
      
    }
    public static void LoadData()
    {
        
        game_manager.Coin_value = ES3.Load<float>("cash",0f);

        Lives_System.Live_Value = ES3.Load<int>("Live");
      

    }
    public static void SaveData_scene()
    {
        Play_script.scene_count = SceneManager.GetActiveScene().buildIndex;
        ES3.Save<int>("Scene", Play_script.scene_count);


    }
    public static void LoadData_scene()
    {
        Play_script.scene_count = ES3.Load<int>("Scene");



    }
    public static void SaveData_Traills()
    {

        #region Basic_Data_Save //////

        ES3.Save<bool>("RedTrail", Main_Traills.isRed_Cube);
        ES3.Save<bool>("BlueTrail", Main_Traills.isBlue_Sphere);
        ES3.Save<bool>("TriangleTrail", Main_Traills.isYellow_Triangle);
        ES3.Save<bool>("GreenTrail", Main_Traills.isGreen_Pentagon);
        ES3.Save<bool>("PinkTrail", Main_Traills.isPink_Star);

        ES3.Save<bool>("Red", Main_Traills.Red_Cube);
        ES3.Save<bool>("Blue", Main_Traills.Blue_Sphere);
        ES3.Save<bool>("Triangle", Main_Traills.Yellow_Triangle);
        ES3.Save<bool>("Green", Main_Traills.Green_Pentagon);
        ES3.Save<bool>("Pink", Main_Traills.Pink_Star);

        ES3.Save<bool>("Cube_Gradient_Trail", Main_Traills.isGradient_Cube);
        ES3.Save<bool>("Sphere_Gradient_Trail", Main_Traills.isGradient_Sphere);
        ES3.Save<bool>("Triangle_Gradient_Trail", Main_Traills.isGradient_Triangle);
        ES3.Save<bool>("Pentagon_Gradient_Trail", Main_Traills.isGradient_Pentagon);
        ES3.Save<bool>("Star_Gradient_Trail", Main_Traills.isGradient_Star);


        ES3.Save<bool>("Cube_Gradient", Main_Traills.Gradient_Cube);
        ES3.Save<bool>("Sphere_Gradient", Main_Traills.Gradient_Sphere);
        ES3.Save<bool>("Triangle_Gradient", Main_Traills.Gradient_Triangle);
        ES3.Save<bool>("Pentagon_Gradient", Main_Traills.Gradient_Pentagon);
        ES3.Save<bool>("Star_Gradient", Main_Traills.Gradient_Star);


        #endregion


        #region Gradient_Data_Save //////

        ES3.Save<bool>("Gradient1_Trail", Main_Traills.isGradient_1);
        ES3.Save<bool>("Gradient2_Trail", Main_Traills.isGradient_2);
        ES3.Save<bool>("Gradient3_Trail", Main_Traills.isGradient_3);
        ES3.Save<bool>("Gradient4_Trail", Main_Traills.isGradient_4);
        ES3.Save<bool>("Gradient5_Trail", Main_Traills.isGradient_5);

        ES3.Save<bool>("Gradient6_Trail", Main_Traills.isGradient_6);
        ES3.Save<bool>("Gradient7_Trail", Main_Traills.isGradient_7);
        ES3.Save<bool>("Gradient8_Trail", Main_Traills.isGradient_8);
        ES3.Save<bool>("Gradient9_Trail", Main_Traills.isGradient_9);
        ES3.Save<bool>("Gradient10_Trail", Main_Traills.isGradient_10);

        ES3.Save<bool>("Gradient1", Main_Traills.Gradient_1);
        ES3.Save<bool>("Gradient2", Main_Traills.Gradient_2);
        ES3.Save<bool>("Gradient3", Main_Traills.Gradient_3);
        ES3.Save<bool>("Gradient4", Main_Traills.Gradient_4);
        ES3.Save<bool>("Gradient5", Main_Traills.Gradient_5);

        ES3.Save<bool>("Gradient6", Main_Traills.Gradient_6);
        ES3.Save<bool>("Gradient7", Main_Traills.Gradient_7);
        ES3.Save<bool>("Gradient8", Main_Traills.Gradient_8);
        ES3.Save<bool>("Gradient9", Main_Traills.Gradient_9);
        ES3.Save<bool>("Gradient10", Main_Traills.Gradient_10);

        #endregion

        #region Leg_Data_Save //////

        ES3.Save<bool>("Snow_Trail", Main_Traills.isSnow);
        ES3.Save<bool>("Dust_Trail", Main_Traills.isDust);
        ES3.Save<bool>("Fireball_Trail", Main_Traills.isFire_ball);
        ES3.Save<bool>("Lighting_Trail", Main_Traills.isLighting);

        ES3.Save<bool>("Snow", Main_Traills.Snow);
        ES3.Save<bool>("Dust", Main_Traills.Dust);
        ES3.Save<bool>("Fireball", Main_Traills.Fire_ball);
        ES3.Save<bool>("Lighting", Main_Traills.Lighting);

        #endregion



    }
    public static void LoadData_Traills()
    {
        #region Basic_Data_Load //////

        Main_Traills.isRed_Cube = ES3.Load<bool>("RedTrail");
        Main_Traills.isBlue_Sphere = ES3.Load<bool>("BlueTrail");
        Main_Traills.isYellow_Triangle = ES3.Load<bool>("TriangleTrail");
        Main_Traills.isGreen_Pentagon = ES3.Load<bool>("GreenTrail");
        Main_Traills.isPink_Star = ES3.Load<bool>("PinkTrail");

        Main_Traills.isGradient_Cube = ES3.Load<bool>("Cube_Gradient_Trail");
        Main_Traills.isGradient_Sphere = ES3.Load<bool>("Sphere_Gradient_Trail");
        Main_Traills.isGradient_Triangle = ES3.Load<bool>("Triangle_Gradient_Trail");
        Main_Traills.isGradient_Pentagon = ES3.Load<bool>("Pentagon_Gradient_Trail");
        Main_Traills.isGradient_Star = ES3.Load<bool>("Star_Gradient_Trail");


        Main_Traills.Red_Cube = ES3.Load<bool>("Red");
        Main_Traills.Blue_Sphere = ES3.Load<bool>("Blue");
        Main_Traills.Yellow_Triangle = ES3.Load<bool>("Triangle");
        Main_Traills.Green_Pentagon = ES3.Load<bool>("Green");
        Main_Traills.Pink_Star = ES3.Load<bool>("Pink");

        Main_Traills.Gradient_Cube = ES3.Load<bool>("Cube_Gradient");
        Main_Traills.Gradient_Sphere = ES3.Load<bool>("Sphere_Gradient");
        Main_Traills.Gradient_Triangle = ES3.Load<bool>("Triangle_Gradient");
        Main_Traills.Gradient_Pentagon = ES3.Load<bool>("Pentagon_Gradient");
        Main_Traills.Gradient_Star = ES3.Load<bool>("Star_Gradient");

        #endregion

        #region Gradients_Data_Load //////

        Main_Traills.isGradient_1 = ES3.Load<bool>("Gradient1_Trail");
        Main_Traills.isGradient_2 = ES3.Load<bool>("Gradient2_Trail");
        Main_Traills.isGradient_3 = ES3.Load<bool>("Gradient3_Trail");
        Main_Traills.isGradient_4 = ES3.Load<bool>("Gradient4_Trail");
        Main_Traills.isGradient_5 = ES3.Load<bool>("Gradient5_Trail");

        Main_Traills.isGradient_6 = ES3.Load<bool>("Gradient6_Trail");
        Main_Traills.isGradient_7 = ES3.Load<bool>("Gradient7_Trail");
        Main_Traills.isGradient_8 = ES3.Load<bool>("Gradient8_Trail");
        Main_Traills.isGradient_9 = ES3.Load<bool>("Gradient9_Trail");
        Main_Traills.isGradient_10 = ES3.Load<bool>("Gradient10_Trail");


        Main_Traills.Gradient_1 = ES3.Load<bool>("Gradient1");
        Main_Traills.Gradient_2 = ES3.Load<bool>("Gradient2");
        Main_Traills.Gradient_3 = ES3.Load<bool>("Gradient3");
        Main_Traills.Gradient_4 = ES3.Load<bool>("Gradient4");
        Main_Traills.Gradient_5 = ES3.Load<bool>("Gradient5");

        Main_Traills.Gradient_6 = ES3.Load<bool>("Gradient6");
        Main_Traills.Gradient_7 = ES3.Load<bool>("Gradient7");
        Main_Traills.Gradient_8 = ES3.Load<bool>("Gradient8");
        Main_Traills.Gradient_9 = ES3.Load<bool>("Gradient9");
        Main_Traills.Gradient_10 = ES3.Load<bool>("Gradient10");

        #endregion

        #region legn_Data_Load //////

        Main_Traills.isSnow = ES3.Load<bool>("Snow_Trail");
        Main_Traills.isDust = ES3.Load<bool>("Dust_Trail");
        Main_Traills.isFire_ball = ES3.Load<bool>("Fireball_Trail");
        Main_Traills.isLighting = ES3.Load<bool>("Lighting_Trail");


        Main_Traills.Snow = ES3.Load<bool>("Snow");
        Main_Traills.Dust = ES3.Load<bool>("Dust");
        Main_Traills.Fire_ball = ES3.Load<bool>("Fireball");
        Main_Traills.Lighting = ES3.Load<bool>("Lighting");

        #endregion

    }

    public static void Load_Time_Passed()
    {
        Lives_System.Live_Time_Passed = ES3.Load<string>("Live_Time_Passed");
    }
    public static void Save_Time_Passed()
    {
        ES3.Save<string>("Live_Time_Passed", Lives_System.Live_Time_Passed);
    }

    public static void SaveData_skins()
    {

        #region Cuba_Date_Save //////

        ES3.Save<bool>("Rubic", Main_Loot_Skins.isrupic);
        ES3.Save<bool>("Dice", Main_Loot_Skins.isdice);

        ES3.Save<bool>("Rubic_Selected", Loot_Select_Logic.Select_Cube);
        ES3.Save<bool>("Dice_Selected", Loot_Select_Logic2.Select_Cube);

        #endregion


        #region Ball_Date_Save //////
        ES3.Save<bool>("Football", Main_Loot_Skins.isfootball);
        ES3.Save<bool>("Basketball", Main_Loot_Skins.isbasket);
        ES3.Save<bool>("Beachball", Main_Loot_Skins.isbeach);
        ES3.Save<bool>("Eyeball", Main_Loot_Skins.isball8);

        ES3.Save<bool>("Beachball_Selected", Loot_Select_Logic3.Select_Sphere);
        ES3.Save<bool>("Eyeball_Selected", Loot_Select_Logic4.Select_Sphere);
        ES3.Save<bool>("Football_Selected", Loot_Select_Logic5.Select_Sphere);
        ES3.Save<bool>("Basketball_Selected", Loot_Select_Logic6.Select_Sphere);

        #endregion


    }

    public static void LoadData_skins()
    {

        #region Cuba_Date_Load //////

        Main_Loot_Skins.isrupic = ES3.Load<bool>("Rubic");
        Main_Loot_Skins.isdice = ES3.Load<bool>("Dice");

        Loot_Select_Logic.Select_Cube = ES3.Load<bool>("Rubic_Selected");
        Loot_Select_Logic2.Select_Cube = ES3.Load<bool>("Dice_Selected");

        #endregion

        #region Ball_Date_Load //////
        Main_Loot_Skins.isfootball = ES3.Load<bool>("Football");
        Main_Loot_Skins.isbasket = ES3.Load<bool>("Basketball");
        Main_Loot_Skins.isbeach = ES3.Load<bool>("Beachball");
        Main_Loot_Skins.isball8 = ES3.Load<bool>("Eyeball");

        Loot_Select_Logic3.Select_Sphere = ES3.Load<bool>("Beachball_Selected");
        Loot_Select_Logic4.Select_Sphere = ES3.Load<bool>("Eyeball_Selected");
        Loot_Select_Logic5.Select_Sphere = ES3.Load<bool>("Football_Selected");
        Loot_Select_Logic6.Select_Sphere = ES3.Load<bool>("Basketball_Selected");

        #endregion





    }
    public void Rest()
    {
        // game_manager.Coin_value = 0f;

        // Play_script.scene_count = 0;

        Main_Traills.isRed_Cube = false;
        Main_Traills.isBlue_Sphere = false;
        Main_Traills.isYellow_Triangle = false;
        Main_Traills.isGreen_Pentagon = false;
        Main_Traills.isPink_Star = false;

        Main_Traills.isGradient_Cube = false;
        Main_Traills.isGradient_Sphere = false;
        Main_Traills.isGradient_Triangle = false;
        Main_Traills.isGradient_Pentagon = false;
        Main_Traills.isGradient_Star = false;

        Main_Traills.Red_Cube = false;
        Main_Traills.Blue_Sphere = false;
        Main_Traills.Yellow_Triangle = false;
        Main_Traills.Green_Pentagon = false;
        Main_Traills.Pink_Star = false;

        Main_Traills.Gradient_Cube = false;
        Main_Traills.Gradient_Sphere = false;
        Main_Traills.Gradient_Triangle = false;
        Main_Traills.Gradient_Pentagon = false;
        Main_Traills.Gradient_Star = false;


        #region Gradients_Data_rest //////

        Main_Traills.isGradient_1 = false;
        Main_Traills.isGradient_2 = false;
        Main_Traills.isGradient_3 = false;
        Main_Traills.isGradient_4 = false;
        Main_Traills.isGradient_5 = false;

        Main_Traills.isGradient_6 = false;
        Main_Traills.isGradient_7 = false;
        Main_Traills.isGradient_8 = false;
        Main_Traills.isGradient_9 = false; 
        Main_Traills.isGradient_10 = false;


        Main_Traills.Gradient_1 = false;
        Main_Traills.Gradient_2 = false;
        Main_Traills.Gradient_3 = false;
        Main_Traills.Gradient_4 = false;
        Main_Traills.Gradient_5 = false;

        Main_Traills.Gradient_6 = false;
        Main_Traills.Gradient_7 = false;
        Main_Traills.Gradient_8 = false;
        Main_Traills.Gradient_9 = false;
        Main_Traills.Gradient_10 = false;

        #endregion

        #region legn_Data_Rest //////

        Main_Traills.isSnow = false;
        Main_Traills.isDust = false;
        Main_Traills.isFire_ball = false;
        Main_Traills.isLighting = false;


        Main_Traills.Snow = false;
        Main_Traills.Dust = false;
        Main_Traills.Fire_ball = false;
        Main_Traills.Lighting = false;

        #endregion

        #region Cuba_Date_Rest //////

        Main_Loot_Skins.isrupic = false;
        Main_Loot_Skins.isdice = false;


        #endregion

        #region Ball_Date_rest //////
        Main_Loot_Skins.isfootball = false;
        Main_Loot_Skins.isbasket = false;
        Main_Loot_Skins.isbeach = false;
        Main_Loot_Skins.isball8 = false;

        #endregion

        First_Time.IsFirstTime = true;


      Board._curscore = 0;
        Board.Num1 = 0;
        Board.Num2 = 0;
        Board.Num3 = 0;
        Board.Num4 = 0;
    }

    public static void Restart_lives()
    {
        Lives_System.Live_Value = 5;

    }
    public static void Restart_Coin_live()
    {
        game_manager.Coin_value = 0;
        game_manager.life_value = 3;
    }
}
