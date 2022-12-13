# hexagonMadness
Proyecto de fin de ciclo

<p><b>----IMPORTANTE----</b></p>
<p>Este juego tira de una API REST que esta montada de forma local.
Para que funcione hay que tener una base de datos (Recomendado XAMPP) llamada hexagonmadness con una tabla que sea records
La tabla debe tener un id int autoincremental y una columna llamada nombre varchar y otra valor int
El resto de instrucciones se encuentran en la carpeta PruebaNodejs en el fichero basededatos.txt
Basicamente hay que abrir la carpeta con Visual Studio Code, abrir un terminal y escribir el comando node .
Esto hará que la API este activa y escuchando, una vez esto esta listo lanzamos el juego y a disfrutar!</p>

<p><b>----SENTENCIAS SQL----</b>
create database hexagonmadness;

use hexagonmadness;

CREATE TABLE records(
    id int NOT NULL AUTO_INCREMENT,
    nombre varchar(255),
    valor int(11),
    PRIMARY KEY (id)
);</p>

<p><b>----HISTORICO----</b></p>
<p>FECHA: 28/11/2021</p>
<p><b>TITULO DEL COMMIT: Initial commit.</b> Primer commit del proyecto, simplemente para abrir el mismo, hacer un par de carpetas y comprobar que la instalación
de GitHub Desktop funciona correctamente.</p>

<p><b>TITULO DEL COMMIT: Primer commit.</b> Pantalla de juego básica. Movimiento del personaje, colisiones, generación de enemigos y movimiento de la cámara. El proyecto esta creado en unity como tal. Lista una escena básica con lo que sería el juego y toda su lógica.</p>

<p>FECHA: 7/12/2021</p>
<p><b>TITULO DEL COMMIT: Menu simple.</b> Creación de un menú simple que nos permite abrir el juego, salir de el y acceder a una pestaña de opciones que aún no está preparada. Añadida la imágen de fondo del menú al proyecto. Montadas las escenas: Menu y Game.</p>

<p>FECHA: 8/12/2021</p>
<p><b>TITULO DEL COMMIT: Pantalla de fin del juego.</b> Añadida pantalla de fin del juego. También el sistema de puntuación. Añadidos los distintos botones de la pantalla de fin del juego el de guardar record sin funcionalidad. No hay una escena para la pantalla de fin de juego ya que no se consideró oportuno, simplemente se revela una pantalla que esta ahí desde que se carga el juego.</p>

<p>FECHA: 4/01/2022</p>
<p><b>TITULO DEL COMMIT: Añadidos efectos de sonido y música.</b> Problemas con los efectos de sonido en los botones que cargan una escena. En este commit se gestionan y añaden todos los sonidos que van a ser usados. Cada vez que se añada una nueva escena a partir de ahora se usará lo que se montó aquí para gestionar tanto música como efectos de sonido, si bien los clicks de los botones en este punto no acaban de funcionar.</p>

<p>FECHA: 22/03/2022</p>
<p><b>TITULO DEL COMMIT: Corrección del audio y añadido de la escena de Creditos.</b> Vistazo y corrección de algunos errores en el tratamiento del audio, gestión de el apartado de ajustes para poder cambiar el volumen con un slider y añadida y gestionada la escena de créditos. Aquí no solo se arregla el problema de los sonidos de los botones si no que la forma en la que se estaba gestionando el sonido en general tenía un par de bugs que quedan arreglados.</p>

<p>FECHA: 11/12/2022</p>
<p><b>TITULO DEL COMMIT: Creación/Gestión de API REST.</b> Creación de la API REST para poder cargar/leer datos de la base de datos para el guardado y leido de records (todo esto en la carpeta PruebaNodejs). Comenzada la gestión de la API desde UNITY con la creación de una nueva escena para guardar los records. Añadida la escena SaveRecord gestionando cosillas básicas como gestión del audio y movimiento en la aplicación (volver al menú).</p>

<p><b>TITULO DEL COMMIT: Gestión de escena guardar record e intentando POST.</b> Gestionada la escena de guardar record para que pueda mostrar mensajes de error, y que tenga todos los eventos listos, volver al menú, volver al juego, guardar record y el sonido al clickar los botones. También se añade aquí el input para que el usuario pueda meter datos para el guardado y se decide usar el evento que se lanza cada vez que cambia el estado del texto del dicho input. Intentando, sin mucho éxito, gestionar el POST desde unity a la API de REST.</p>

<p><b>TITULO DEL COMMIT: Gestionado el POST sobre la API REST.</b> Conseguido el funcionamiento deseado al pulsar el boton de guardar record. Hace el POST correctamente. En este commit sólo se consigue el funcionamiento de dicho POST, la razón de peso para separar este commit y el anterior es que entre commits se produce un cambio de equipo en el que se esta trabajando y por razones de seguridad y para no perder nada se decide hacer el anterior commit.</p>

<p>FECHA: 12/12/2022</p>
<p><b>TITULO DEL COMMIT: Gestionado el GET, creada nueva seccion y toques finales.</b> Gestion del GET a la API REST creando una nueva sección parecida a la de creditos para procesar y enseñar la informacion (tiene un bug al enseñar los textos que no soy capaz de arreglar) añadida una imagen para el titulo del juego. Cabe mencionar un repasillo final al proyecto en general para comprobar que todo funciona y nada (de vital importancia) se rompe. Cambios en el README.</p>

<p>FECHA: 13/12/2022</p>
<p><b>TITULO DEL COMMIT: README.</b> Creación del histórico en el README, aparte de añadir una sentencia de creación sql para la creación de la bd y la tabla. Subido al proyecto un script "sentenciasSQL.sql" que también contiene dichas sentencias.</p>

<p><b>TITULO DEL COMMIT: README 2.</b> Debido a que el README fue editado en el propio GitHub en navegador se hace este último commit con el fichero sql y las sentencias en el README</p>
