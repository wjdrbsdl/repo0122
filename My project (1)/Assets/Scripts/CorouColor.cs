using System.Collections;
using UnityEngine;

public class CorouColor : MonoBehaviour
{
    [SerializeField] private float fadeSpeed = 2f;
    [SerializeField] private SpriteRenderer spriteRender;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CallFadeOut();
    }

    private void CallFadeOut()
    {
        //Debug.Log("페이드아웃 호출");
        StartCoroutine("FadeOut");

    }

    private void CallFadeIn()
    {
        //Debug.Log("페이드인 호출");
        StartCoroutine("FadeIn");

    }

    IEnumerator FadeOut()
    {
        Color color = spriteRender.color;
        while (color.a > 0)
        {
            color.a -= Time.deltaTime * fadeSpeed;
            spriteRender.color = color;
            yield return null;
            color = spriteRender.color;
        }
        CallFadeIn();
    }

    IEnumerator FadeIn()
    {
        Color color = spriteRender.color;
        while (color.a < 1)
        {
           // Debug.Log("인 호출"+color.a);
            color.a += Time.deltaTime * fadeSpeed;
            spriteRender.color = color;
            yield return null;
            color = spriteRender.color;
        }
        //Debug.Log("와일 종료");
        CallFadeOut();
    }
}
