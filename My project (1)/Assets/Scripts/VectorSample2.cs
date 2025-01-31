using UnityEngine;

public class VectorSample2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1. 정규화
        Vector3 origin = new Vector3(3, 5, 7);
        Vector3 nomalOrigin = origin.normalized;

        //2. 거리계산
        Vector3 posA = new Vector3(3, 4, 5);
        Vector3 posB = new Vector3(5, 1, 2);

        float distance = Vector3.Distance(posA, posB);

        //3. 보간
        Vector3 lerpResult = Vector3.Lerp(posA, posB, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
