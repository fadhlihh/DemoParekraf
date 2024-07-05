using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _mazeTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateRight(){
_mazeTransform.Rotate(0,0,-100*Time.deltaTime);
    }

    public void RotateLeft(){
        _mazeTransform.Rotate(0,0,100*Time.deltaTime);
    }
}
