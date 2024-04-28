using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wufundershienaldow : MonoBehaviour
{
    public float health = 9.99999999999999999991234567894269f;
    public int level = 1;
    public float speed = 3.1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(+speed * Time.deltaTime, 0, 0);
    }
}
