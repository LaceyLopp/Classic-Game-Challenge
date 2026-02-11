using UnityEngine;

public class BaseHealth : MonoBehaviour

{

    public float health = 2;

    void Update()
    {
        if (health <= 0)
            Destroy(gameObject);
    }
}
