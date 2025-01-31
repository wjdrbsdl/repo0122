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
    //텍스트에 카운트를 출력하는 기능
    //카운트는 1초마다 1씩 증가하는 형태

    public Text countText;
    int count = 0 ;

    void Start()
    {
        //명칭 지정했으므로 중단 가능
        StartCoroutine(nameof(CountPlus));
      /*  StopCoroutine(nameof(CountPlus));

        //단순 함수 호출이므로 해놓고 중단 불가?
        //외부에서 중지 기능 사용 불가?
        StartCoroutine(CountPlus());*/

    }

    //C#에 있는 도구
    IEnumerator CountPlus()
    {
        while (true)
        {
            count++;
            countText.text = count.ToString("N0");
            yield return null;
        }
        
        /*      Debug.Log("마이크 테스트");
              yield return new WaitForSeconds(1);
              Debug.Log("마이크 테스트 2");
              yield return new WaitForSeconds(5);
              Debug.Log("마이크 테스트 3");*/

    }
}
