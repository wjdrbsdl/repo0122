using UnityEngine;

public class CreatObject2 : MonoBehaviour
{
    public GameObject prefab;

    private GameObject square;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        square = Instantiate(prefab);

        Destroy(square, 3.0f);
        Debug.Log("ÆÄ±«µÊ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
