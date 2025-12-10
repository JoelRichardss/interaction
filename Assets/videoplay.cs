using UnityEngine;

public class videoplay : MonoBehaviour
{
public Gameobject videoPlayer;
public int timeToStop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter (Collider player){

        if (player.Gameobject.tag == "Player")
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
