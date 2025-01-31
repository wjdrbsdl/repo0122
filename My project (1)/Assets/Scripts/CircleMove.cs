using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class CircleMove : MonoBehaviour
{
    //동그라미를 지정한 위치로 Lerp 시키는 클래스

    public GameObject circle; 
    private Vector3 rightPOS = new Vector3(5, -3, 0); //오른쪽 목적지
    private Vector3 firstPos; //시작지점
    private Vector3 currentGoal; //현재 목적지
    [SerializeField] float speed = 3f;
    bool directRight = true; //처음은 오른쪽으로 

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
        //왕복시키기
        if(GoalCheck() == false)
        {
            //목적지 안갔으면 패스
            return;
        }

        if(directRight == true)
        {
            //오른쪽 목적지 도달했으면 왼쪽 시작지점을 목적지로 재설정
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
        Debug.Log(other.name+"부딪");
    }
}
