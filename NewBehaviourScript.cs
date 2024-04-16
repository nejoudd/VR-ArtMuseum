using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject canvasObject;
    public Transform playerTransform;
    public float activationDistance = 3f;

    private bool playerInRange = false;

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        if (distanceToPlayer <= activationDistance && !playerInRange)
        {
            canvasObject.SetActive(true);
            playerInRange = true;
        }
        else if (distanceToPlayer > activationDistance && playerInRange)
        {
            canvasObject.SetActive(false);
            playerInRange = false;
        }
    }
}
