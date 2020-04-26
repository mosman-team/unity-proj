using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;

    [SerializeField] Attacker[] attakerPrefabs;

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        do
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));

            SpawnAttacker();
        
        } while (spawn);
    }

    void SpawnAttacker()
    {
        int index = UnityEngine.Random.Range(0, attakerPrefabs.Length);
        Spawn(index);
    }
    void Spawn(int index)
    {
        Attacker newAttacker = Instantiate(attakerPrefabs[index], transform.position, Quaternion.identity);
        newAttacker.transform.parent = transform;
    }
    public void SetSpawn(bool b)
    {
        spawn = b;
    }
}


















