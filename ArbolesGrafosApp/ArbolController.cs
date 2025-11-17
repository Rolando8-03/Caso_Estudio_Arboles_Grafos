using System;
using System.Collections.Generic;

namespace ArbolesGrafosApp
{
    public class ArbolController
    {
        public class Nodo
        {
            public string Valor;
            public List<Nodo> Hijos;
            public Nodo(string valor)
            {
                Valor = valor;
                Hijos = new List<Nodo>();
            }
        }

        // Única raíz del árbol 
        private Nodo raiz;

        // Obtener raíz 
        public Nodo Raiz => raiz;
        public bool Agregar(string valor, string padre = null)
        {
            if (string.IsNullOrWhiteSpace(valor)) return false;
            if (Buscar(valor) != null) return false; // evitar duplicados exactos

            if (raiz == null)
            {
                raiz = new Nodo(valor);
                return true;
            }

            if (string.IsNullOrEmpty(padre))
            {
                raiz.Hijos.Add(new Nodo(valor));
                return true;
            }

            var nodoPadre = Buscar(padre);
            if (nodoPadre == null) return false;
            nodoPadre.Hijos.Add(new Nodo(valor));
            return true;
        }

        // Buscar: devuelve el Nodo o null (primera coincidencia)
        public Nodo Buscar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return null;
            return BuscarRec(raiz, valor);
        }

        private Nodo BuscarRec(Nodo n, string valor)
        {
            if (n == null) return null;
            if (string.Equals(n.Valor, valor, StringComparison.OrdinalIgnoreCase)) return n;
            foreach (var h in n.Hijos)
            {
                var r = BuscarRec(h, valor);
                if (r != null) return r;
            }
            return null;
        }

        // Eliminar: borra el nodo y todo su subárbol.
        // Devuelve la cantidad de nodos eliminados (0 si no se encontró).
        public int Eliminar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || raiz == null) return 0;

            // si la raíz es el valor -> borrar todo
            if (string.Equals(raiz.Valor, valor, StringComparison.OrdinalIgnoreCase))
            {
                int c = ContarRec(raiz);
                raiz = null;
                return c;
            }

            return EliminarEnHijos(raiz, valor);
        }

        private int EliminarEnHijos(Nodo actual, string valor)
        {
            for (int i = 0; i < actual.Hijos.Count; i++)
            {
                var h = actual.Hijos[i];
                if (string.Equals(h.Valor, valor, StringComparison.OrdinalIgnoreCase))
                {
                    int c = ContarRec(h);
                    actual.Hijos.RemoveAt(i);
                    return c;
                }
                int sub = EliminarEnHijos(h, valor);
                if (sub > 0) return sub;
            }
            return 0;
        }

        // Contar nodos (útil para actualizar etiqueta)
        public int ContarNodos()
        {
            return ContarRec(raiz);
        }

        private int ContarRec(Nodo n)
        {
            if (n == null) return 0;
            int c = 1;
            foreach (var h in n.Hijos) c += ContarRec(h);
            return c;
        }

        // RECORRIDOS: devuelven lista de strings para mostrar fácilmente
        public List<string> RecorrerPreOrden()
        {
            var salida = new List<string>();
            RecPre(raiz, salida);
            return salida;
        }
        private void RecPre(Nodo n, List<string> s)
        {
            if (n == null) return;
            s.Add(n.Valor);
            foreach (var h in n.Hijos) RecPre(h, s);
        }

        public List<string> RecorrerPostOrden()
        {
            var salida = new List<string>();
            RecPost(raiz, salida);
            return salida;
        }
        private void RecPost(Nodo n, List<string> s)
        {
            if (n == null) return;
            foreach (var h in n.Hijos) RecPost(h, s);
            s.Add(n.Valor);
        }

        public List<string> RecorrerPorNiveles()
        {
            var salida = new List<string>();
            if (raiz == null) return salida;
            var cola = new Queue<Nodo>();
            cola.Enqueue(raiz);
            while (cola.Count > 0)
            {
                var a = cola.Dequeue();
                salida.Add(a.Valor);
                foreach (var h in a.Hijos) cola.Enqueue(h);
            }
            return salida;
        }
    }
}
