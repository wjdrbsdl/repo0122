using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CorouTypingText : MonoBehaviour
{
    public Text textUI; //��� text
    [SerializeField]
    [TextArea]
    private string content; //��³���
    [SerializeField]
    private float delay = 0.2f;//��¼ӵ�

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    public void OnMessageButtonClick()
    {
        StartCoroutine("TypingText");
    }

    /// <summary>
    /// 2��� ���
    /// </summary>
    public void ByTwo()
    {
        if (delay == 0.2f)
        {
            delay = 0.1f;
        }
        else
        {
            delay = 0.2f;
        }

    }

    IEnumerator TypingText()
    {
        textUI.text = "";
        int typingCount = 0;
        while (typingCount < content.Length)
        {

            //Ÿ���� ��° �ε��� ���� ����
            textUI.text += content[typingCount].ToString();
            //Ÿ������ ���� +1
            typingCount++;

            //������ ��ġ��ŭ ���
            yield return new WaitForSeconds(delay);
        }


    }
}
