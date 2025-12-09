using UnityEngine;

public abstract class Appear : MonoBehaviour
{
	
	Vector3 pos;
	void Start(){
		pos = transform.position;
	}
	void Update()
	{
		if(Condition()) transform.position = pos;
		else transform.position = new Vector3(-999, 0, 0); //Yes, this is really bad. 
	}

	abstract private protected bool Condition();
}
