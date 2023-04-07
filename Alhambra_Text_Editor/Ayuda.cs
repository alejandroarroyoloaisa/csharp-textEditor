using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alhambra_Text_Editor
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            archivoBoton_Click(new object(), new EventArgs());
        }

        private void archivoBoton_Click(object sender, EventArgs e)
        {
            textoAyuda.Text =   "En esta pestaña del menú están contenidas las opciones del programa para el manejo de ficheros de texto \n(Nuevo, Abrir, Guardar) y cerrar la aplicación." +
                                "\n\n   --> NUEVO:              [Atajo: Ctrl + Shift + N]\n" +
                                "\nEl botón NUEVO sirve para empezar nuevos documentos. Al clicar sobre él, se borra por completo el fichero\nactual(sin guardarlo), mostrándole al usuario una página nueva de un documento de texto sin guardar." +
                                "\n\n   --> ABRIR:              [Atajo: Ctrl + O]\n" +
                                "\nEl botón ABRIR sirve para cargar documentos de texto (solo y exclusivamente en formato.txt), que ya hayan\nsido creados con anterioridad. Al clicar sobre él, se abrirá una ventana donde se deberá de buscar el fichero\nque se desea abrir. El procedimiento para abrir un fichero es:" +
                                "\n\n    1º Clicar en ARCHIVO.\n\n    2º Clicar en ABRIR.\n\n    3º En la ventana emergente, buscar el fichero deseado.\n\n    4º Seleccionar y clicar en ABRIR.\n\nDespués de esto, el documento de texto deberá de mostrarse en el Editor de texto." +
                                "\n\n   --> GUARDAR:              [Atajo: Ctrl + G]\n" +
                                "\nEl botón GUARDAR sirve para salvar el documento de texto actual, con todas sus modificaciones de estilo.\nAl clicar sobre él, se abrirá una ventana donde se deberá de buscar dónde se quiere guardar el documento\ny con qué nombre. El formato será SIEMPRE .txt." + 
                                "\n\n   --> SALIR:              [Atajo: Alt + F4]\n" +
                                "\nEl botón SALIR sirve para cerrar la aplicación. Al clicar sobre él, se cerrará por completo el programa, sin\nguardar el documento actual.Si se requiere guardar el documento actual, se debe pulsar en GUARDAR\nantes de pulsar en SALIR.";
        }

        private void herramientasBoton_Click(object sender, EventArgs e)
        {
            textoAyuda.Text = "En esta pestaña del menú están contenidas las funcionalidades de modificación del estilo del texto. Si se tiene\nseleccionado sólo una parte del texto, los estilos se aplicarán al texto elegido." +
                                "\n\n   --> NEGRITA:            [Atajo: Ctrl +N]\n" +
                                "Al clicar sobre él, se establece como estilo para el texto la NEGRITA al clicar sobre él." +
                                "\n\n   --> CURSIVA:          	[Atajo: Ctrl +K]\n" +
                                "Al clicar sobre él, se establece como estilo para el texto la CURSIVA al clicar sobre él." +
                                "\n\n   --> SUBRAYADO:          	[Atajo: Ctrl +S]\n" +
                                "Al clicar sobre él, se establece como estilo para el texto el SUBRAYADO al clicar sobre él." +
                                "\n\n   --> TACHADO:          	[Atajo: Ctrl +T]\n" +
                                "Al clicar sobre él, se establece como estilo para el texto el TACHADO al clicar sobre él." +
                                "\n\n   --> ALINEAR A LA IZQUIERDA:\n" +
                                "Al clicar sobre él, se establece como estilo para el texto el ALINEADO A LA IZQUIERDA al clicar sobre él." +
                                "\n\n   --> CENTRAR:\n" +
                                "Al clicar sobre él, se establece como estilo para el texto el CENTRADO al clicar sobre él." +
                                "\n\n   --> ALINEAR A LA DERECHA:\n" +
                                "Al clicar sobre él, se establece como estilo para el texto el ALINEADO A LA DERECHA al clicar sobre él." +
                                "\n\n   --> TAMAÑO DE FUENTE:\n" +
                                "Al clicar sobre él, se despliega un submenú con opciones para aumentar o disminuir el tamaño de la fuente\nque se está escribiendo." +
                                "\n\n   --> COLOR DE FUENTE:\n" +
                                "Al clicar sobre él, se abre una ventana emergente con colores disponibles para aplicar sobre el texto del\ndocumento. Se selecciona uno (o se crea uno personalizado) y después se da clic en “Aceptar” para aplicar\ndicho color al texto de ahora en adelante." +
                                "\n\n   --> CAMBIAR TIPOGRAFÍA:\n" +
                                "Al clicar sobre él, se abre una ventana emergente con Tipografías y Tamaños de fuente aplicables al texto\ndel documento. Si se requiere de una Tipografía que no se muestra en la lista, debe instalarla en su\ncomputadora. Se deben de elegir las modificaciones requeridas y después hacer clic en “Aceptar” para\naplicar los cambios para el texto de ahora en adelante." +
                                "\n\n   --> CONTAR:\n" +
                                "Al clicar sobre él, se despliega un submenú con tres opciones de conteo: “Letras”, “Palabras”, “Párrafos”.\nSe clica sobre la opción deseada para que el programa de ahora en adelante cuente en el modo deseado.\nDe manera predeterminada, el programa cuenta la cantidad de letras escritas en el documento. Dicha\ncantidad y el modo seleccionado aparecerá en la esquina inferior izquierda del programa.";
        }

        private void editarBoton_Click(object sender, EventArgs e)
        {
            textoAyuda.Text =   "En esta pestaña del menú están contenidas las funcionalidades de edición de texto tales como Deshacer,\nRehacer, Seleccionar Todo, Cortar, Copiar y Pegar." +
                                "\n\n   --> DESHACER:              [Atajo: Ctrl + Z]\n" +
                                "\nEl botón DESHACER sirve para eliminar la última modificación del documento de texto. Al clicar sobre él, se\nretrocede en los cambios aplicados en el documento. Se puede clicar tantas veces como cambios se han\nhecho durante la sesión del documento actual, por lo tanto todos los cambios realizados pueden llegar a\ndeshacerse." +
                                "\n\n   --> REHACER:              [Atajo: Ctrl + Y]\n" +
                                "\nEl botón REHACER sirve para volver a aplicar la última modificación que fue deshecha en el documento de\ntexto. Al clicar sobre él, se avanza en los cambios aplicados en el documento. Se puede clicar tantas veces\ncomo cambios se han deshecho durante la sesión del documento actual, por lo tanto todos los cambios\neliminados pueden llegar a rehacerse." +
                                "\n\n   --> SELECCIONAR TODO: \n" +
                                "\nEl botón SELECCIONAR TODO coloca en la selección todo el texto del documento." +
                                "\n\n   --> CORTAR:              [Atajo: Ctrl + X]\n" +
                                "\nEl botón CORTAR sirve para eliminar del documento el texto seleccionado y guardarlo en el portapapeles. Se\npuede utilizar después PEGAR para volverlo a colocar donde se guste." +
                                "\n\n   --> COPIAR:              [Atajo: Ctrl + C]\n" +
                                "\nEl botón COPIAR sirve para guardar en el portapapeles una copia del texto seleccionado del documento. Se\npuede utilizar después PEGAR para colocar una copia de dicho texto donde se guste." +
                                "\n\n   --> PEGAR:              [Atajo: Ctrl + V]\n" +
                                "\nEl botón PEGAR sirve para colocar una copia del texto guardado en el portapapeles."; 
        }
    }
}
