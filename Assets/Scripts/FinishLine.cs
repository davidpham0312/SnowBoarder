using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayDuration = 1.5f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            finishEffect.Play();
            Invoke("ReloadScene", delayDuration);
        }
        
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
