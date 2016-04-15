using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public GameObject player;               //玩家
    public GameObject bullet;               //子弹
    public GameObject gun;
    public float gunshot = 100;             //射程
    public GameObject BoomRange;            //爆炸范围

    void Start()
    {
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GunShoot(player.transform);
        //}
    }
    public void GunShoot(Transform startobj)
    {
        Debug.Log("发射子弹");
        GameObject shootBullet = Instantiate(bullet, startobj.localPosition + new Vector3(1, 1, 1), Quaternion.identity) as GameObject;
        shootBullet.SetActive(true);
        shootBullet.GetComponent<Rigidbody>().AddForce(gunshot, gunshot, gunshot);
    }
    public void TouchGunShoot()
    {
        Debug.Log("发射子弹");
        GameObject shootBullet = Instantiate(bullet, gun.transform.position, gun.transform.rotation) as GameObject;
        shootBullet.SetActive(true);
        shootBullet.GetComponent<Rigidbody>().AddForce(0, gunshot, 0);
    }

}
