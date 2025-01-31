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
        //Debug.Log("���̵�ƿ� ȣ��");
        StartCoroutine("FadeOut");

    }

    private void CallFadeIn()
    {
        //Debug.Log("���̵��� ȣ��");
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
           // Debug.Log("�� ȣ��"+color.a);
            color.a += Time.deltaTime * fadeSpeed;
            spriteRender.color = color;
            yield return null;
            color = spriteRender.color;
        }
        //Debug.Log("���� ����");
        CallFadeOut();
    }
}
