using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class ARPlacement : MonoBehaviour
{
public GameObject arObjectToSpawn;
public GameObject placementIndicator;
public GameObject shoot;

private GameObject spawnedObject;
private Pose PlacementPose;
private ARRaycastManager aRRaycastManager;
private bool placementPoseIsValid = false;
private float shootActivateTime = 5.0f;
private float currTime = 100.0f;
void Start()
{
aRRaycastManager = FindObjectOfType<ARRaycastManager>();
shoot.SetActive(false);
}
void Update()
{
if (spawnedObject == null && placementPoseIsValid &&

Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)

{
ARPlaceObject();
currTime = 10.0f;
}
if(currTime < shootActivateTime)
{
shoot.SetActive(true);
}
currTime -= Time.deltaTime;
if(currTime < 0.0f)
{
currTime = 0.0f;
}
UpdatePlacementPose();
UpdatePlacementIndicator();
}
void UpdatePlacementIndicator()
{
if(spawnedObject == null && placementPoseIsValid)

7

{
placementIndicator.SetActive(true);

placementIndicator.transform.SetLocalPositionAndRotation(PlacementPose
.position, PlacementPose.rotation);

}
else
{
placementIndicator.SetActive(false);
}
}
void UpdatePlacementPose()
{
// 0.5 because center of screen.
var screenCenter = Camera.current.ViewportToScreenPoint(new

Vector3(0.5f, 0.5f));

var hits = new List<ARRaycastHit>();
aRRaycastManager.Raycast(screenCenter, hits,

TrackableType.Planes);

placementPoseIsValid = hits.Count > 0;
if (placementPoseIsValid)
{
PlacementPose = hits[0].pose;
}
}
void ARPlaceObject()
{
spawnedObject = Instantiate(arObjectToSpawn,
PlacementPose.position, PlacementPose.rotation);
}
}