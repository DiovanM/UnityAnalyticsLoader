using System;
using UnityEngine;
using System.Collections.Generic;
using GameAnalyticsSDK;
using System.Globalization;

public class AnalyticsManager : MonoBehaviour
{
    #region Configuração do GameAnalyticsSDK
    /*
     *  1) Logar no GameAnalytics indo em Window/GameAnalytics/Select Settings
     *
     *  2) No Settings, ir em Setup e configurar os aplicativos criados previamente no site do GameAnalytics, para cada plataforma.
     *
     *  3)Se não identificar as configurações automaticamnete, inserir a Game Key e Secret Key de forma manual
     *
     *  https://gameanalytics.com/docs/item/unity-sdk
    */
    #endregion

    #region Configuração do FacebookSDK
    /*
     * 1) Configurar o FacebookSettings (Menu/Facebook/Edit Settings) com:
     * - App Name (opcional)
     * - App Id (id do app no Facebook Developers)
     * 
     * 2) Configurar o Package Name, Class Name e Key Hash (disponíveis no FacebookSettings) no App Dashboard do Facebook Developers em Configurações>Básico
     *
     * 3) Regerar o Android Manifest (pelo FacebookSettings)
     * 
     * 4) Gerar a build para consolidar as configurações com o Facebook Developers
     * 
     * https://developers.facebook.com/docs/unity/getting-started/android
    */
    #endregion

    ///Encontrando erros relacionados a libraries durante a build, checar o AndroidManifest e/ou ir em Assets/Play Services Resolver/Android Resolver/Resolve para reimportar as libraries

    private static AnalyticsManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        FacebookManager.StartSDK();
        GameAnalytics.Initialize();
    }

}