using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BuffSaver : MonoBehaviour
{
	[SerializeField] Toggle toggle;
	static bool val;
	void Awake(){
		toggle.isOn = val;
	}
	void Update(){
		val = toggle.isOn;
		Data.values[Datapoint.HeraclesBuff] = toggle.isOn;
	}
}
