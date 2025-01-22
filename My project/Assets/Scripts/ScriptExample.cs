using NUnit.Framework;
using UnityEngine;

/// <summary>
/// 유니티 어트리뷰트(Unity Attribute)
/// 유니티에서는 에디터에 맞게 스크립트를 커스텀하는 것이 가능합니다.
/// </summary>

[AddComponentMenu("소속/이름")]
public class ScriptExample : MonoBehaviour
{
    [UnityEngine.Range(1, 99)]
    public int level;

    [UnityEngine.Range(0, 100)]
    public int volume;

    [Header("플레이어 이름")]
    public string playerName;

    [TextArea]
    public string talk01;

    [TextArea(1,3)]
    public string talk02;

    [TextArea(5,7)]
    public string talk03;

    [Tooltip("체크되면 죽은 상태")]
    public bool isDead = true;

    [ContextMenu("HelloEve")]
    void HelloEveryOne()
    {
        Debug.Log("여러분 모두 안녕");
    }

    void HelloSomeOne(string _someoneName)
    {
        Debug.Log($"{_someoneName}님 안녕하세요");
    }

    [ContextMenu("HelloInt")]
    void TestInt()
    {
        Debug.Log($"{level}빠워 빠워빠워");
    }
}
