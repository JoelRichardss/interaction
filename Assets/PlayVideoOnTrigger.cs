using UnityEngine;
using UnityEngine.Video;

public class PlayVideoOnTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Enter");
            videoPlayer.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            videoPlayer.Stop();
        }
    }
}

