using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWaveScript : MonoBehaviour
{
    [SerializeField] private float countdown;
    [SerializeField] private GameObject spawnPoint;
    

    public Wave[] waves;

    public int waveIndex = 0;

    private bool readyToCountDown;

    private void Start()
    {
        readyToCountDown = true;

        for (int i = 0; i < waves.Length; i++)
        {
            waves[i].targetsLeft = waves[i].targets.Length;
        }
    }

    private void Update()
    {
        if (waveIndex >= waves.Length)
        {
            Debug.Log("All Targets Down!");
            return;
        }

        if (readyToCountDown == true)
        {
            countdown -= Time.deltaTime;
        }

        if (countdown <= 0)
        {
            readyToCountDown = false;

            countdown = waves[waveIndex].timeToNextWave;
            StartCoroutine(SpawnWave());
        }

        if (waves[waveIndex].targetsLeft == 0)
        {
            readyToCountDown = true;

            waveIndex++;
        }
    }
    private IEnumerator SpawnWave()
    {

        if (waveIndex < waves.Length)
        {
            for (int i = 0; i < waves[waveIndex].targets.Length; i++)
            {
                MoveTargets target = Instantiate(waves[waveIndex].targets[i], spawnPoint.transform);
                Instantiate(waves[waveIndex].targets[i], spawnPoint.transform);

                yield return new WaitForSeconds(waves[waveIndex].timeToNextTarget);

            }
        }

    }
}

[System.Serializable]

public class Wave
{
    public MoveTargets[] targets;
    public float timeToNextTarget;
    public float timeToNextWave;

    [HideInInspector] public int targetsLeft;
}
