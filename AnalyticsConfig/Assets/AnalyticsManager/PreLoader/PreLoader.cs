using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreLoader : MonoBehaviour
{
    [SerializeField] private int startingSceneIndex;
    [SerializeField] private string startingSceneName;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f);
        if (startingSceneIndex != 0)
            SceneManager.LoadScene(startingSceneIndex);
        else
            SceneManager.LoadScene(startingSceneName);
    }
}
