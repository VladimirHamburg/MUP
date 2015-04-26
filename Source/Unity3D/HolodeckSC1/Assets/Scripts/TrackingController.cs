using UnityEngine;
using System.Collections;
using TrackingClassLibrary;
using System.Collections.Generic;
using System;
using TrackingClassLibrary.Marker;

[Serializable]
public struct Entry
{
    public GameObject go;
    public int trackID;

}
public class TrackingController : MonoBehaviour {

    private Tracker tracker;
    public string address = "230.230.230.230";
    public int port = 5230;
    public Dictionary<GameObject, int> registerObj = new Dictionary<GameObject,int>();
    public Entry[] registerObjects;
	void Start () {
        tracker = new Tracker(address, port);
        tracker.Start();
        for (int i = 0; i < registerObjects.Length; i++)
        {
            Register(registerObjects[i].go, registerObjects[i].trackID);
		}
	}
	
	void Update () {
        foreach (var item in registerObj)
        {
            IMarker m = tracker[item.Value];
            item.Key.transform.position = new Vector3((float)(m.X/1000),(float)(m.Z/1000),(float)(m.Y/1000));
            item.Key.transform.rotation = 
                Quaternion.LookRotation(new Vector3((float)m.Rotationmatrix[1][0], (float)m.Rotationmatrix[1][2], (float)m.Rotationmatrix[1][1]),
                new Vector3((float)m.Rotationmatrix[2][0], (float)m.Rotationmatrix[2][2], (float)m.Rotationmatrix[2][1]));
        }
	}

    public void Register(GameObject gameObject, int trackID)
    {
        registerObj[gameObject] = trackID;
    }

    public void UnRegister(GameObject gameObject)
    {
        registerObj.Remove(gameObject);
    }

    public Vector3 PositionFor(int trackID)
    {
        IMarker m = tracker[trackID];
        return new Vector3((float)(m.X / 1000), (float)(m.Z / 1000), (float)(m.Y / 1000));
    }

    public Quaternion RotationFor(int trackID)
    {
        IMarker m = tracker[trackID];
        return Quaternion.LookRotation(new Vector3((float)m.Rotationmatrix[1][0], (float)m.Rotationmatrix[1][2], (float)m.Rotationmatrix[1][1]),
                new Vector3((float)m.Rotationmatrix[2][0], (float)m.Rotationmatrix[2][2], (float)m.Rotationmatrix[2][1]));
    }

}
