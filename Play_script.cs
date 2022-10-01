
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_script : MonoBehaviour
{
    public Animator play_anim;
    public static int scene_count;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        Player_Data_Handler.LoadData_scene();
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Resume()
    {
        Time.timeScale = 1f;


        if (scene_count <= 0)
        {
            scene_count += 1;
        }
        SceneManager.LoadScene(scene_count);
    }
    public void anim()
    {
        play_anim.SetBool("Play", true);
        play_anim.SetBool("End", false);
    }
    public void anim_end()
    {
        play_anim.SetBool("Play", false);
        play_anim.SetBool("End", true);
    }
    public void end_less()
    {
        SceneManager.LoadScene(41);
    }
}
