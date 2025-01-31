using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class CircleMove : MonoBehaviour
{
    //���׶�̸� ������ ��ġ�� Lerp ��Ű�� Ŭ����

    public GameObject circle; 
    private Vector3 rightPOS = new Vector3(5, -3, 0); //������ ������
    private Vector3 firstPos; //��������
    private Vector3 currentGoal; //���� ������
    [SerializeField] float speed = 3f;
    bool directRight = true; //ó���� ���������� 

    private void Start()
    {
        firstPos = circle.transform.position;
        currentGoal = rightPOS;
    }

    private void Update()
    {
        circle.transform.position = Vector3.MoveTowards(circle.transform.position, currentGoal, Time.deltaTime*speed);
        RoundTrip();
    }

    private void RoundTrip()
    {
        //�պ���Ű��
        if(GoalCheck() == false)
        {
            //������ �Ȱ����� �н�
            return;
        }

        if(directRight == true)
        {
            //������ ������ ���������� ���� ���������� �������� �缳��
            currentGoal = firstPos;
            directRight = false;
        }
        else
        {
            currentGoal = rightPOS;
            directRight = true;
        }

    }

    private bool GoalCheck()
    {
        if(Vector3.Distance(circle.transform.position, currentGoal) <= 0.5f)
        {
            return true;
        }
        return false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.name == "Sqaure") 
        Debug.Log(other.name+"�ε�");
    }
}
