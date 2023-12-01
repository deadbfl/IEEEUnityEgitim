using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAppleManager : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private Transform[] spawnPoints;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, spawnPoints.Length);

            Instantiate(applePrefab, spawnPoints[index].position, spawnPoints[index].rotation);
        }
    }
}
