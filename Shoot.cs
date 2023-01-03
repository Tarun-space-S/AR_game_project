using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shoot : MonoBehaviour
{
public Transform arCamera;
public GameObject projectile;
public float shootforce = 700.0f;
RaycastHit hit;
void Update()
{
if (Input.touchCount > 0 && Input.GetTouch(0).phase ==

TouchPhase.Began)

{
GameObject bullet = Instantiate(projectile,
arCamera.position, arCamera.rotation) as GameObject;
bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward *
shootforce);
}
}
}