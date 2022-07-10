using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayDuration = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground"){
            crashEffect.Play();
            Invoke("ReloadScene", delayDuration);
        }
        
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
    
}
