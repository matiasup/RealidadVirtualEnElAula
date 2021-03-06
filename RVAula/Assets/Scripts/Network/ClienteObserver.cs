using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClienteObserver : Observer {

	public Cliente cliente;

	public ClienteObserver( Cliente c){
		cliente = c;
	}

	public override void consumirMensaje(string mensaje){
		string[] mensajes = mensaje.Split ('&');
		if(mensajes[0].Equals("comenzar")){
			cliente.comenzar();
		}
	}

	public override void conexionEstablecida(){
		cliente.conexionEstablecida ();
	}
}
