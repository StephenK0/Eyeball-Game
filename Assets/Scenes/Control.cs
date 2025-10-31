using UnityEngine;

public abstract class Control : MonoBehaviour
{
	[SerializeField] private protected float speed = 1;
	public abstract Vector3 GetDirection();
}
