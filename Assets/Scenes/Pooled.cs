using System.Collections.Generic;
using UnityEngine;

//Object Pooling! >w<
public abstract class Pooled : MonoBehaviour
{
	protected static Transform hidden;
	[SerializeField] Transform hiddenCandidate;
	static Queue <Pooled> pool;
	static Queue <Pooled> buffer;
	public static int TIMER_RESET = 30;
	private static int timer = 3;

	public static void CreateGet(Vector3 pos, Transform t, Quaternion rot){
		if(pool.Count > 0){
			while(pool.Peek() == null) pool.Dequeue();
			Pooled p = pool.Dequeue();
			p.gameObject.transform.SetParent(t);
			p.gameObject.transform.position = pos;
			p.gameObject.transform.rotation = rot;
			p.gameObject.SetActive(true);
			p.Start();
		}
		else{
			if(timer == 0){
				if(buffer.Count > 0){
					Pooled q = buffer.Dequeue();
					pool.Enqueue(q);
				}
				timer = TIMER_RESET;
			}
			else{
				timer--;
			}
		}
	}


	protected void Awake(){
		if(pool == null) pool = new Queue<Pooled>();
		if(buffer == null) buffer = new Queue<Pooled>();
		if(hidden == null) hidden = hiddenCandidate;
	}
	protected void Start(){
		Debug.Log(pool);
		pool.Enqueue(this);
		OnStart();
	}

	private protected abstract void OnStart();

	public static void DestroyStuff(Pooled p){
		p.gameObject.transform.SetParent(hidden);
		if(pool.Count > 0) pool.Enqueue(p);
		else buffer.Enqueue(p);
		p.gameObject.SetActive(false);
	}

	public static int HowManyPooled(){
		return pool.Count;
	}
}
