using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour
{
    private CharacterController Player;
    [SerializeField] private float speed, gravity, fall_velocity, jump_force;
    private Vector3 axis, move_player;

    private void Awake()
    {
        Player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        axis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (axis.magnitude > 1) { axis = transform.TransformDirection(axis).normalized; }
        else axis = transform.TransformDirection(axis);



        move_player.x = axis.x;//movimiento de adelante y atras  
        move_player.z = axis.z;//movimiento de izquierda y derecha
        setGravity();
        Player.Move(move_player * speed * Time.deltaTime);
    }
    private void setGravity()
    {
        if (Player.isGrounded)
        { fall_velocity = -gravity * Time.deltaTime; }

        else { fall_velocity -= gravity * Time.deltaTime; }//se agrega el valor de la gravedad para conseguir vbelocidad de caida constante
        move_player.y = fall_velocity;
    }
}