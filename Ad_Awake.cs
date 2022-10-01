using UnityEngine;
using UnityEngine.Advertisements;

public class Ad_Awake : MonoBehaviour, IUnityAdsInitializationListener
{
    [SerializeField] string _androidGameId= "4567342";
    [SerializeField] string _iOsGameId;
    [SerializeField] bool _testMode = true;
   
    private string _gameId;

    void Awake()
    {
        InitializeAds();
    }

    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOsGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode);
    }

    public void OnInitializationComplete()
    {
      
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        
    }
}