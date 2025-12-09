using UnityEngine;

public class PlayerMove : Control
{
	private void Update(){
		Vector3 direction = GetDirection();
		if(Data.values[Datapoint.speedBoost]) speed = 16;
		if(Data.values[Datapoint.paused]){	transform.Translate(direction * speed * Time.deltaTime);  }
	}

	public override Vector3 GetDirection(){
		return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;
	}
}
