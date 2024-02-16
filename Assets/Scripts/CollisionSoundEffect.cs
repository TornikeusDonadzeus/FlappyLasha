using UnityEngine;

public class CollisionSoundEffect : MonoBehaviour
{
    public AudioClip collisionSound;
    public AudioClip TingSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
       
        audioSource.playOnAwake = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.CompareTag("CollisionTag"))
        {
      
            audioSource.PlayOneShot(collisionSound);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(TingSound);
    }
}
