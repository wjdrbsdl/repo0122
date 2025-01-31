using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(prefab);

        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        //vector3 : 방향과 크기 
        
        //Quaternion : 오브젝트의 3차원 방향을 저장, 한 방향에서 다른 방향으로의 상대적인 회전 값. 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
