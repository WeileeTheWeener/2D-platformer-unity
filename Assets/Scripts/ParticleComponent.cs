using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(ParticleSystem))]
public class ParticleComponent : MonoBehaviour
{
    public ParticleSystem system;

    public void ExplodeParticles(Vector2 pos)
    {
        // Any parameters we assign in emitParams will override the current system's when we call Emit.
        // Here we will override the start color and size.
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.startColor = Color.red;
        emitParams.startSize = 0.2f;
        //emitParams.position = pos;
        transform.position = pos;
        system.Emit(emitParams, 10);
        system.Play(); // Continue normal emissions
    }
    public void Start()
    {
        system = GetComponent<ParticleSystem>();
    }

}
