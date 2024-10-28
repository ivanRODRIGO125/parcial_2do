using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour
{
    private CharacterController Player;
    [SerializeField] private float speed, gravity, fall_velocity, jump_force;
    private Vector3 axis, move_player;
    public float rotacion_Y;

    private void Awake()
    {
        Player = GetComponent<CharacterController>();//busca datos de este componente
    }

    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") /* evuelve un valor que representa el movimiento del mouse en el eje X.*/, 0);
        axis = new Vector3(Input.GetAxis("Horizontal"), 0/*solo plano horizontal*/, Input.GetAxis("Vertical")/*se mueve  en el eje x y z*/);
        if (axis.magnitude > 1) { axis = transform.TransformDirection(axis).normalized; }//comprueba que se mueve y el normalized asegura que mantenga la direccion,evita aumento de velocidad.
        else axis = transform.TransformDirection(axis);// convierte el vector axis de espacio local a espacio global



        move_player.x = axis.x;//movimiento de adelante y atras  
        move_player.z = axis.z;//movimiento de izquierda y derecha
        setGravity();
        Player.Move(move_player * speed * Time.deltaTime);//time.deltatime es para ajustarlo a los fps
    }
    private void setGravity()
    {
        if (Player.isGrounded)//si jugador esta en el suelo
        { fall_velocity = -gravity * Time.deltaTime; }//velocidad de caida-gravedad.

        else { fall_velocity -= gravity * Time.deltaTime; }//se agrega el valor de la gravedad para conseguir vbelocidad de caida constante
        move_player.y = fall_velocity;
    }
    //private void movecamara_ejeY() { float mouseY = Input.GetAxis("Mouse Y") * rotacion_Y;
        
    //}
}