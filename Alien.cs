using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Aliens : MonoBehaviour
{
private float Health;
public float maxHealth = 150.0f;
public float moveTime = 5.0f;
private float currTime = 10.0f;
void Start()
{
Health = maxHealth;
}
// Alien should move after sometime.

8

SCORE : 0
TIME : 0s
void Update()
{
currTime += Time.deltaTime;
if(currTime > moveTime)
{
float randlocx = Random.Range(-1.0f, 1.0f);
float randlocy = Random.Range(-1.0f, 1.0f);
float randlocz = Random.Range(-1.0f, 1.0f);
transform.Translate(randlocx, randlocy, randlocz);
currTime = 0.0f;
}
}
public void DecrementHealth(float Amount)
{
if(Health - Amount > 0.0f)
{
Health = Health - Amount;
}
else
{
Health = 0.0f;
Destroy(this);
}
}
}