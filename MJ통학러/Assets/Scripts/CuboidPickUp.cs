using UnityEngine;

public class CuboidPickUp : MonoBehaviour
{
    public delegate void Cuboid();
    public static event Cuboid CuboidPickedUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Pickup cuboid");
            if (CuboidPickedUp != null)
            {
                CuboidPickedUp();
                //jumpAbility.fillAmount = 1;
                //Hp_gauge.maxHp += 0.1f;
                if (Player.PlayerJump.jumpCooldown >= 7)
                {
                    Player.PlayerJump.jumpCooldown -= 3.0f;
                }

            }
            Destroy(gameObject);
        }
    }
}
