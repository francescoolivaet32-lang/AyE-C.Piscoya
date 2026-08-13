using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;
using System;
namespace ConsoleApp1
{
    public struct Personaje
    {
        public String Nombre { get; set; }
        public int Poder { get; set; }

        public String[] Items { get; set; }

        public Personaje(string nombre, int poder)
        {
            Nombre = nombre;
            Poder = poder;
            Items = new string[20];
        }
    }

    public struct Salas
    {
        public int Dificultad { get; set; }
        public string Item { get; set; }

        public int Poderitem { get; set; }

        public Salas(int dificultad, string item, int poderitem)
        {
            Dificultad = dificultad;
            Item = item;
            Poderitem = poderitem;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] objetos = { "Espada de Hierro", "Armadura de Cuero", "Poción de Vida", "Amuleto Mágico", "Escudo Pesado", "Botas de Velocidad", "Casco de Bronce", "Báculo Sagrado", "Anillo de Poder", "Daga Envenenada", "Manto de Invisibilidad", "Poción de Fuerza", "Hacha de Batalla", "Guanteletes de Hierro", "Talismán de la Suerte", "Arco Largo", "Poción de Maná", "Capa del Errante", "Lanza de Plata", "Cinturón de Gigante", "Grimorio Oscuro", "Escudo de Madera" };
            Random aleatorio = new Random();
            Personaje marcos = new Personaje("Guerrero", 50);
            Personaje pedro = new Personaje("Magordito", 60);

            bool turno1 = true;
            Salas[] listaSalas = new Salas[20];
            for (int k = 0; k < listaSalas.Length; k++)
            {
                string objeto = objetos[aleatorio.Next(0, objetos.Length)];
                int poderitem = aleatorio.Next(10, 31);
                listaSalas[k] = new Salas(aleatorio.Next(10, 80), objeto, poderitem);
            }

            for (int i = 0; i < listaSalas.Length; i++)
            {
                Console.WriteLine($"Turno : {i}");
                Salas salaActual = listaSalas[i];
                if (turno1 == true)
                {
                    if (salaActual.Dificultad < marcos.Poder)
                    {
                        Console.WriteLine("Logro robarlo ya que su poder es mayor al de la sala");
                        marcos.Poder += salaActual.Poderitem;
                        for (int j = 0; j < marcos.Items.Length; j++)
                        {
                            if (marcos.Items[j] == null)
                            {
                                marcos.Items[j] = salaActual.Item;
                                Console.WriteLine($"[{salaActual.Item}] guardado en la mochila de {marcos.Nombre}.");
                                break;
                            }
                        }
                    }
                    else { Console.WriteLine("No logro robarlo ya que su poder es menor al de la sala ;("); }
                    turno1 = false;
                }

                else
                {
                    if (salaActual.Dificultad < pedro.Poder)
                    {
                        Console.WriteLine("Logro robarlo ya que su poder es mayor al de la sala");
                        pedro.Poder += salaActual.Poderitem;
                        for (int j = 0; j < pedro.Items.Length; j++)
                        {
                            if (marcos.Items[j] == null)
                            {
                                pedro.Items[j] = salaActual.Item;
                                Console.WriteLine($"[{salaActual.Item}] guardado en la mochila de {pedro.Nombre}.");
                                break;
                            }
                        }
                    }
                    else { Console.WriteLine("No logro robarlo ya que su poder es menor al de la sala ;("); }
                    turno1 = true;
                }
            }
            if (pedro.Poder < marcos.Poder)
            {
                Console.WriteLine($"Ha ganado Cabral - Inventario: ");
                for (int j = 0; j < marcos.Items.Length; j++)
                {
                    if (marcos.Items[j] != null)
                    {
                        Console.WriteLine($"Items: [{marcos.Items[j]}]");
                    }
                }
            }
            else if (pedro.Poder > marcos.Poder)
            {
                Console.WriteLine($"Ha ganado Toledo - Inventario: ");
                for (int j = 0; j < marcos.Items.Length; j++)
                {
                    if (pedro.Items[j] != null)
                    {
                        Console.WriteLine($"Items: [{pedro.Items[j]}]");
                    }
                }
            }
            else if (pedro.Poder == marcos.Poder)
            {
                Console.WriteLine("Han empatado");
                Console.WriteLine("Inventario de Cabral");
                for (int j = 0; j < marcos.Items.Length; j++)
                {
                    if (marcos.Items[j] != null)
                    {
                        Console.WriteLine($"Items: [{marcos.Items[j]}]");
                    }
                }
                Console.WriteLine("Inventario de Toledo");
                for (int j = 0; j < pedro.Items.Length; j++)
                {
                    if (pedro.Items[j] != null)
                    {
                        Console.WriteLine($"Items: [{pedro.Items[j]}]");
                    }
                }
            }
        }
    }
}
