using UnityEngine;

public class SqureMove : MonoBehaviour
{
    public GameObject circle;
    [SerializeField] private Transform downPos; //������
    private Vector3 firstPos; //��������
    private Vector3 currentGoal; //���� ������
    [SerializeField] float speed = 3f;
    bool directDown = true; //ó���� ���������� 

    private void Start()
    {
        firstPos = circle.transform.position;
        currentGoal = downPos.position;
    }

    private void Update()
    {
        circle.transform.position = Vector3.MoveTowards(circle.transform.position, currentGoal, Time.deltaTime * speed);
        RoundTrip();
    }

    private void RoundTrip()
    {
        //�պ���Ű��
        if (GoalCheck() == false)
        {
            //������ �Ȱ����� �н�
            return;
        }

        if (directDown == true)
        {
            // ������ ����������  ���������� �������� �缳��
            currentGoal = firstPos;
            directDown = false;
        }
        else
        {
            currentGoal = downPos.position;
            directDown = true;
        }

    }

    private bool GoalCheck()
    {
        if (Vector3.Distance(circle.transform.position, currentGoal) <= 0.5f)
        {
            return true;
        }
        return false;
    }
}
