using UnityEngine;

namespace GMPR2512.Lesson11_Platformer
{
    public class SoundHub : MonoBehaviour
    {
        AudioSource[] sources;
        void Awake()
        {
            sources = GetComponents<AudioSource>();
        }
        internal void PlayCoinSound()
        {
            //todo: find a less brittle way to find coin sound? by name?
            sources[0].Play();
        }
    }
}
