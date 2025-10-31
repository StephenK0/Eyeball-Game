using UnityEngine;

public class PooledPin : Pooled
{
	[SerializeField] private int timerReset;

	int vanishTimer = 0;
	
	[SerializeField] float speed = 0.01f;
	private void FixedUpdate(){
		if(transform.parent != hidden){ 
			transform.Translate(new Vector3(1, 0, 0) * speed);
			vanishTimer--;
			if(vanishTimer <= 0){
				DestroyStuff(this);
			}
		}
	}

	private protected override void OnStart(){
		vanishTimer = timerReset;
	}
}
