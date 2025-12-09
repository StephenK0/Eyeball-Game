using UnityEngine;

public class KyleLastWarning : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
//        if(GameManager.main.GetLevel() == 56 && VolumeSaver.val != 0 && !Data.values[Datapoint.notes]) {
	Debug.Log(GameManager.main.GetLevel() == 2);
	Debug.Log(VolumeSaver.val != 0);
	Debug.Log(!Data.values[Datapoint.notes]); 
	if(GameManager.main.GetLevel() == 56 && VolumeSaver.val != 0 && !Data.values[Datapoint.notes]) {
		Debug.Log("=D");
		Data.values[Datapoint.Kyle] = true;
		NotesSaver.val += "Hi. I'm Kyle. If you're seeing this, it means you've seen my code. Heracles and I, we were doing research on the lower floors... We found something we shouldn't have. I'm trusting you with this. Run. Add my code to Heracles, you'll know what to do with the rest. I'm trusting you. I'm trusting  you. Take it. Run.";
		Destroy(this.gameObject);
	}
    }
}
