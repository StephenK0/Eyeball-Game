using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	
    public void Unupdate()
    {
        Data.reset();
	SceneManager.LoadScene("Level Complete!");
    }
}
