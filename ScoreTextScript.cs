//Nombre del desarrollador: Francisco Javier Ochoa
//Asignatura: Estructura de Datos
//Descripción del uso de este código:
/*
 Este script se utilizará para que el objeto de UI de Texto funcione como contador de puntos y vaya reflejando las colisiones con las monedas 
 (almas, en el caso de mi juego). Cada que el personaje jugable colisione con una moneda, esta sumará un punto en el score y se verá reflejado en la
 interfaz del juego.

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //Agregué librería que sirve para poder acceder a componentes y usar palabras reservadas en lo referente a interfaz de usuario de Unity.

public class ScoreTextScript : MonoBehaviour
{
    //Área de declaración de variables

    //Definí variable para acceder al objeto de Texto de UI
    Text text;
    //La variable pública que alojará los puntos recolectados
    public static int cantidadMonedas;


    // Start  - sirve para inicializar datos, componentes y variables una sola vez al comienzo.
    void Start()
    {
        //Da acceso a la variable al componente Text que tiene las propiedades del texto que aparecerá en la interface
        text = GetComponent<Text>();
    }

    // Update  - sirve para utilizar los datos, componentes y variables pues se refresca continuamente; una vez por cada frame.
    void Update()
    {
        //Da acceso a la propiedad dentro del componente de texto donde la sumatoria de la cantidad de monedas se verá transformada y reflejada en
        //tipo de dato string.
        text.text = cantidadMonedas.ToString();

    }


}
