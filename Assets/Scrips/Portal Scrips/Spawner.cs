using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("prueba", 1f);
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void prueba()
    {
        Instantiate(Ball, transform);
    }
}
