using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{   
    public GameObject jalan;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1f);
    }
    void CreateObstacle()
    {
        Instantiate (jalan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
