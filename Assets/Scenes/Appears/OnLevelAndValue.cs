using UnityEngine;

public class OnLevelAndValue : Appear
{
	[SerializeField] Datapoint i;
	[SerializeField] int level;
	private protected override bool Condition(){
		return Data.values[i] && GameManager.main.GetLevel() == level;
	}
}
