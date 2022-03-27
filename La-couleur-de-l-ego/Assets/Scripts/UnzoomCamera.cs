using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnzoomCamera : MonoBehaviour
{
    private int val = 0;

    public GameObject playerCanva;
    private Vector3 base_hp_pos;

    private void Start() {
        base_hp_pos = playerCanva.transform.localScale;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            if (val == 0)
                val = 1;
            else
                val = 0;
        }
    }

    private void Update() {
        Debug.Log(Camera.main.orthographicSize);
        if (val == 1) {
            if (playerCanva.transform.localScale.x < base_hp_pos.x * 2)
                playerCanva.transform.localScale += new Vector3(0.00005f, 0.00005f, 0f);
            if (Camera.main.fieldOfView < 125)
                Camera.main.fieldOfView += 2;
            if (Camera.main.orthographicSize <= 10)
                Camera.main.orthographicSize += 0.1f;
        } else {
            if (playerCanva.transform.localScale.x > base_hp_pos.x)
                playerCanva.transform.localScale -= new Vector3(0.00005f, 0.00005f, 0f);
            if (Camera.main.fieldOfView > 60)
                Camera.main.fieldOfView -= 2;
            if (Camera.main.orthographicSize > 5)
                Camera.main.orthographicSize -= 0.1f;

        }
    }
}
