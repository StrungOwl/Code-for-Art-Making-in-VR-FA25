using UnityEngine;
using UnityEngine.Events;

public class MushroomParticleEffect : MonoBehaviour
{
    public ParticleSystem mushroomEffect;
    public UnityEvent TriggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mushroomEffect.Play();
            TriggerEvent.Invoke();
        }
    }
}
