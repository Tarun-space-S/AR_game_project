using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Explode : MonoBehaviour
{
public GameObject explosion;
public GameObject alienships;
public Aliens alienScript;
private void OnCollisionEnter(Collision collision)
{
if(collision.transform.tag =="Alien")
{
alienships = collision.transform.gameObject;
alienScript = alienships.GetComponent<Aliens>();
if(alienScript)
{
alienScript.DecrementHealth(150);
}
Instantiate(explosion, collision.transform.position,

collision.transform.rotation);

}
}
}