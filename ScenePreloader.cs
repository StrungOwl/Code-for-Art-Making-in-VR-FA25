using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScenePreloader : MonoBehaviour
{
    public string sceneToPreload;

    private AsyncOperation asyncLoad;
    private bool isSceneReady = false;

    void Start()
    {
        StartCoroutine(PreloadScene());
    }

    private IEnumerator PreloadScene()
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneToPreload);
        asyncLoad.allowSceneActivation = false;

        // wait until the scene is almost loaded
        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        isSceneReady = true;
    }

    public void GoToPreloadedScene()
    {
        if (isSceneReady && asyncLoad != null)
        {
            // activate preloaded scene
            asyncLoad.allowSceneActivation = true;
        }
        else
        {
            Debug.LogWarning("Scene is not ready yet!");
        }
    }
}