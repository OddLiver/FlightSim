using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatricleContrails : MonoBehaviour {

	// Use this for initialization
private ParticleSystem ps;
    public bool worldSpace = true;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var main = ps.main;
        main.startColor = new ParticleSystem.MinMaxGradient(Color.red, Color.yellow);
        main.startSize = 0.1f;
        main.startLifetime = 0.5f;

        var trails = ps.trails;
        trails.enabled = true;

        var psr = GetComponent<ParticleSystemRenderer>();
        psr.trailMaterial = new Material(Shader.Find("Sprites/Default"));
    }

    void Update()
    {
        ps.transform.position = new Vector3(Mathf.Sin(Time.time * 2.0f) * 2.0f, 0.0f, 0.0f);

        var trails = ps.trails;
        trails.worldSpace = worldSpace;
    }

    void OnGUI()
    {
        worldSpace = GUI.Toggle(new Rect(25, 25, 200, 30), worldSpace, "World Space");
    }
}

