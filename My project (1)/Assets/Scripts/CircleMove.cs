using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class CircleMove : MonoBehaviour
{
    //동그라미를 지정한 위치로 Lerp 시키는 클래스

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
        //0을 입력할 경우 안움직이고 1이 최대치 

        //circle.transform.position = Vector3.MoveTowards(circle.transform.position, goalPOS, Time.deltaTime);

        circle.transform.position = Vector3.Slerp(circle.transform.position, goalPOS, 0.005f);
    }

}
