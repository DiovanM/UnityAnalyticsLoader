using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class FacebookManager : MonoBehaviour {

    #region Basic Config

    public static void StartSDK()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                {
                    FB.ActivateApp();
                    Debug.Log("[FacebookSDK] Initialized");
                }
                else
                    Debug.Log("[FacebookSDK] Error initializing");
            });
        }
        else
        {
            Debug.Log("[FacebookSDK] Already initialized, activating App");
            FB.ActivateApp();
        }
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (!pauseStatus)
        {
            if (FB.IsInitialized)
                FB.ActivateApp();
             else
                FB.Init(() => { FB.ActivateApp(); });
        }
    }

    #endregion
    
    public static void LogEvent(string eventName, Dictionary<string, object> parameters)
    {
        if (FB.IsInitialized)
            FB.LogAppEvent(eventName, null, parameters);
    }

}
