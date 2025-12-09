using UnityEngine;
using System.Collections.Generic;

public class Data : MonoBehaviour
{
	public static Dictionary<Datapoint, bool> values;
	private void Awake(){
		if(values == null) {
			reset();
		}
	}

	public static void reset(){
			values = new Dictionary<Datapoint, bool>();
			foreach(Datapoint d in Datapoint.GetValues(typeof(Datapoint))) values.TryAdd(d, false);
			values[Datapoint.paused] = true;
	}
}

public enum Datapoint{
	menu,
	notes,
	volume,
	easymodeP, 
	easymodep, 
	quarterQuash,
	Heraclesfightready,
	setupForMajorJoke,
	SIX_SEVEN,
	HeraclesBuff,
	paused,
	convolutedSecret,
	speedBoost,
	Kyle
}
