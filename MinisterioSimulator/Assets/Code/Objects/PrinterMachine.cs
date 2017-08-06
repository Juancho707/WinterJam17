using System.Collections;
using UnityEngine;

public class PrinterMachine : MonoBehaviour {

    Animator printerAnimator;
    ParticleSystem smokeParticles;
    float particleEmissionTime = 1.0f;

    void Start() {
        printerAnimator = transform.GetChild(0).GetComponent<Animator>();
        
        smokeParticles = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<ParticleSystem>();
        smokeParticles.Stop();
        
    }

    /*
    private void Update() {
        if (Input.GetKeyUp(KeyCode.T)) {
            PlayPrintAnimation();
        }
    }
    */

    public void PlayPrintAnimation() {
        //printerAnimator.SetFloat("speed", shredSpeedMofifier);
        printerAnimator.SetTrigger("print");
        EmitParticles();
    }

    private void EmitParticles() {
        smokeParticles.Play();
        StartCoroutine(WaitActionCoroutine(particleEmissionTime));
    }

    IEnumerator WaitActionCoroutine(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        smokeParticles.Stop();
    }
}
