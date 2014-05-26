using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


// classe publica e construtor de cartas
public class Carta : MonoBehaviour 
{
	//Atributos de cada carta

	public string id;
	public string nome;
	public int forca;
	public int velocidade;
	public int habilidade;
	public int equipamento;
	public int inteligencia;
	public Texture texturaCarta;
    
	public Carta(string _id,string _nome,int For, int vel, int habi,int equip, int inte, Texture tex)
	{
		id = _id;
		nome = _nome;
		forca = For;
		velocidade = vel;
		habilidade = habi;
		equipamento = equip;
		inteligencia = inte;
		texturaCarta = tex;
	} 


}
