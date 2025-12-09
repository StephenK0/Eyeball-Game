using UnityEngine;
using UnityEngine.UI;

public class VolumeSaver : MonoBehaviour
{
	[SerializeField] Slider slider;
	public static float val = 1;
	void Awake(){
		Debug.Log(val);
		slider.value = val;
	}
	void Update(){
		val = slider.value;
		Debug.Log(val);
	}
}
