using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NotesSaver : MonoBehaviour
{
	[SerializeField] TMP_InputField text;
	public static string val;
	void Awake(){
		text.text = val;
	}
	void Update(){
		val = text.text;
	}
}
