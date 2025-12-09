using UnityEngine;

public class OnLevel : Appear
{
	[SerializeField] int i;
	private protected override bool Condition(){
		return GameManager.main.GetLevel() == i;
	}
}
