using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool playing = false;
	private int level = 0;
	public int savedSize = 400;
	private int timer = 0;
	public int difficulty;
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
		if(Data.values[Datapoint.easymodep] || Data.values[Datapoint.easymodeP]){ //These should actually be separate. 
			if(main.level % 10 == 0) main.difficulty++;
		}
		else main.difficulty++;
		if(main.level >= 18 && !Data.values[Datapoint.quarterQuash]) main.difficulty += 50;
		main.timer = main.level * 10 + 400;
		main.playing = true;
	}

	private void FixedUpdate(){
		if(playing){
			if(Data.values[Datapoint.paused]){
			timer--;
			if(timer <= 0) {
				PauseGame();
			}
			string s = "level: " + level + "\nTimer: " + timer + "\n";
			//TODO: Add display for how many shots can be fired before the object pooling runs out of space?
			TextDisplay.main.Display(s);
			}
		}
		else{
			if(level > 6) TextDisplay.main.Display("<color=white>level: " + (level) + "\n\n<color=red>Try to keep the eye from closing! \nPress mouse to shoot burning lightning. \n\n are you Ready?");
			else if(level > 4) TextDisplay.main.Display("<color=white>level: " + (level) + "\n\n<color=red>Try to keep the eye from deflating! \nPress mouse to shoot air. \nReady?");
			else TextDisplay.main.Display("level: " + (level + 1) + "\n\nTry to keep the balloon from deflating! \nPress mouse to shoot air. \nReady?");
		}
	}
	public int GetLevel(){
		return level;
	}
	public void resetToThree(){
		level = 2;
		difficulty = 2;
		savedSize = 9000;
		PauseGame();
	}
}
