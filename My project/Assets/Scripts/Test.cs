// using�� ������ ���� ���� �ڵ忡�� ����Ұ��� ����. 
// �����ϸ�ȵǴ����� - ex ����Ƽ������ �ڵ带 �� �����س���.
using UnityEngine; //����Ƽ���� �ڵ带 ��� �ҷ��Ͷ�� ���

namespace UnityTuto
{
    //����Ƽ Ʃ�� �ȿ� ������� SampleA
    public class SampleA
    {

    }
}

/// <summary>
/// ó�� ���� ����Ƽ ��ũ��Ʈ ��
/// </summary>
public class Test : MonoBehaviour
//MonoBehaviour�� Ŭ������ ���� ���� ��� 
//����Ƽ ���� �����ϴ� ������Ʈ�� ���� ����
//����Ƽ ��� ��� ����
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("���, ����");
    }

    int count = 0; 

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{count} �¿� �ݺ� �ٱ�");
        count++; //ī��Ʈ�� 1 �����Ѵ�. 
    }
}
