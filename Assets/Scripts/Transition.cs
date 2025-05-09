using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    public Image image;

    public float FadeDuration { get; private set; }


    private void Start()
    {
        FadeDuration = 1f;

        if (image.color.a >= 0.99f)
        {
            FadeOut();
            StartCoroutine(ActivityControll());
        }

    }

    public void FadeIn()
    {
        StartCoroutine(Fade(0f, 1f));
    }

    public void FadeOut()
    {
        StartCoroutine(Fade(1f, 0f));
    }

    private IEnumerator Fade(float start, float end)
    {
        float t = 0f;
        Color color = image.color;

        while (t < FadeDuration)
        {
            t += Time.deltaTime;
            float alpha = Mathf.Lerp(start, end, t / FadeDuration);
            image.color = new Color(color.r, color.g, color.b, alpha);
            yield return null;
        }

        image.color = new Color(color.r, color.g, color.b, end);

    }

    private IEnumerator ActivityControll()
    {
        yield return new WaitForSeconds(FadeDuration);
    }

}
