
//Nombre del desarrollador: Francisco Javier Ochoa
//Asignatura: Estructura de Datos
//Descripción del uso de este código:
/*
 Este script se utilizará para generar el control del avatar del jugador, tanto el movimiento, como su capcaidad de vida.

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{// Inicio del cuerpo de la clase. Para que funcione el código, debe estar aquí adentro.
    

    //*****Área para declarar variables******
    
    //Va a dar acceso al componente Rigidbody2D que maneja lá relación con las físicas para el personaje jugable
    Rigidbody2D fisicasRB2D;
    //Variable para manipular la velocidad. Está puesta pública para poderla modificar durante el desarrollo
    public float velocidadPersonaje;
    //Declaración de la variable para almacenar los puntos de vida. Debe ser pública para que otros scripts puedan llamarla.
    public int vida;
        


    //***************************************



    // Start  - sirve para inicializar datos, componentes y variables una sola vez al comienzo.
    void Start()
    {
        //La variable ahora tendrá acceso al componente de físicas en realción al personaje jugable
        fisicasRB2D = GetComponent<Rigidbody2D>();
        //Inicialización de velocidad
        velocidadPersonaje = 12.0f;
        //Inicializo la cantidad de vida para mi personaje. En mi juego sólo tiene una vida, si la pierde, volverá a empezar.
        vida = 1;

    }

    // Update  - sirve para utilizar los datos, componentes y variables pues se refresca continuamente; una vez por cada frame.
    void Update()
    {

        /*  Esta era la anterior forma que utilicé para el movimiento
         *  
        if (Input.GetKey(KeyCode.D))
        {
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje, fisicasRB2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);
        }

        if (Input.GetKey(KeyCode.W))
        {
            fisicasRB2D.velocity = new Vector2(fisicasRB2D.velocity.x,velocidadPersonaje);
        }
        if (Input.GetKey(KeyCode.S))
        {
            fisicasRB2D.velocity = new Vector2(fisicasRB2D.velocity.x,-velocidadPersonaje);
        }
        */

        //Eliminé la variable que utilizaba las físicas para dehacerme de la inercia que tenía el movimiento de mi personaje: no frenaba, ahora ya.
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * velocidadPersonaje * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * velocidadPersonaje * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * velocidadPersonaje * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * velocidadPersonaje * Time.deltaTime;
        }

    }

}// Fin del cuerpo de la clase
