using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Advertisements;


public class AdsController : MonoBehaviour, IUnityAdsInitializationListener
{
    public static AdsController instance;

    public string androidGameId;

    public string iOSGameId;

    public string idAnunciosAndroid;

    public string idAnunciosIOS;

    private string idSeleccionado;

    private string idAnuncioSeleccionado;

    public bool testMode = true;

    public void OnInitializationComplete()
    {
        throw new System.NotImplementedException();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void IniciarAnuncios()
    {
#if UNITY_ANDROID
        idSeleccionado = androidGameId;
        idAnuncioSeleccionado = idAnunciosAndroid;
#elif UNITY_IOS
    idSeleccionado = iOSGameId;
    idAnuncioSeleccionado = idAnunciosIOS;
#elif UNITY_EDITOR
    idSeleccionado = androidGameId;
    idAnuncioSeleccionado = idAnunciosAndroid;
#endif

        Advertisement.Initialize(idSeleccionado,testMode, this);
    }
}
