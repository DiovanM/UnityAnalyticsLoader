#pragma warning disable 0649

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreLoader : MonoBehaviour
{
    [SerializeField] private float secondsToLoad = 0f;
    [SerializeField] private int startingSceneIndex;
    [SerializeField] private string startingSceneName;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f + secondsToLoad);
        if (startingSceneIndex != 0)
            SceneManager.LoadScene(startingSceneIndex);
        else
            SceneManager.LoadScene(startingSceneName);
    }
}

#pragma warning restore 0649