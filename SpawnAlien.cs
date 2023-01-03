using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnAliens : MonoBehaviour
{
public GameObject spawnShips;
public int numSpawnShips = 3;
public float delayTime = 10.0f;
public GameObject[] gos;
private float countTime = 5.0f;
private int spawnCount = 0;
void Start()
{
}
void Update()
{
countTime -= Time.deltaTime;
if(countTime < 0.5f)
{
if(spawnCount < 6)
{
spawnEnemy(numSpawnShips);
}
countTime = 15.0f;
}
}

void spawnEnemy(int num)
{
gos = new GameObject[10];
for(int i = 0; i< num; i++)
{
GameObject clone = (GameObject)Instantiate(spawnShips,

transform.localPosition, Quaternion.identity);

gos[i] = clone;
}
spawnCount += 3;
}
}