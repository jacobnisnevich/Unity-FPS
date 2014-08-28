using UnityEngine;
using System.Collections;

public class FPShooting : MonoBehaviour {

	public GameObject bullet_prefab;
	public Texture2D crosshairImage;
	float bulletImpulse = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Camera cam = transform.FindChild ("Main Camera").camera;
			GameObject theBullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position, cam.transform.rotation);
			theBullet.rigidbody.AddForce(cam.transform.forward * bulletImpulse, ForceMode.Impulse);
		}
	}

	void OnGUI()
	{
		float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
		float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
	}
}
