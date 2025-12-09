using UnityEngine;

public class ScreamingsSong : MonoBehaviour
{
    [SerializeField] Animator c;
    void Update()
    {
	if(GameManager.main.GetLevel() == 24 && VolumeSaver.val == 0) Data.values[Datapoint.Heraclesfightready] = true;
	else Destroy(c);
    }
}
