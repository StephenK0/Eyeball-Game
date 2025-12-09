using UnityEngine;

public class KeyPressedOnCondition : MonoBehaviour
{
	[SerializeField] KeyCode key;
	[SerializeField] Datapoint whatToCheck;
	[SerializeField] Datapoint whatToActivate;
	[SerializeField] bool turnOn = true;

	void Update(){
		if(Input.GetKey(key) && Data.values[whatToCheck]) {Data.values[whatToActivate] = turnOn; Debug.Log("Pressed key " + key); }
	}
}
