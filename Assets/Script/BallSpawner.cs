using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _ball;

    private void Start()
    {
        // Menentukan posisi spawn
Vector3 spawnPosition = new Vector3(2.88f, 1.78f, 0);

// Menentukan rotasi spawn
Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);

// Spawn object dengan posisi dan rotasi tertentu
Instantiate(_ball, spawnPosition, spawnRotation);
    }
}
