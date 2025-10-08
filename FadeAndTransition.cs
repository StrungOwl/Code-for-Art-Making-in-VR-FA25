using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class FadeAndTransition : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.0f;

    private AsyncOperation asyncLoad; 

    private void Start()
    {
        // fade image starts fully transparent
        fadeImage.color = new Color(1, 1, 1, 0);
        fadeImage.gameObject.SetActive(true);

        // start loading the scene asynchronously in the background
        StartCoroutine(LoadSceneInBackground("Environment"));
    }

    private IEnumerator LoadSceneInBackground(string sceneName)
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;

        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }
        Debug.Log("Scene is fully loaded but not activated yet.");
    }

    public void StartSceneTransition()
    {
        StartCoroutine(FadeToWhiteAndActivateScene());
    }

    private IEnumerator FadeToWhiteAndActivateScene()
    {
        float timer = 0;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(0, 1, timer / fadeDuration);
            fadeImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        asyncLoad.allowSceneActivation = true;
    }
}
