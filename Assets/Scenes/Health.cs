using UnityEngine;

public class Health : MonoBehaviour
{
	int size = 4000;
	void Start(){
		size = GameManager.main.savedSize;
	}
	void FixedUpdate(){
		transform.localScale = new Vector3(1, 1, 1) * (1f * size / 1000);
		if(Data.values[Datapoint.paused]) size -= GameManager.main.difficulty * 1;
		GameManager.main.savedSize = size;
		if(size <= 0){
			if(GameManager.main.GetLevel() == 16) {
				GameManager.main.resetToThree();
			}
			else GameManager.EndGame();
		}
	}
	void OnCollisionEnter2D(){
		size += GameManager.main.GetLevel() * 300;
		if(size > 4000) size = 4000;
	}
	public void hurt(){
		size --;
	}
}
