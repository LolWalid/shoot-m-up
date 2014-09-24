using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public int speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		WeaponScript weaponScript = (WeaponScript) gameObject.GetComponent("WeaponScript");

		if (Input.GetKey("up"))
			transform.position += new Vector3(0,speed * Time.deltaTime,0);
		if (Input.GetKey("down"))
			transform.position += new Vector3(0,- speed * Time.deltaTime,0);
		if (Input.GetKey("right"))
			transform.position += new Vector3(speed *Time.deltaTime,0,0);
		if (Input.GetKey("left"))
			transform.position += new Vector3(- speed *Time.deltaTime,0,0);
		if (Input.GetButtonDown("Fire1"))
			weaponScript.Attack (false);

	}
}
