using UnityEngine;
using System.Collections;

public class PBuilder : MonoBehaviour {
	public float plattformSize;
	public GameObject plattform;
	public GameObject halt;
	public GameObject quer;
	private float haltPos = 0.65f;
	private float querPos = 1.29f;
	// Use this for initialization
	void Start () {
		GameObject newPlattform =  (GameObject) GameObject.Instantiate(plattform,transform.position,transform.rotation);
		newPlattform.transform.localScale = new Vector3(plattformSize,0.1f,plattformSize);
		newPlattform.SetActive(true);
		//Haltebalcken
		GameObject new1Halt =  (GameObject) GameObject.Instantiate(halt,new Vector3(plattformSize/2f,haltPos,plattformSize/2f),Quaternion.Euler(90f,0,0));
		new1Halt.SetActive(true);
		GameObject new2Halt =  (GameObject) GameObject.Instantiate(halt,new Vector3(plattformSize/-2f,haltPos,plattformSize/2f),Quaternion.Euler(90f,0,0));
		new2Halt.SetActive(true);
		GameObject new3Halt =  (GameObject) GameObject.Instantiate(halt,new Vector3(plattformSize/2f,haltPos,plattformSize/-2f),Quaternion.Euler(90f,0,0));
		new3Halt.SetActive(true);
		GameObject new4Halt =  (GameObject) GameObject.Instantiate(halt,new Vector3(plattformSize/-2f,haltPos,plattformSize/-2f),Quaternion.Euler(90f,0,0));
		new4Halt.SetActive(true);
		//Querbalcken unten
		GameObject new1Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(plattformSize/2f,haltPos,0f),Quaternion.Euler(0f,0,0));
		new1Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new1Quer.SetActive(true);
		GameObject new2Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(plattformSize/-2f,haltPos,0f),Quaternion.Euler(0f,0,0));
		new2Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new2Quer.SetActive(true);
		GameObject new3Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(0f,haltPos,plattformSize/2f),Quaternion.Euler(0,90,0));
		new3Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new3Quer.SetActive(true);
		GameObject new4Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(0f,haltPos,plattformSize/-2f),Quaternion.Euler(0,90,0));
		new4Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new4Quer.SetActive(true);
		//Querbalcken oben
		GameObject new5Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(plattformSize/2f,querPos,0f),Quaternion.Euler(0f,0,0));
		new5Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new5Quer.SetActive(true);
		GameObject new6Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(plattformSize/-2f,querPos,0f),Quaternion.Euler(0f,0,0));
		new6Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new6Quer.SetActive(true);
		GameObject new7Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(0f,querPos,plattformSize/2f),Quaternion.Euler(0,90,0));
		new7Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new7Quer.SetActive(true);
		GameObject new8Quer =  (GameObject) GameObject.Instantiate(quer,new Vector3(0f,querPos,plattformSize/-2f),Quaternion.Euler(0,90,0));
		new8Quer.transform.localScale = new Vector3(0.02f,0.02f,plattformSize);
		new8Quer.SetActive(true);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
