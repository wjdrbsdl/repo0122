using UnityEngine;

/// <summary>
/// 큐브 회전시키는 클래스
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region 필기 내용
    //블라블라브라라
    #endregion

    #region 변수
    public float x;
    public float z;
    private int sample; 
    #endregion

    #region 함수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sample = 10; //private는 내부에서 값 넣기
        Debug.Log(sample);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime,0,z));
    }
    #endregion
}
