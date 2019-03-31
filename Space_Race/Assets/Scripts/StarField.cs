using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarField : MonoBehaviour
{
	private Transform tx;

	// Field of particles
	private ParticleSystem.Particle[] points;

	public int starsMax = 100;
	public float starSize = 1;
	public float starDistance = 10;
	private float starDistanceSqr;

    // Start is called before the first frame update
    void Start()
    {
		// Better for performance
		tx = transform;
		starDistanceSqr = starDistance * starDistance;
    }

	private void createStarField() {
		points = new ParticleSystem.Particle[starsMax];

		for (int i = 0; i < starsMax; i++) {
			// insideUnitSphere => particles spawn around a camera inside a sphere dist
			points [i].position = Random.insideUnitSphere * starDistance;
			points[i].color = new Color(1,1,1,1);
			points[i].size = starSize;
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (points == null) {
			createStarField ();
		} 

		for (int i = 0; i < starsMax; i++) {
			// dist star -> camera => star too far away
			if ((points [i].position - tx.position).sqrMagnitude > starDistanceSqr) {
				points [i].position = Random.insideUnitSphere * starDistance + tx.position;
			}
		}


		GetComponent<ParticleSystem>().SetParticles (points, points.Length);
    }
}
