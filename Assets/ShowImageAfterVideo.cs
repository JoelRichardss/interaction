using UnityEngine;
using UnityEngine.Video;

public class ShowImageAfterVideo : MonoBehaviour
{
public VideoPlayer videoPlayer;
public GameObject imageQuad; // The image you want to show

void Start()
{
// Hide image at start
imageQuad.SetActive(false);

// Listen for when video ends
videoPlayer.loopPointReached += OnVideoFinished;
}

void OnVideoFinished(VideoPlayer vp)
{
imageQuad.SetActive(true); // Show the image
}
}