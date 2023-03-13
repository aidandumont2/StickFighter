using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool isGrounded = true;
    public bool isCrouching = false;
    public bool isMoving = false;
    public bool isSpecialAtt = false;
    public bool isStatic = true;

    public float speed = 5f;
    public float jumpspeed = 2f;

    public int lifepoint = 100;
    public int stamina = 7;
}
