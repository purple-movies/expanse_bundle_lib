using UnityEngine;

public class ToggleParticleFlow : MonoBehaviour
{
    ParticleSystem mParticleSystem;
    
    public void toggleParticles()
    {
        Debug.Log("stuff");

        if (mParticleSystem.isPlaying) mParticleSystem.Stop();
        else mParticleSystem.Play();
    }

    void Awake () {
        mParticleSystem = GetComponent<ParticleSystem>();
	}
}
