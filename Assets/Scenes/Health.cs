using UnityEngine;

public class Health : MonoBehaviour
{
	int size = 4000;
	void Start(){
		size = GameManager.main.savedSize;
	}
	void Update(){
		transform.localScale = new Vector3(1, 1, 1) * (1f * size / 1000);
		Debug.Log("=D");
		size -= GameManager.main.GetLevel() * 10;
		GameManager.main.savedSize = size;
		if(size <= 0) GameManager.EndGame();
	}
	void OnCollisionEnter2D(){
		size += GameManager.main.GetLevel() * 300;
		if(size > 4000) size = 4000;
	}
}
