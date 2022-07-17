using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if ((other.gameObject.tag == "Ground")){
            dustParticles.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if ((other.gameObject.tag == "Ground")){
            dustParticles.Pause();
        }
    }
}
