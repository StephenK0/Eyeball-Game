using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
	public static TextDisplay main;
	[SerializeField] TMP_Text text;
	private void Awake(){
		if(main == null) {
			main = this;
		}
	}
	public void Display(string text){
		this.text.text = text;
	}
}
