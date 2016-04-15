using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour
{
    public Transform player;
    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += OnJoyStickMove;
        EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;
    }

    void OnJoystickMoveEnd(MovingJoystick move)
    {
        if (move.joystickName != "MoveJoystick")
        {
            return;
        }
        //Debug.Log("移动摇杆结束");
        player.gameObject.GetComponent<Animator>().Play("Idle");
    }
    void OnJoyStickMove(MovingJoystick move)
    {
        //Debug.Log("移动摇杆中---" + move.joystickName);
        if (move.joystickName != "MoveJoystick")
        {
            return;
        }
        float joyPositionX = move.joystickAxis.x;
        float joyPositionY = move.joystickAxis.y;
        if (joyPositionY != 0 || joyPositionX != 0)
        {
            Debug.Log(player.name);
            player.LookAt(new Vector3(player.position.x + joyPositionX, player.position.y, player.position.z + joyPositionY));
            player.Translate(Vector3.forward * Time.deltaTime * 5);
            //Debug.Log("移动摇杆中");
            player.gameObject.GetComponent<Animator>().Play("Run");
        }
    }

    public void OnDestroy()
    {
        EasyJoystick.On_JoystickMove -= OnJoyStickMove;
        EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
    }
}
