using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    [SerializeField]
    private Transform _squareTransform;
    // Start is called before the first frame update
    void Start()
    {
_squareTransform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
