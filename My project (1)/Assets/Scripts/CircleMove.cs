using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class CircleMove : MonoBehaviour
{
    //���׶�̸� ������ ��ġ�� Lerp ��Ű�� Ŭ����

    public GameObject circle;
    Vector3 goalPOS = new Vector3(5, -3, 0);
    Vector3 firstPos;

    private void Start()
    {
        firstPos = circle.transform.position;
    }

    private void Update()
    {
        //circle.transform.position = Vector3.Lerp(circle.transform.position, goalPOS, Time.deltaTime);
        //0�� �Է��� ��� �ȿ����̰� 1�� �ִ�ġ 

        //circle.transform.position = Vector3.MoveTowards(circle.transform.position, goalPOS, Time.deltaTime);

        circle.transform.position = Vector3.Slerp(circle.transform.position, goalPOS, 0.005f);
    }

}
