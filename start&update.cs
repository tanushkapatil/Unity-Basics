using Unity.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(1, 0, 0) ; moves in pop
        //Translate(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.01f, 0f, 0f) ;
    }
}