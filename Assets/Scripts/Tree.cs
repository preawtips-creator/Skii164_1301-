using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Hp -= 15;
        UIManager.Instance.ShowNotiText($"Hurt -15\nHP: {player.Hp}");

        if (player.Hp <= 0)
        {
            UIManager.Instance.ShowNotiText($"Game Over\nPoints: {player.Point}");
            player.Hp = 0;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(159, 102, 102, 255);
    }
}
