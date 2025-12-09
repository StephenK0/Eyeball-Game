using UnityEngine;
using System.Collections.Generic;

public class TypeKyle : MonoBehaviour
{
	[SerializeField] List<KeyCode> s;
	[SerializeField] Datapoint whatToActivate;
	[SerializeField] int stage;
	int index = 0;
	void Update(){
		if(GameManager.main.GetLevel() == stage){
		if(index >= s.Count) {
			Data.values[whatToActivate] = true;
		}
		else if(Input.GetKey(s[index])) index++;
		}
	}
}
