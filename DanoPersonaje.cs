//Nombre del desarrollador: Francisco Javier Ochoa
//Asignatura: Estructura de Datos
//Descripción del uso de este código:
/*
 Este script se utilizará para que el objeto que lo tenga, al colisionar con el Player, le quite vida a este.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Para agregar la bilioteca que nos de acceso a propiedades de la escena como reiniciar el nivel

public class DanoPersonaje : MonoBehaviour
{
    //Llamamos al script PlayerControl para posteriormente acceder a sus parámetros y manipular la cantidad de vida
    [SerializeField]
    PlayerControl playerVida;

    private void OnCollisionEnter2D(Collision2D collision)  //Método para registrar la colisón (al toque) de objetos 2D y darle características
    {
        if (collision.gameObject.tag == "Player")  //Condición para que si se detecta una colisión con el objeto etiquetado como Player, entonces...
        {
            //Accedemos a la variable pública vida dentro del script PlayerControl (a través de si acceso en este script: playerVida.
            playerVida.vida--;   //entonces... al componente vida se le disimuirá un punto cuando haya una colisión


            if (playerVida.vida <= 0)  //Y si el contador de vida del Player llega a cero, entonces...
            {
                //entonces el personaje volverá al comienzo de la escena. Para esto llamé propiedades de la librería UnityEngine.SceneManagment para 
                //cargar la misma escena desde el comienzo.
                Scene CS = SceneManager.GetActiveScene();
                SceneManager.LoadScene(CS.name);

            }

        }

            

    }


}
