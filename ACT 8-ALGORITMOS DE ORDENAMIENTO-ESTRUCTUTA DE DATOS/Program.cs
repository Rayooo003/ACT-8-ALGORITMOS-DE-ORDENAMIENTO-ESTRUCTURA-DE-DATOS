//ACT 8-ALGORITMOS DE ORDENAMIENTO-ESTRUCTURA DE DATOS
using System;

namespace SortingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara e inicializa un array de enteros con los valores proporcionados.
            int[] array = { 8, 43, 17, 6, 40, 16, 18, 97, 11, 7 };

            //Muestra en la consola el mensaje "Arreglo original".
            Console.WriteLine("Arreglo original");

            //Imprime en pantalla el Array original (8, 43, 17, 6, 40, 16, 18, 97, 11, ).
            PrintArray(array);

            //Se ordena el Array utilizando Shell Sort.
            ShellSort(array);

            //Imprime en pantalla el mensaje "Array ordenado con Shell Sort".
            Console.WriteLine("\nArray ordenado con Shell Sort:");

            //Imprime el Array ordenado habiendo usado Shell Sort.
            PrintArray(array);

            //Llama a la función QuickSort para ordenar el array.
            QuickSort(array, 0, array.Length - 1);

            //Imprime en pantalla el mensaje "Array ordenado con Quick Sort".
            Console.WriteLine("\nArray ordenado con QuickSort:");

            //Imprime el Array ordenado habiendo usado Quick Sort.
            PrintArray(array);
        }

        //Define la función ShellSort que ordena un array utilizando el algoritmo de Shell.
        static void ShellSort(int[] arr)
        {
            //Obtiene la longitud del array,
            int n = arr.Length;

            //Define el intervalo inicial para la ordenación,
            int gap = n / 2;

            //Mientras el intervalo sea mayor que 0.
            while (gap > 0)
            {
                //Para cada elemento del array a partir del intervalo.
                for (int i = gap; i < n; i++)
                {
                    //Guarda el valor actual en una variable temporal.
                    int temp = arr[i];

                    //Inicializa una variable j con el valor de i.
                    int j = i;

                    //Mientras j sea mayor o igual al intervalo y el elemento en la posición j-intervalo sea mayor que temp.
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        //Asigna el valor del elemento en la posición j-intervalo al elemento en la posición j.
                        arr[j] = arr[j - gap];

                        //Reduce j en el valor del intervalo.
                        j -= gap;
                    }

                    //Asigna el valor temporal al elemento en la posición j.
                    arr[j] = temp;
                }

                //Reduce el intervalo a la mitad.
                gap /= 2;
            }
        }

        //Define la función QuickSort que ordena un array utilizando el algoritmo QuickSort.
        static void QuickSort(int[] arr, int left, int right)
        {
            //Si el índice izquierdo es menor que el índice derecho.
            if (left < right)
            {
                //Llama a la función Partition para dividir el array y obtener el índice de pivot.
                int pivot = Partition(arr, left, right);

                //Llama a QuickSort para ordenar la parte izquierda del array.
                QuickSort(arr, left, pivot - 1);

                //Llama a QuickSort para ordenar la parte derecha del array.
                QuickSort(arr, pivot + 1, right);
            }
        }

        //Define la función Partition que divide el array y devuelve el índice de pivot.
        static int Partition(int[] arr, int left, int right)
        {
            //Elige el último elemento como pivot.
            int pivot = arr[right];

            //Inicializa una variable i con el valor de left - 1.
            int i = left - 1;

            //Para cada elemento del array desde left hasta right - 1.
            for (int j = left; j < right; j++)
            {
                //Si el elemento actual es menor o igual al pivot.
                if (arr[j] <= pivot)
                {
                    //Incrementa i.
                    i++;

                    //Intercambia los elementos en las posiciones i y j
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            //Intercambia los elementos en las posiciones i + 1 y right.
            Swap(ref arr[i + 1], ref arr[right]);

            //Devuelve el indice del pivot.
            return i + 1;
        }

        //Define la función Swap que intercambia dos elementos.
        static void Swap(ref int a, ref int b)
        {
            //Guarda el valor de a en una variable temporal.
            int temp = a;

            //Asigna el valor de b a a.
            a = b;

            // Asigna el valor temporal a b.
            b = temp;
        }

        //Define la función PrintArray que imprime un array.
        static void PrintArray(int[] arr)
        {
            //Para cada elemento del array
            foreach (var item in arr)
            {
                //Imprime el elemento seguido de un espacio.
                Console.Write(item + " ");
            }
            //Imprime un salto de linea.
            Console.WriteLine();
        }
    }
}