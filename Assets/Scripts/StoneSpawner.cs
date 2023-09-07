using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
    [Header("Spawn")]

    [SerializeField] private Stone stotePrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float spawnRate;
    [SerializeField] private int amount;

    private float timer;
    private float amountSpawned;

    private void Start()
    {
        timer = spawnRate;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            Spawn();
            timer = 0;
        }
    }

    private void Spawn()
    {
        Stone stone = Instantiate(stotePrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
        stone.SetSize((Stone.Size)(Random.Range(1, 4)));
        amountSpawned++;
    }
}
