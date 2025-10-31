using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneButton : MonoBehaviour
{
	[SerializeField] string next;

	public void OpenScene(){
		GameManager.StartGame();
		SceneManager.LoadScene(next);
	}

}
