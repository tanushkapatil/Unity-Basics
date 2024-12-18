using Unity.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float xValue = 0.001f ; //movement speed on that axis 
    //SerializeField helps set value in unity
    [SerializeField]float yValue = 0f ;
    [SerializeField]float zValue = 0f ;
    //To control the object + and - help in moving object towards or away from the camera

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.Translate(1, 0, 0) ; moves in pop
        //Translate(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue) ;
    }
}
