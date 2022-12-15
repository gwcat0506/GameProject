using UnityEngine;

public class CuboidPickUp2 : MonoBehaviour
{
    public delegate void Cuboid2();
    public static event Cuboid2 CuboidPickedUp2;
    [SerializeField] private GameObject cuboid2;

    private void OnTriggerEnter(Collider cuboid2)
    {
        if (cuboid2.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Pickup cuboid");
            if (CuboidPickedUp2 != null)
            {
                CuboidPickedUp2();
                Hp_gauge.currentHp += 0.1f;
            }
            Destroy(gameObject);
        }

    }
}
