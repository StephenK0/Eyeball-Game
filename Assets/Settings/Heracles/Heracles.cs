using UnityEngine;

public class Heracles : MonoBehaviour
{
    int timer = 100;
    [SerializeField] GameObject Projectile;
    // Update is called once per frame
    void FixedUpdate()
    {
        timer--;
	if(timer == 0) {
		timer = 100;
		Instantiate(Projectile, transform.position, transform.rotation);
	}
    }
}
