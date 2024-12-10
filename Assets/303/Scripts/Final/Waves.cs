using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public TextMeshProUGUI waveCountText;
    int waveCount = 0;

    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3f;

    public int targetCount;

    public GameObject target;

    bool waveIsDone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waveCountText.text = "Wave" + waveCount.ToString();

        if (waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }

    IEnumerator waveSpawner()
    {
        waveIsDone = false;

        for (int i = 0; i < targetCount; i++)
        {
            GameObject enemyClone = Instantiate(target);

            yield return new WaitForSeconds(spawnRate);
        }

        spawnRate -= 0.1f;
        targetCount += 3;
        waveCount += 1;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}
