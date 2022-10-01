
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ui_Pool_Combo : MonoBehaviour
{
   
  public Dictionary<string,Queue<GameObject>> Pool_Dictionary;
    public List<Pools> pool;

    [System.Serializable]
    public class Pools
    {
        public string Tag;
        public GameObject Pre;
        public int Size;
    }
    public static Ui_Pool_Combo Instance;

    private void Awake()
    {
        
        Instance = this;
    }
    void Start()
    {
        Pool_Dictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pools pool in pool)
        {
            Queue<GameObject> Pre_Objects = new Queue<GameObject>();

            for (int i = 0; i < pool.Size; i++)
            {
               GameObject obj= Instantiate(pool.Pre);
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                Pre_Objects.Enqueue(obj);
            }

            Pool_Dictionary.Add(pool.Tag, Pre_Objects);
        }

       
        


    }
    public  GameObject Spawning(string tag ,Vector3 Position)
    {
        if (!Pool_Dictionary.ContainsKey(tag))
        {
            return null;
        }
            

       GameObject objecttospwan= Pool_Dictionary[tag].Dequeue();


      
       

        objecttospwan.SetActive(true);

        int _add = Score_Combo.Score_Index + 1;
        
        

        switch (Score_Combo.Score_Index)
        {
            case 0:

                objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.clear;
                break;
            case 2:

                objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.cyan;
                break;
            case 3:

                objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.green;
                break;
            case 4:

                objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.blue;
                break;
            case 5:

                objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.red;
                break;


        }

        if (Score_Combo.Score_Index >= 5)
        {
            objecttospwan.GetComponent<TextMeshProUGUI>().color = Color.red;
        }

        objecttospwan.GetComponent<TextMeshProUGUI>().text = _add.ToString() + "+";

        objecttospwan.transform.position = Position;
        //objecttospwan.transform.rotation = Rotation;



        IPooler _ipooler = objecttospwan.GetComponent<IPooler>();

        if (_ipooler != null)
        {
            _ipooler.OnRePool();

        }

        Pool_Dictionary[tag].Enqueue(objecttospwan);
        return objecttospwan;


        
    }
    

 }
