using UnityEngine;
using System.Collections;



public class Controlador : MonoBehaviour 
{
	//listas de cartas de cada jogador
	static public Controlador Singleton;

	//List<GameObject> J1 = new List<GameObject>();
	//List<GameObject> J2 = new List<GameObject>();
	IList<GameObject>J3 = new IList<GameObject>();


	// Use this for initialization
	void Start () {
	
		Carta A1 = new Carta("A1","HOMEM DE FERRO",5,6,2,5,6);
		Carta A2 = new Carta("A2","CAPTAO AMERICA",3,2,6,2,3);
		Carta A3 = new Carta("A3","THOR",6,5,3,3,2);
		Carta A4 = new Carta("A4","HULK",3,2,6,2,3);
		Carta A5 = new Carta("A5","NICK FURY",1,2,4,6,3);
		Carta A6 = new Carta("A6","VIUVA NEGRA",1,2,6,4,3);

		Carta B1 = new Carta("B1","GAVIAO ARQUEIRO",1,1,6,5,2);
		Carta B2 = new Carta("B2","AGENTE HILL",1,1,4,5,3);
		Carta B3 = new Carta("B3","AGENTE COULSON",1,1,6,5,2);
		Carta B4 = new Carta("B4","TONY STARK",1,1,1,5,6);
		Carta B5 = new Carta("B5","BRUCE BANNER",1,1,1,3,6);
		Carta B6 = new Carta("B6","LOKI",5,4,4,5,5);
		
		Carta C1 = new Carta("C1","CHITAURI",2,1,2,3,1);
		Carta C2 = new Carta("C2","LEVIATHAN",5,5,1,5,1);
		Carta C3 = new Carta("C3","CAVAIRA VERMELHA",3,2,4,4,3);
		Carta C4 = new Carta("C4","SOLDADO HIDRA",2,1,2,4,2);
		Carta C5 = new Carta("C5","CHICOTE NEGRO",2,2,3,4,6);
		Carta C6 = new Carta("C6","MONGE DE FERRO",5,4,2,5,4);
		
		Carta D1 = new Carta("D1","GIGANTE DE GELO",4,3,3,2,2);
		Carta D2 = new Carta("D2","ABOMINAVEL",6,3,3,1,3);
		Carta D3 = new Carta("D3","HEIMDALL",4,3,3,3,2);
		Carta D4 = new Carta("D4","EMIL BLONSKY",2,3,5,2,3);
		Carta D5 = new Carta("D5","HOWARD STARK",1,1,2,4,6);
		Carta D6 = new Carta("C6","WAR MACHINE",5,5,2,5,3);

		
		Carta E1 = new Carta("E1","HOMEM DE FERRO MARK V",5,4,2,4,6);
		Carta E2 = new Carta("E2","ODIN",5,2,1,6,6);
		Carta E3 = new Carta("E3","SIF",4,2,4,3,3);
		Carta E4 = new Carta("E4","DUM DUM DUGAN",1,2,3,2,2);
		Carta E5 = new Carta("E5","BUCKY BARNES",1,2,3,3,3);
		Carta E6 = new Carta("E6","DESTRUIDOR",6,4,3,3,1);


	}
	
	void OnMouseEnter()
	{

	}
}
