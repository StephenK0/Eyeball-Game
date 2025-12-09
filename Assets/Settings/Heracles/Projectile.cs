using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 1, 0) * 0.01f);
    }

    void OnTriggerEnter2D(Collider2D other){ 
	    if(other.gameObject.name == "Player") Destroy(this); 
	    Health health = other.GetComponent<Health>();
	    if(health != null)health.hurt();
    }
}
