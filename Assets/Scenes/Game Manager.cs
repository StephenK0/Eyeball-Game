using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool playing = false;
	private int level = 0;
	public int savedSize = 4000;
	private int timer = 0;
	public static GameManager main;
	private void Awake(){
		if(main == null) {
			main = this;
			DontDestroyOnLoad(this.gameObject);
		}
		else Destroy(this.gameObject);
	}

	public static void EndGame(){
		SceneManager.LoadScene("END");
		Destroy(main.gameObject);
	}
	public static void PauseGame(){
		main.playing = false;
		SceneManager.LoadScene("Level Complete!");
		Resources.UnloadUnusedAssets();
	}
	public static void StartGame(){
		main.level++;
		main.timer = main.level * 100 + 4000;
		main.playing = true;
	}

	private void Update(){
		if(playing){
			timer--;
			if(timer <= 0) {
				PauseGame();
			}
			string s = "level: " + level + "\nTimer: " + timer + "\n";
			//TODO: Add display for how many shots can be fired before the object pooling runs out of space?
			TextDisplay.main.Display(s);
		}
		else{
			if(level > 6) TextDisplay.main.Display("<color=white>level: " + (level + 1) + "\n\n<color=maroon>Try to keep the eye from closing! \nPress space to shoot burning lightning. \n\n are you Ready?");
			else if(level > 4) TextDisplay.main.Display("<color=white>level: " + (level + 1) + "\n\n<color=maroon>Try to keep the eye from deflating! \nPress space to shoot air. \nReady?");
			else TextDisplay.main.Display("level: " + (level + 1) + "\n\nTry to keep the balloon from deflating! \nPress space to shoot air. \nReady?");
		}
	}
	public int GetLevel(){
		return level;
	}
}
