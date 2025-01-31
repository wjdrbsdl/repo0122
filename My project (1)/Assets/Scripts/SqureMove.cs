using UnityEngine;

public class SqureMove : MonoBehaviour
{
    public GameObject circle;
    [SerializeField] private Transform downPos; //도착지
    private Vector3 firstPos; //시작지점
    private Vector3 currentGoal; //현재 목적지
    [SerializeField] float speed = 3f;
    bool directDown = true; //처음은 오른쪽으로 

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
        //왕복시키기
        if (GoalCheck() == false)
        {
            //목적지 안갔으면 패스
            return;
        }

        if (directDown == true)
        {
            // 목적지 도달했으면  시작지점을 목적지로 재설정
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
