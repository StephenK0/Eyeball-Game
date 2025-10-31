using UnityEngine;

public class TurnOnDirection : MonoBehaviour
{
	[SerializeField] Control control;
	private SpriteRenderer s;
	void Awake(){
		//TODO: Add Null Checks!
		s = gameObject.GetComponent<SpriteRenderer>();
	}
	void Update(){
		FlipSprite();
	}
		
	void FlipSprite(){
		Vector3 direction = control.GetDirection();
		s.flipX = direction.x < 0; 
		s.flipY = direction.y < 0; 
	}
}
