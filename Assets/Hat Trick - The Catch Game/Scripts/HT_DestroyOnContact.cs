using UnityEngine;
using System.Collections;

public class HT_DestroyOnContact : MonoBehaviour
{
	private HT_GameController GM;

	private void Start()
	{
		GM = GameObject.FindObjectOfType<HT_GameController>();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		Destroy (other.gameObject);
	}
}
