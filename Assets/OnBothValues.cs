using UnityEngine;

public class OnBothValues : OnValue
{
	[SerializeField] Datapoint i2;
	private protected override bool Condition(){
		return base.Condition() && Data.values[i2];
	}
}
