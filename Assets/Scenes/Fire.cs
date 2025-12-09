using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour {
	[SerializeField] private Transform environment;
	private void Update(){
		if(Input.GetButtonDown("Fire1") && Data.values[Datapoint.paused]){
			Vector2 mousePos = new Vector2(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2);
			float angle = Vector2.SignedAngle(Vector2.right, mousePos);
			Pooled.CreateGet(transform.position, environment, Quaternion.Euler(0, 0, angle));
		}
	}
}
