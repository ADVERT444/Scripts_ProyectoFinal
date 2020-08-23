//Nombre del desarrollador: Francisco Javier Ochoa
//Asignatura: Estructura de Datos
//Descripción del uso de este código:
/*
 Este script se utilizará para que añadido en los sprites de monedas (almas, en el caso de mi juego), estas registren las colusiones con el jugador,
 le añadan un punto a su score de monedas y después se destruyan para que cada una sólo funcione una vez.

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)  //Método para registrar la colisón (al toque) de objetos 2D y darle características
    {
        //Accede a la propiedad cantidadMonedas dentro de otro script llamado ScoreTextScrip y le suma 1 cada vez que haya colisión
        ScoreTextScript.cantidadMonedas += 1;
        //Para que sólo se colisione una vez por objeto, esta linea destruye el objeto portador de este script después de una colisión
        Destroy(gameObject);

    }
}
