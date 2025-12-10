using UnityEngine;

public class HideOnPlayerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false); // hides the quad + image
        }
    }
}