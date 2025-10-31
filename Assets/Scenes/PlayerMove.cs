using UnityEngine;

public class PlayerMove : Control
{
	private void Update(){
		Vector3 direction = GetDirection();
		transform.Translate(direction * speed * Time.deltaTime);
	}

	public override Vector3 GetDirection(){
		return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;
	}
}
