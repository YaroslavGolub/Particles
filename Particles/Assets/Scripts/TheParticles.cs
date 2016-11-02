using UnityEngine;
using System.Collections;

public class TheParticles : MonoBehaviour
{

	private ParticleSystem hitParticles;

	private void Awake ()
	{
		hitParticles = GetComponentInChildren<ParticleSystem>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			PlayParticles();
		}
	}

	private void PlayParticles()
	{
		hitParticles.Play();
	}
	
	
}
