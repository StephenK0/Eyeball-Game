using UnityEngine;

public class Travel : Control
{
	[SerializeField] Transform[] targets;
	int targetIndex;
	private void Start(){
		speed = (GameManager.main.GetLevel() + 3);
	}
	public void Update(){
		if(Data.values[Datapoint.paused]) Move(targets[targetIndex]);
		if(Arrived(targets[targetIndex])) targetIndex--;
		if(targetIndex < 0) targetIndex = targets.Length - 1;
	}
	private void Move(Transform target){
		Vector3 direction = GetDirection();
		transform.Translate(direction * speed * Time.deltaTime);
	}
	private bool Arrived(Transform target){
		return (transform.position - target.position).sqrMagnitude < (speed * speed * Time.deltaTime * Time.deltaTime); 
	}

	public override Vector3 GetDirection(){
		Transform target = targets[targetIndex];
		return (target.position - transform.position).normalized;
	}
}
