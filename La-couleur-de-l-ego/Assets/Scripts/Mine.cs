using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public int damage = 9999;

    private GameObject BoomEvent;

    void Start() {
        BoomEvent = Resources.Load("Prefab/mine_explosion_0") as GameObject;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        float x = transform.position.x;
        float y = transform.position.y;
        Vector3 pos = new Vector3(x, y, -8f);
        if (hitInfo.GetComponent<FollowAreaBigFish>() == null) {
            Instantiate(BoomEvent, pos, transform.rotation);
            Destroy(gameObject);
        }
    }
}
