using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits;
	public Sprite[] hitSprites;

	private int timesHit;
	private LevelManager levelmanager;
	// Use this for initialization
	void Start () {

		timesHit=0;
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void OnCollisionEnter2D (Collision2D col)
	{		
		timesHit++;
		if (timesHit >= maxHits) 
			Destroy (gameObject);
		else {
			print("COLLISION");
			LoadSprites();
		}
	}
	void LoadSprites ()
	{
		int spriteIndex=timesHit-1;//hit once
		this.GetComponent<SpriteRenderer>().sprite=hitSprites[spriteIndex];

	}

	//TODO Remove this method once we can actually win
	void SimulateWin ()
	{
		levelmanager.LoadNextLevel();
	} 
}
