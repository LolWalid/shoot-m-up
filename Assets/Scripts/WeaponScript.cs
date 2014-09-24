using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {
	public GameObject shot;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Attack(bool isEnemy) {
		GameObject fire = (GameObject) GameObject.Instantiate(shot,transform.position,transform.rotation);
		ShotScript shotScript = (ShotScript) fire.GetComponent("ShotScript");

		shotScript.fromEnemy = isEnemy;
		MoveScript moveScript = (MoveScript) fire.GetComponent("MoveScript");
		moveScript.direction = new Vector2(1f,0f);
	}
}
