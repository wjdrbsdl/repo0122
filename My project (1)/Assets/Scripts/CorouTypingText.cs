using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CorouTypingText : MonoBehaviour
{
    public Text textUI; //출력 text
    [SerializeField]
    [TextArea]
    private string content; //출력내용
    [SerializeField]
    private float delay = 0.2f;//출력속도

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    public void OnMessageButtonClick()
    {
        StartCoroutine("TypingText");
    }

    /// <summary>
    /// 2배속 기능
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

            //타이핑 번째 인덱스 문자 진행
            textUI.text += content[typingCount].ToString();
            //타이핑한 숫자 +1
            typingCount++;

            //딜레이 수치만큼 대기
            yield return new WaitForSeconds(delay);
        }


    }
}
