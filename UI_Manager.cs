using System.Collections;
using UnityEngine;
using UnityEngine.UI;



public class UI_Manager : MonoBehaviour
{
    public float curtime;
    public float time = 3f;

    public GameObject ResumeObj;

    [Header("------Shapes_icon------")]
    public Image icon_cube;
    public Image icon_sphere;
    public Image icon_triangel;
    public Image icon_8shape;
    public Image icon_star;

    [Header("------Shapes_icon/shadow------")]
    public Image icon_cube_shadow;
    public Image icon_sphere_shadow;
    public Image icon_triangel_shadow;
    public Image icon_8shape_shadow;
    public Image icon_star_shadow;




    //bools_icons
    public bool cube = false;
    public bool sphere = false;
    public bool triangel = false;
    public bool shape8 = false;
    public bool star = false;

    Player_Move player;
    WaitForSeconds _wait_counter;
    //public void OnPointerDown()

    //{

    //}

    //public  void OnPointerUp()
    //{
    //  // playerspwaner.enabled = false;


    //}
    //public void OnPointerExit()
    //{


    //}

    void Start()
    {
        _wait_counter = new WaitForSeconds(1f);
        StartCoroutine(Counter());
        player = FindObjectOfType<Player_Move>();
        curtime = time;
        player.enabled = false;
    }





    void Update()
    {
        //if (curtime <= 3)
        //{
        //    curtime -= 1 * Time.deltaTime;
        //}

        //if (curtime <= 0)
        //{
        //    player.enabled = true;
        //}
    }


    public void Cube_fun()
    {
        icon_cube_shadow.enabled = true;
        icon_sphere_shadow.enabled = false;
        icon_triangel_shadow.enabled = false;
        icon_8shape_shadow.enabled = false;
        icon_star_shadow.enabled = false;

        cube = true;
        sphere = false;
        triangel = false;
        shape8 = false;
        star = false;

    }

    public void sphere_fun()
    {
        icon_sphere_shadow.enabled = true;
        icon_cube_shadow.enabled = false;
        icon_triangel_shadow.enabled = false;
        icon_8shape_shadow.enabled = false;
        icon_star_shadow.enabled = false;

        sphere = true;
        cube = false;
        triangel = false;
        shape8 = false;
        star = false;
    }
    public void triangel_fun()
    {
        icon_triangel_shadow.enabled = true;
        icon_sphere_shadow.enabled = false;
        icon_cube_shadow.enabled = false;
        icon_8shape_shadow.enabled = false;
        icon_star_shadow.enabled = false;

        triangel = true;
        cube = false;
        sphere = false;
        shape8 = false;
        star = false;
    }
    public void shape8_fun()
    {
        icon_8shape_shadow.enabled = true;
        icon_sphere_shadow.enabled = false;
        icon_cube_shadow.enabled = false;
        icon_triangel_shadow.enabled = false;
        icon_star_shadow.enabled = false;

        shape8 = true;
        triangel = false;
        cube = false;
        sphere = false;
        star = false;
    }
    public void star_fun()
    {
        icon_star_shadow.enabled = true;
        icon_8shape_shadow.enabled = false;
        icon_sphere_shadow.enabled = false;
        icon_cube_shadow.enabled = false;
        icon_triangel_shadow.enabled = false;

        star = true;
        shape8 = false;
        triangel = false;
        cube = false;
        sphere = false;
    }

    public void Resume()
    {
        
        ResumeObj.SetActive(false);
        Destroy(ResumeObj, 1f);
    }


    public void Pause()
    {
        Time.timeScale = 0f;
    }
    IEnumerator Counter()
    {
        while (curtime >= 0)
        {
            curtime -= 1;
            yield return _wait_counter;
            if (curtime <= 0)
            {
                player.enabled = true;
                StopCoroutine(Counter());

            }
        }








    }
}
