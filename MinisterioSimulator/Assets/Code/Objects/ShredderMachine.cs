using UnityEngine;
using System.Collections;

public class ShredderMachine : MonoBehaviour {

    Animator shredderAnimator;
    ParticleSystem shrededParticles;
    public float shredAnimationTime = 1.0f;
    public float shredSpeedMofifier = 2.0f;

	void Start () {
        shredderAnimator = transform.GetChild(0).GetComponent<Animator>();
        shrededParticles = transform.GetChild(0).GetChild(0).GetComponent<ParticleSystem>();
        shrededParticles.Stop();
    }

    /*
    private void Update() {
        if (Input.GetKeyUp(KeyCode.T)) {
            PlayShredAnimation();
        }
    }
    */

    public void PlayShredAnimation() {
        shredderAnimator.SetFloat("speed", shredSpeedMofifier);
        EmitParticles();
    }

    private void EmitParticles() {
        shrededParticles.Play();
        StartCoroutine(WaitActionCoroutine(shredAnimationTime));
    }

    IEnumerator WaitActionCoroutine(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        shrededParticles.Stop();
        shredderAnimator.SetFloat("speed", 1.0f);
    }

}
