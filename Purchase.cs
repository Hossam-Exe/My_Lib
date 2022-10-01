
using UnityEngine;
using TMPro;

public class Purchase : MonoBehaviour
{
    public GameObject _Chest_Fx;
    public GameObject _spwan_place;
    public TextMeshProUGUI _Coin_Text;
    public static Purchase Ins;



    void Awake()
    {
        Ins = this;
    }

    public void CHEST_3()
    {
        game_manager.Coin_value += 3000;
        _Coin_Text.text = game_manager.Coin_value.ToString();
    }
    public void CHEST_7()
    {
        game_manager.Coin_value += 7000;
        _Coin_Text.text = game_manager.Coin_value.ToString();
    }
    public void CHEST_15()
    {
        game_manager.Coin_value += 15000;
        _Coin_Text.text = game_manager.Coin_value.ToString();
    }

    public void Chest_Fx()
    {
      GameObject _obj=  Instantiate(_Chest_Fx, _spwan_place.transform.position, Quaternion.identity);
        _obj.transform.parent = _spwan_place.transform;
        Destroy(_obj, 3f);
    }


    public void Coin_text()
    {
       
        _Coin_Text.text = game_manager.Coin_value.ToString();
    }
}
