using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        // Atributos o campos
        private int _tope;
        private int[] _arreglo;

        // Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        // Propiedades

        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        // Métodos

        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();

            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;

        }

        // Método para ordenar (burbuja)

        public void Ordenar()
        {
            Ordenar(true);
        }

        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i+1; j < _tope; j++)
                {
                    if(ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

        // Método Cambiar

        public void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        // Método Agregar

        public void Agregar(int numero)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");

            }

            _arreglo[_tope] = numero;
            _tope++;

        }

        // Método Insertar

        public void Insertar(int numero, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = numero;
            _tope++;
        }


        // To String

        public override string ToString()
        {
            if(EstaVacio)
            {
                return "Está vacío";
            }

            string cadena = string.Empty;
            int contador = 0;

            for (int i = 0; i < _tope; i++)
            {
                cadena += $"{_arreglo[i]}\t";
                
                contador++;

                if(contador > 9)
                {
                    contador = 0;
                    cadena += "\n";
                }
                
            }

            return cadena;
        }

    }
}
