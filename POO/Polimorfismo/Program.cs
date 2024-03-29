﻿using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            Mamifero mamifero = new Mamifero();
            Reptil reptil = new Reptil();
            Peixe peixe = new Peixe();
            Ave ave = new Ave();
            Canguru canguru = new Canguru();
            Cachorro cachorro = new Cachorro();
            Cobra cobra = new Cobra();
            Tartaruga tartaruga = new Tartaruga();
            PeixeDourado peixeDourado = new PeixeDourado();
            Arara arara = new Arara();

            //Mamifero
            mamifero.Peso=35.5f;
            mamifero.CorDoPelo="Marrom";
            Console.WriteLine(mamifero.CorDoPelo);
            mamifero.Alimentar();
            mamifero.Locomover();
            mamifero.EmitirSom();

            //Reptil
            reptil.CorEscama = "Verde";
            Console.WriteLine(reptil.CorEscama);
            reptil.Alimentar();
            reptil.Locomover();
            reptil.EmitirSom();

            //Peixe
            peixe.CorEscama = "Cinza";
            Console.WriteLine(peixe.CorEscama);
            peixe.Alimentar();
            peixe.Locomover();
            peixe.EmitirSom();
            peixe.SoltarBolha();

            //Ave
            ave.CorPena = "Azul";
            Console.WriteLine(ave.CorPena);
            ave.Alimentar();
            ave.Locomover();
            ave.EmitirSom();

            //Testando Sobrecarga
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Reagir("Olá"); //Abanar e latir
            cachorro1.Reagir("Vai apanhar"); //Rosnar
            cachorro1.Reagir(11, 45); //Abanar
            cachorro1.Reagir(21, 00); //Ignorar
            cachorro1.Reagir(true); //Abanar
            cachorro1.Reagir(false); //Rosnar
            cachorro1.Reagir(2, 12.5f); //Latir
            cachorro1.Reagir(17, 4.5f); //Rosnar


        }
    }
}
