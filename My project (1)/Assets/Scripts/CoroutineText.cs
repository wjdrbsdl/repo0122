using System.Collections;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine.UI;

public class CoroutineText : MonoBehaviour
{
    //�ؽ�Ʈ�� ī��Ʈ�� ����ϴ� ���
    //ī��Ʈ�� 1�ʸ��� 1�� �����ϴ� ����

    public Text countText;
    int count = 0 ;

    void Start()
    {
        //��Ī ���������Ƿ� �ߴ� ����
        StartCoroutine(nameof(CountPlus));
      /*  StopCoroutine(nameof(CountPlus));

        //�ܼ� �Լ� ȣ���̹Ƿ� �س��� �ߴ� �Ұ�?
        //�ܺο��� ���� ��� ��� �Ұ�?
        StartCoroutine(CountPlus());*/

    }

    //C#�� �ִ� ����
    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            countText.text = count.ToString("N0");
            yield return null;
        }
        
        /*      Debug.Log("����ũ �׽�Ʈ");
              yield return new WaitForSeconds(1);
              Debug.Log("����ũ �׽�Ʈ 2");
              yield return new WaitForSeconds(5);
              Debug.Log("����ũ �׽�Ʈ 3");*/

    }
}
