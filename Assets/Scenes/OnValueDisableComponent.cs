using UnityEngine;

public class OnValueDisableComponent : MonoBehaviour
{
    [SerializeField] Component c;
    [SerializeField] Datapoint i;
    void Update()
    {
        if(Data.values[i]){
		Destroy(c);
	}
    }
}
