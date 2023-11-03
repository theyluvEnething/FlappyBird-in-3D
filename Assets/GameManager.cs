using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform PipeSpawner;
    [SerializeField] private GameObject PipePrefab;
    [SerializeField, Range(0f, 2f)] private float SpawnTime = 1.5f;

    private float lastTime = 0f;

    void Update()
    {
        if (lastTime > SpawnTime)
        {
            lastTime = 0;
            Vector3 randomOffset = new Vector3(0f, Random.Range(0f, 5f), Random.Range(-2f, 2f));
            Instantiate(PipePrefab, PipeSpawner.position + randomOffset, Quaternion.identity);
        }
        lastTime += Time.deltaTime;
    }
}
