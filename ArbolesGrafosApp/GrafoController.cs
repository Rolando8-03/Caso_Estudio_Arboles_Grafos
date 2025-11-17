using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolesGrafosApp
{
    public class GrafoController
    {
        private readonly Dictionary<string, Dictionary<string, double>> _listaAdyacencia =
        new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase);

        // Agrega un edificio (nodo). Devuelve true si se creó.
        public bool AgregarEdificio(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            if (_listaAdyacencia.ContainsKey(nombre)) return false;
            _listaAdyacencia[nombre] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            return true;
        }

        public bool AgregarConexion(string a, string b, double distancia)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return false;
            if (string.Equals(a, b, StringComparison.OrdinalIgnoreCase)) return false;
            if (distancia <= 0) return false;
            if (!_listaAdyacencia.ContainsKey(a) || !_listaAdyacencia.ContainsKey(b)) return false;

            _listaAdyacencia[a][b] = distancia;
            _listaAdyacencia[b][a] = distancia;
            return true;
        }

        public string ObtenerRepresentacion()
        {
            var sb = new StringBuilder();

            // Nodos
            var nodos = _listaAdyacencia.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();
            if (nodos.Count == 0)
            {
                sb.AppendLine("(grafo vacío)");
                return sb.ToString().TrimEnd();
            }

            sb.AppendLine("Edificios:");
            sb.AppendLine(string.Join(", ", nodos));
            sb.AppendLine();
            sb.AppendLine("Distancias:");

            // Para evitar duplicados en grafo no dirigido usamos un set de pares ordenados
            var vistas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var a in nodos)
            {
                foreach (var kv in _listaAdyacencia[a].OrderBy(k => k.Key, StringComparer.OrdinalIgnoreCase))
                {
                    var b = kv.Key;
                    var peso = kv.Value;
                    // crear clave ordenada
                    var menor = string.Compare(a, b, StringComparison.OrdinalIgnoreCase) <= 0 ? a : b;
                    var mayor = menor == a ? b : a;
                    var clave = menor + "|" + mayor;
                    if (vistas.Contains(clave)) continue;
                    vistas.Add(clave);
                    sb.AppendLine($"{menor} - {mayor} : {peso}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public Tuple<double, List<string>> CalcularDistanciaMinima(string origen, string destino)
        {
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            if (!_listaAdyacencia.ContainsKey(origen) || !_listaAdyacencia.ContainsKey(destino))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            var dist = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
            var prev = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var visitado = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var nodo in _listaAdyacencia.Keys)
            {
                dist[nodo] = double.PositiveInfinity;
                prev[nodo] = null;
            }
            dist[origen] = 0.0;

            while (true)
            {
                string actual = null;
                double mejor = double.PositiveInfinity;
                foreach (var nodo in _listaAdyacencia.Keys)
                {
                    if (visitado.Contains(nodo)) continue;
                    if (dist[nodo] < mejor)
                    {
                        mejor = dist[nodo];
                        actual = nodo;
                    }
                }

                if (actual == null) break;
                if (double.IsPositiveInfinity(mejor)) break;
                if (string.Equals(actual, destino, StringComparison.OrdinalIgnoreCase)) break;

                visitado.Add(actual);

                foreach (var vecino in _listaAdyacencia[actual])
                {
                    var v = vecino.Key;
                    var peso = vecino.Value;
                    if (visitado.Contains(v)) continue;
                    var alt = dist[actual] + peso;
                    if (alt < dist[v])
                    {
                        dist[v] = alt;
                        prev[v] = actual;
                    }
                }
            }

            if (double.IsPositiveInfinity(dist[destino]))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            // reconstruir camino
            var camino = new List<string>();
            var nodoCamino = destino;
            while (nodoCamino != null)
            {
                camino.Insert(0, nodoCamino);
                prev.TryGetValue(nodoCamino, out nodoCamino);
            }

            return new Tuple<double, List<string>>(dist[destino], camino);
        }

        // Lista de edificios 
        public List<string> ObtenerEdificios()
        {
            return _listaAdyacencia.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase).ToList();
        }
    }
}
