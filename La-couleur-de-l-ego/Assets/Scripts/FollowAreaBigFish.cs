using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAreaBigFish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            transform.parent.GetComponent<BigFish>().isFollowing = true;
        }
    }
}
