using UnityEngine;

public class PressKeyOnStage : MonoBehaviour
{
	[SerializeField] KeyCode key;
[SerializeField] int level;
	[SerializeField] Datapoint whatToActivate;
	[SerializeField] bool turnOn = true;
	void Update(){
		if(Input.GetKey(key) && GameManager.main.GetLevel() == level) {Data.values[whatToActivate] = turnOn; Debug.Log("Pressed key " + key); }
	}
}
