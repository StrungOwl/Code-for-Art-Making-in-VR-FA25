using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInEffect : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.0f;

    private void Start()
    {
        fadeImage.color = new Color(1, 1, 1, 1);
        fadeImage.gameObject.SetActive(true); 
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float timer = 0;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            float alpha = Mathf.Lerp(1, 0, timer / fadeDuration);
            fadeImage.color = new Color(1, 1, 1, alpha);
            yield return null;
        }

        fadeImage.gameObject.SetActive(false);
    }
}
