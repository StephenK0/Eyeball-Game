using UnityEngine;
using UnityEngine.UI;

public class OnClickToggleValue : MonoBehaviour
{
	[SerializeField] Datapoint i;
	[SerializeField] Button button;

	public void ToggleValue(){
		Debug.Log("Toggled value!");
		Data.values[i] = !Data.values[i];
	}
}
