using UnityEngine;

/// <summary>
/// ť�� ȸ����Ű�� Ŭ����
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region �ʱ� ����
    //��������
    #endregion

    #region ����
    public float x;
    public float z;
    private int sample; 
    #endregion

    #region �Լ�
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sample = 10; //private�� ���ο��� �� �ֱ�
        Debug.Log(sample);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x * Time.deltaTime,0,z));
    }
    #endregion
}
