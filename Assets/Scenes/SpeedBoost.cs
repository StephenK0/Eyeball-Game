using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
		public void Update(){
		if(GameManager.main.GetLevel() == 12 && !Data.values[Datapoint.easymodep] && !Data.values[Datapoint.easymodeP] && !Data.values[Datapoint.quarterQuash]) Data.values[Datapoint.speedBoost] = true;

	}
}
