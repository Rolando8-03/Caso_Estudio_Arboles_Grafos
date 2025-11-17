using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArbolesGrafosApp
{
    public partial class Form1 : Form
    {
        private ArbolController arbol = new ArbolController();
        private TreeNode ultimoSubrayado = null;
        // Campos y helpers a pegar dentro de la clase Form1 (afuera de los manejadores)
        private GrafoController grafo = new GrafoController();

        // Actualiza la etiqueta que muestra el grafo (lblGrafo)
        private void ActualizarLabelGrafo()
        {
            lblGrafo.Text = grafo.ObtenerRepresentacion();
        }

        // Muestra resultado de la ruta mínima en lblCalcularDistancia
        private void MostrarResultadoCamino(double distancia, List<string> camino)
        {
            if (double.IsPositiveInfinity(distancia) || camino == null || camino.Count == 0)
            {
                lblCalcularDistancia.Text = "No existe camino entre los edificios.";
                return;
            }

            lblCalcularDistancia.Text = $"Distancia mínima: {distancia}" + Environment.NewLine +
                                        "Camino: " + string.Join(" -> ", camino);
        }

        private TreeNode CrearTreeNode(ArbolController.Nodo m)
        {
            var tn = new TreeNode(m.Valor);
            foreach (var h in m.Hijos) tn.Nodes.Add(CrearTreeNode(h));
            return tn;
        }

        private void ActualizarVista()
        {
            tvArbol.BeginUpdate();
            tvArbol.Nodes.Clear();
            if (arbol.Raiz != null)
            {
                var raizTN = CrearTreeNode(arbol.Raiz);
                tvArbol.Nodes.Add(raizTN);
                raizTN.Expand();
            }
            tvArbol.EndUpdate();
            lblRamas.Text = "Número de ramas: " + arbol.ContarNodos();
        }
            private void LimpiarSubrayado()
        {
            if (ultimoSubrayado != null)
            {
                ultimoSubrayado.NodeFont = null;
                ultimoSubrayado = null;
            }
        }

        private TreeNode BuscarTreeNode(TreeNodeCollection coll, string texto)
        {
            foreach (TreeNode tn in coll)
            {
                if (string.Equals(tn.Text, texto, StringComparison.OrdinalIgnoreCase)) return tn;
                var r = BuscarTreeNode(tn.Nodes, texto);
                if (r != null) return r;
            }
            return null;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            var texto = tbAgregarElemento.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // determinar padre: si no hay raíz -> crear raíz; si hay selección -> hijo del seleccionado; si no -> hijo de la raíz
            string padre = null;
            if (arbol.Raiz != null)
            {
                if (tvArbol.SelectedNode != null) padre = tvArbol.SelectedNode.Text;
                else padre = arbol.Raiz.Valor;
            }

            if (!arbol.Agregar(texto, padre))
                MessageBox.Show("No se agregó (duplicado o padre no encontrado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ActualizarVista();
                tbAgregarElemento.Clear();
                tbAgregarElemento.Focus();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var texto = tbBuscar.Text?.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese nombre a buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nodo = arbol.Buscar(texto);
            if (nodo == null)
            {
                MessageBox.Show("No encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ActualizarVista();
            LimpiarSubrayado();
            var tn = BuscarTreeNode(tvArbol.Nodes, texto);
            if (tn != null)
            {
                tn.NodeFont = new System.Drawing.Font(tvArbol.Font, System.Drawing.FontStyle.Underline);
                ultimoSubrayado = tn;
                tvArbol.SelectedNode = tn;
                tn.EnsureVisible();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string valor = tvArbol.SelectedNode != null ? tvArbol.SelectedNode.Text : tbBuscar.Text?.Trim();
            if (string.IsNullOrEmpty(valor))
            {
                MessageBox.Show("Seleccione o escriba nombre para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eliminados = arbol.Eliminar(valor);
            if (eliminados == 0)
            {
                MessageBox.Show("No encontrado o no eliminado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ActualizarVista();
            LimpiarSubrayado();
            tbBuscar.Clear();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (arbol.Raiz == null)
            {
                MessageBox.Show("Árbol vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbRecorrer.SelectedItem == null)
            {
                MessageBox.Show("Elija tipo de recorrido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tipo = cbRecorrer.SelectedItem.ToString();
            List<string> lista;
            if (tipo == "Pre-Orden") lista = arbol.RecorrerPreOrden();
            else if (tipo == "Post-Orden") lista = arbol.RecorrerPostOrden();
            else lista = arbol.RecorrerPorNiveles();

            lblRecorrer.Text = string.Join(Environment.NewLine, lista);
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            // validar nombre
            var nombre = tbAgregarEdificio.Text?.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del edificio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // intentar agregar
            if (!grafo.AgregarEdificio(nombre))
            {
                MessageBox.Show("No se agregó. El edificio ya existe o el nombre es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // actualizar etiqueta que muestra el grafo (cada conexión y sus distancias)
            ActualizarLabelGrafo();
            tbAgregarEdificio.Clear();
            tbAgregarEdificio.Focus();
        }

        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            var a = tbNombreEdificio1.Text?.Trim();
            var b = tbNombreEdificio2.Text?.Trim();
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                MessageBox.Show("Ingrese ambos nombres de edificio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbDistancia.Text, out double distancia) || distancia <= 0)
            {
                MessageBox.Show("Ingrese una distancia válida (número positivo).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar conexión (no dirigida): el método guarda A->B y B->A internamente.
            if (!grafo.AgregarConexion(a, b, distancia))
            {
                MessageBox.Show("No se pudo agregar la conexión. Verifique que los edificios existan y que los datos sean válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // actualizar visualización del grafo que muestra todas las conexiones y sus pesos
            ActualizarLabelGrafo();

            // limpiar campos
            tbNombreEdificio1.Clear();
            tbNombreEdificio2.Clear();
            tbDistancia.Clear();
            tbNombreEdificio1.Focus();
        }

        private void btnCalcularDistancia_Click(object sender, EventArgs e)
        {
            var origen = tbCalcularDistancia1.Text?.Trim();
            var destino = tbCalcularDistancia2.Text?.Trim();
            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Ingrese origen y destino.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // calcular camino mínimo (Dijkstra)
            var resultado = grafo.CalcularDistanciaMinima(origen, destino);
            MostrarResultadoCamino(resultado.Item1, resultado.Item2);
        }
    }
}
