using System.Collections;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class CoroutineText : MonoBehaviour
{
    //�ؽ�Ʈ�� ī��Ʈ�� ����ϴ� ���
    //ī��Ʈ�� 1�ʸ��� 1�� �����ϴ� ����

    void Start()
    {
        //��Ī ���������Ƿ� �ߴ� ����
        StartCoroutine("ġŲġŲ");
        StopCoroutine(nameof(CountPlus));

        //�ܼ� �Լ� ȣ���̹Ƿ� �س��� �ߴ� �Ұ�?
        //�ܺο��� ���� ��� ��� �Ұ�?
        StartCoroutine(CountPlus());

    }

    //C#�� �ִ� ����
    IEnumerator CountPlus()
    {
        /*      Debug.Log("����ũ �׽�Ʈ");
              yield return new WaitForSeconds(1);
              Debug.Log("����ũ �׽�Ʈ 2");
              yield return new WaitForSeconds(5);
              Debug.Log("����ũ �׽�Ʈ 3");*/
        yield return null;
    }
}
