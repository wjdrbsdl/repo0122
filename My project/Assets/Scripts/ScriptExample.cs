using NUnit.Framework;
using UnityEngine;

/// <summary>
/// ����Ƽ ��Ʈ����Ʈ(Unity Attribute)
/// ����Ƽ������ �����Ϳ� �°� ��ũ��Ʈ�� Ŀ�����ϴ� ���� �����մϴ�.
/// </summary>

[AddComponentMenu("�Ҽ�/�̸�")]
public class ScriptExample : MonoBehaviour
{
    [UnityEngine.Range(1, 99)]
    public int level;

    [UnityEngine.Range(0, 100)]
    public int volume;

    [Header("�÷��̾� �̸�")]
    public string playerName;

    [TextArea]
    public string talk01;

    [TextArea(1,3)]
    public string talk02;

    [TextArea(5,7)]
    public string talk03;

    [Tooltip("üũ�Ǹ� ���� ����")]
    public bool isDead = true;

    [ContextMenu("HelloEve")]
    void HelloEveryOne()
    {
        Debug.Log("������ ��� �ȳ�");
    }

    void HelloSomeOne(string _someoneName)
    {
        Debug.Log($"{_someoneName}�� �ȳ��ϼ���");
    }

    [ContextMenu("HelloInt")]
    void TestInt()
    {
        Debug.Log($"{level}���� ��������");
    }
}
