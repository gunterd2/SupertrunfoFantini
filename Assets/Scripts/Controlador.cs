using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;




public class Controlador : MonoBehaviour 
{

	System.Random Aleatorio = new System.Random();
	//listas de cartas de cada jogador
	static public Controlador Singleton;
	public int cartaatual;

	public List<Carta> J1 = new List<Carta>();
	public List<Carta> J2 = new List<Carta>();

	public GameObject[] CartasAtuais;

	public Texture[] TexturadasCartas;
	public Carta[] Mesa;
    enum EnumAtributos { Forca, Velo, Habili, Equip, Inte}

	// Use this for initialization
	void Start () {
	
		Mesa[0] = new Carta("A1","HOMEM DE FERRO",5,6,2,5,6,TexturadasCartas[0]);
		Mesa[1] = new Carta("A2","CAPTAO AMERICA",3,2,6,2,3,TexturadasCartas[1]);
		Mesa[2] = new Carta("A3","THOR",6,5,3,3,2,TexturadasCartas[2]);
		Mesa[3] = new Carta("A4","HULK",3,2,6,2,3,TexturadasCartas[3]);
		Mesa[4] = new Carta("A5","NICK FURY",1,2,4,6,3,TexturadasCartas[4]);
		Mesa[5] = new Carta("A6","VIUVA NEGRA",1,2,6,4,3,TexturadasCartas[5]);

		Mesa[6] = new Carta("B1","GAVIAO ARQUEIRO",1,1,6,5,2,TexturadasCartas[6]);
		Mesa[7] = new Carta("B2","AGENTE HILL",1,1,4,5,3,TexturadasCartas[7]);
		Mesa[8] = new Carta("B3","AGENTE COULSON",1,1,6,5,2,TexturadasCartas[8]);
		Mesa[9] = new Carta("B4","TONY STARK",1,1,1,5,6,TexturadasCartas[9]);
		Mesa[10] = new Carta("B5","BRUCE BANNER",1,1,1,3,6,TexturadasCartas[10]);
		Mesa[11] = new Carta("B6","LOKI",5,4,4,5,5,TexturadasCartas[11]);
		
		Mesa[12] = new Carta("C1","CHITAURI",2,1,2,3,1,TexturadasCartas[12]);
		Mesa[13] = new Carta("C2","LEVIATHAN",5,5,1,5,1,TexturadasCartas[13]);
		Mesa[14] = new Carta("C3","CAVAIRA VERMELHA",3,2,4,4,3,TexturadasCartas[14]);
		Mesa[15] = new Carta("C4","SOLDADO HIDRA",2,1,2,4,2,TexturadasCartas[15]);
		Mesa[16] = new Carta("C5","CHICOTE NEGRO",2,2,3,4,6,TexturadasCartas[16]);
		Mesa[17] = new Carta("C6","MONGE DE FERRO",5,4,2,5,4,TexturadasCartas[17]);
		
		Mesa[18] = new Carta("D1","GIGANTE DE GELO",4,3,3,2,2,TexturadasCartas[18]);
		Mesa[19] = new Carta("D2","ABOMINAVEL",6,3,3,1,3,TexturadasCartas[19]);
		Mesa[20] = new Carta("D3","HEIMDALL",4,3,3,3,2,TexturadasCartas[20]);
		Mesa[21] = new Carta("D4","EMIL BLONSKY",2,3,5,2,3,TexturadasCartas[21]);
		Mesa[22] = new Carta("D5","HOWARD STARK",1,1,2,4,6,TexturadasCartas[22]);
		Mesa[23] = new Carta("C6","WAR MACHINE",5,5,2,5,3,TexturadasCartas[23]);

		
		Mesa[24] = new Carta("E1","HOMEM DE FERRO MARK V",5,4,2,4,6,TexturadasCartas[24]);
		Mesa[25] = new Carta("E2","ODIN",5,2,1,6,6,TexturadasCartas[25]);
		Mesa[26] = new Carta("E3","SIF",4,2,4,3,3,TexturadasCartas[26]);
		Mesa[27] = new Carta("E4","DUM DUM DUGAN",1,2,3,2,2,TexturadasCartas[27]);
		Mesa[28] = new Carta("E5","BUCKY BARNES",1,2,3,3,3,TexturadasCartas[28]);
		Mesa[29] = new Carta("E6","DESTRUIDOR",6,4,3,3,1,TexturadasCartas[29]);


		for (int i = 0; i < 30; i++) 
		{
			AddCarta(Mesa[i]);
		}


		SacarCarta();


	}

	/*
	        list1.Add(2);
            list1.Insert(0, 1);
            list2.Add(3);
            list2.Add(4);
            list3.Add(list1[0]);
            list1.RemoveAt(0);
            list2.Remove(4);
	 */

	void AddCarta (Carta C)
	{
		int numero; 


		numero = Aleatorio.Next(0,2);

		if(numero == 0)
		{
			if(J1.Count < 15)
				J1.Add(C);
			else
				J2.Add(C);
		}
		else  if(numero == 1)
		{
			if(J2.Count < 15)
				J2.Add(C);
			else
				J1.Add(C);
		}

	}

	void SacarCarta()
	{
		//CartasAtuais[1].GetComponent<CartaAtual>().enabled = false;

		//int cartaatual;
		cartaatual = Aleatorio.Next(0,15);

		//jogador 1
		CartasAtuais[0].GetComponent<CartaAtual>().id = J1[cartaatual].id;
		CartasAtuais[0].GetComponent<CartaAtual>().nome = J1[cartaatual].nome;
		CartasAtuais[0].GetComponent<CartaAtual>().forca = J1[cartaatual].forca;
		CartasAtuais[0].GetComponent<CartaAtual>().velocidade = J1[cartaatual].velocidade;
		CartasAtuais[0].GetComponent<CartaAtual>().habilidade = J1[cartaatual].habilidade;
		CartasAtuais[0].GetComponent<CartaAtual>().equipamento = J1[cartaatual].equipamento;
		CartasAtuais[0].GetComponent<CartaAtual>().inteligencia = J1[cartaatual].inteligencia;
		CartasAtuais[0].GetComponent<CartaAtual>().texturaCarta = J1[cartaatual].texturaCarta;


		
		cartaatual = Aleatorio.Next(0,15);
		//jogador 2
		CartasAtuais[1].GetComponent<CartaAtual>().id = J2[cartaatual].id;
		CartasAtuais[1].GetComponent<CartaAtual>().nome = J2[cartaatual].nome;
		CartasAtuais[1].GetComponent<CartaAtual>().forca = J2[cartaatual].forca;
		CartasAtuais[1].GetComponent<CartaAtual>().velocidade = J2[cartaatual].velocidade;
		CartasAtuais[1].GetComponent<CartaAtual>().habilidade = J2[cartaatual].habilidade;
		CartasAtuais[1].GetComponent<CartaAtual>().equipamento = J2[cartaatual].equipamento;
		CartasAtuais[1].GetComponent<CartaAtual>().inteligencia = J2[cartaatual].inteligencia;
		CartasAtuais[1].GetComponent<CartaAtual>().texturaCarta = J2[cartaatual].texturaCarta;

		

	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
			SacarCarta();
	}
	

}
