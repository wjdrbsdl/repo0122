// using은 다음에 적힌 것을 코드에서 사용할것을 선언. 
// 남발하면안되는이유 - ex 유니티엔진의 코드를 다 복붙해놓음.
using UnityEngine; //유니티엔진 코드를 모두 불러와라는 명령

namespace UnityTuto
{
    //유니티 튜토 안에 만들어진 SampleA
    public class SampleA
    {

    }
}

/// <summary>
/// 처음 만든 유니티 스크립트 올
/// </summary>
public class Test : MonoBehaviour
//MonoBehaviour는 클래스에 연결 했을 경우 
//유니티 씬에 존재하는 오브젝트에 연결 가능
//유니티 기능 사용 가능
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("헬로, 월드");
    }

    int count = 0; 

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count} 좌우 반복 뛰기");
        count++; //카운트가 1 증가한다. 
    }
}
