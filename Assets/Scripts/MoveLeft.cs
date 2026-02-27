using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ย้ายจาก update ไป start จะทำให้ประสิทธิภาพดีขึ้น
        GameObject go = GameObject.Find("Player");
        PlayerController player = go .GetComponent<PlayerController>();
        if (player.isGameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
