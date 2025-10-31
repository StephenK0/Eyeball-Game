using UnityEngine;

public class RandomResetPosition : MonoBehaviour
{
	private protected void Start(){
		transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-7, 7), 0);
	}
}
