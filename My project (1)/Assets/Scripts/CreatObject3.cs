using NUnit.Framework;
using System.Linq.Expressions;
using UnityEngine;
using System.Collections.Generic;

public class CreatObject3 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private int dummy;
    [SerializeField] private GameObject sample;

    private void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Table_Body");

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sample = Instantiate(prefab);
            sample.AddComponent<VectorSample>();
        }
    }
}
