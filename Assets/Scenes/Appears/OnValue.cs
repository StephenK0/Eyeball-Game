using UnityEngine;

public class OnValue : Appear
{
	[SerializeField] Datapoint i;
	private protected override bool Condition(){
		return Data.values[i];
	}
}
