#Caso de Estudio: Árboles y Grafos en C#
Universidad Americana (UAM)

Asignatura: Programación Estructurada
Docente: MSc. José Alejandro Durán García
Estudiante: Rolando Enrique Mayorga Mena

#🏢 Sistema Jerárquico y de Rutas para el Parque Tecnológico “Innovatec”

Este proyecto desarrolla un sistema completo en C# con Windows Forms que permite gestionar:

La jerarquía organizativa del Parque Tecnológico mediante un árbol general (N-ario).

Las rutas internas entre edificios mediante un grafo no dirigido y ponderado, incluyendo el cálculo de la ruta más corta con el algoritmo de Dijkstra.

El programa cumple con todos los requerimientos establecidos en el Caso de Estudio: Árboles y Grafos de la Universidad Americana.

#📂 Estructura del Proyecto

El código está organizado de la siguiente manera:

Archivo	Descripción
ArbolController.cs	Manejo del Árbol: insertar, buscar, eliminar, contar y recorrer nodos.
GrafoController.cs	Manejo del Grafo: edificios, conexiones, distancias y Dijkstra.
Form1.cs	Interfaz gráfica y conexión con los controladores.
Program.cs	Punto de ejecución del programa.

#🌳 Parte A — Árbol: Jerarquía Organizativa del Parque

El árbol permite modelar la estructura organizativa de Innovatec: áreas, departamentos, oficinas, secciones, etc.

✔️ Funcionalidades del Árbol
🔹 Inserción de Nodos

El primer nodo añadido se convierte en la raíz.

Los siguientes pueden agregarse:

Como hijos del nodo seleccionado.

Como hijos directos de la raíz.

No permite duplicados.

🔹 Búsqueda Recursiva

Case-insensitive.

Recorrido en preorden.

Permite resaltar el nodo encontrado en el TreeView.

🔹 Eliminación de Nodos y Subárboles

Puede eliminar:

Nodos hoja

Nodos con hijos (borra todo el subárbol)

La raíz completa

Devuelve la cantidad de nodos eliminados.

🔹 Recorridos Implementados

Pre-Orden

Post-Orden

Por Niveles (BFS)

Los resultados se muestran en la interfaz mediante etiquetas.

🔹 Conteo Total de Nodos

Representa el número de “ramas” del árbol.

Útil para reportes y validaciones.

#🕸️ Parte B — Grafo: Sistema de Rutas del Parque

El grafo representa edificios y caminos internos con sus respectivas distancias.

✔️ Representación Interna: Lista de Adyacencia
Dictionary<string, Dictionary<string, double>>

Donde:

Clave: nombre del edificio.

Valor: conexiones con otros edificios y su distancia.

Ventajas

Acceso O(1) promedio a cada nodo.

Ideal para grafos dispersos.

Permite una lectura clara y directa de las rutas.

✔️ Funcionalidades del Grafo

🔹 Agregar Edificios

Valida nombres duplicados.

Entrada segura contra espacios en blanco.

🔹 Agregar Conexiones

Conexiones bidireccionales: A ↔ B.

Distancias numéricas positivas.

Valida edificios inexistentes.

🔹 Mostrar Grafo Completo

Lista todos los edificios.

Lista todas las conexiones sin duplicados (A–B se muestra solo una vez).

✔️ Algoritmo de Ruta Más Corta — Dijkstra

Implementado completamente desde cero.
Incluye:

Inicialización de distancias.

Conjunto de nodos visitados.

Relajación de aristas.

Reconstrucción del camino mínimo.

#🖥️ Interfaz Gráfica del Usuario (Windows Forms)
✔️ Módulo Árbol

Agregar elementos.

Buscar y subrayar nodo.

Eliminar nodos y subárboles completos.

Mostrar recorridos.

Mostrar número de nodos (“ramas”).

✔️ Módulo Grafo

Agregar edificios.

Conectar edificios con distancias.

Mostrar representación completa del grafo.

Calcular ruta mínima con Dijkstra.

Toda la lógica se ejecuta a través de los métodos de ArbolController y GrafoController.