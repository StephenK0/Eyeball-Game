using UnityEngine;

public class FilesOpenDuringLevel : MonoBehaviour
{
	[SerializeField] int level;
	[SerializeField] Datapoint whatToActivate;
	void Update()
	{
		if(GameManager.main.GetLevel() == level) {
			Data.values[whatToActivate] = true;
			if(!Data.values[Datapoint.menu] && Data.values[Datapoint.notes]) Data.values[whatToActivate] = false;
		}
	}
}
