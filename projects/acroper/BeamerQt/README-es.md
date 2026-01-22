# BeamerQt
BeamerQT es una interfaz gráfica amigable diseñada para facilitar la creación de presentaciones Beamer sin editar manualmente el código LaTeX asociado con las diapositivas. Proporciona un conjunto completo de características que permiten a los usuarios definir diseños, insertar contenido (incluyendo texto, bloques e imágenes) y configurar algunos ajustes avanzados del tema. BeamerQT ofrece tanto a principiantes como a usuarios avanzados de LaTeX la capacidad de crear presentaciones increíbles y enfocarse en los contenidos en lugar del código.

### Requisitos de la biblioteca:
* PyQt6

* PyMuPDF

<img src="https://github.com/user-attachments/assets/b123f050-dff5-4584-b40d-c2fd581c2f16" width="600">


# Características
BeamerQT cuenta con una interfaz gráfica de usuario que proporciona acceso fácil a las funciones más deseadas de Beamer/LaTeX sin añadir código LaTeX. 

## Editor de Temas (¡Nueva función!)
Editar el código fuente de las plantillas. 

* Soporta la inclusión de archivos adjuntos.
* Extrae archivos adjuntos durante la generación de LaTeX.
* Comparte fácilmente el archivo .xml personalizado.
* Nuevas funciones próximamente.

## Selección de Diseño
BeamerQT ofrece una variedad de esquemas de diseño predefinidos inspirados en herramientas comunes de presentación como PowerPoint o LibreOffice Impress. En lugar de escribir manualmente código LaTeX para columnas y bloques, el usuario puede simplemente seleccionar un diseño y BeamerQT insertará y gestionará automáticamente las columnas y bloques necesarios de Beamer.

Capacidades clave incluyen: 

* Creación automática de columnas y bloques basada en el diseño elegido. 
* Un control deslizante para ajustar dinámicamente el ancho de las columnas, sin editar el código manualmente. 
* Reconfiguración fluida del diseño de la diapositiva con mínima intervención del usuario.

<img src="https://github.com/user-attachments/assets/1c313ed2-337c-4925-aaef-b18aa718bd0e" width="600">

<img src="https://github.com/user-attachments/assets/305af2c5-7726-43bd-b457-fe68d8ff3fd9" width="600">


## Diapositivas

Cada diapositiva puede contener un título, un subtítulo y un conjunto de bloques para contenido. Además, las diapositivas pueden configurarse como una nueva sección o subsección, permitiendo la inserción automática de los títulos correspondientes de sección o subsección en la presentación.

Características clave: 

* Entrada fácil del título y subtítulo de la diapositiva. 
* Marcar una diapositiva como sección o subsección para estructurar la presentación. 
* Ajuste automático de las opciones de formato a nivel de diapositiva.

## Lista de Diapositivas

La Lista de Diapositivas ofrece una vista general de toda la presentación, mostrando la posición, número y título de cada diapositiva. Las secciones y subsecciones están claramente marcadas, ayudando en la navegación y organización. Los usuarios pueden reordenar, duplicar, copiar o eliminar diapositivas según sea necesario, asegurando una gestión eficiente de las diapositivas.

## Bloques

Los bloques son unidades fundamentales de contenido en BeamerQT. La herramienta soporta varios tipos de bloques—como Bloque, Alerta, Ejemplo o bloques de texto plano—a través de una interfaz simple de botones de opción. Este enfoque elimina la necesidad de escribir comandos LaTeX manualmente.

Las funcionalidades principales de los bloques incluyen: 

* Selección del tipo de bloque (Bloque, Alerta, Ejemplo o texto plano). 
* Controles de posición para reorganizar los bloques dentro del diseño. 
* Un botón dedicado para eliminar el bloque de la diapositiva. 
* Un campo de título y un área de entrada de texto para cada bloque, con soporte multilínea. 
* Saltos de línea automáticos o retención de saltos de línea manuales según la entrada del usuario.
* Múltiples sub-bloques
<img src="https://github.com/user-attachments/assets/5b914c96-e691-4fdf-af42-faba89b2c8f4" width="600">


## Sub-bloques

Los sub-bloques permiten una organización de contenido más granular dentro de un bloque. Cada bloque contiene al menos un sub-bloque (generalmente basado en texto), y los usuarios pueden añadir múltiples sub-bloques según sea necesario.

Las características de los sub-bloques incluyen: 

* Disposición en hasta cuatro columnas, con botones de navegación horizontal para reordenar sub-bloques. 
* Un control deslizante para ajustar el ancho de las columnas, ofreciendo una personalización flexible del diseño. 
* Controles de alineación para cada sub-bloque (izquierda, centro, derecha o predeterminado).

## Sub-bloque de imagen

El sub-bloque de imagen es un tipo especializado de sub-bloque para insertar imágenes. BeamerQT soporta archivos bitmap (por ejemplo, .jpg, .png), imágenes vectoriales (.svg) y archivos .pdf. Para imágenes .svg, BeamerQT utiliza Inkscape para convertirlas a formato .pdf, asegurando una integración fluida en la presentación final (probado solo en sistemas Linux).

Características del sub-bloque de imagen: 
* Tamaño de imagen ajustable como porcentaje del ancho del sub-bloque.  
* Adaptación automática a cambios de diseño para visuales escalados de forma consistente.  
* Compatibilidad con múltiples formatos de imagen, asegurando flexibilidad en el diseño de la presentación.  

## Front-matter  

La sección front-matter permite una configuración sencilla de ajustes generales de la presentación. Los usuarios pueden definir el título de la presentación, los nombres de los autores y personalizar el preámbulo de LaTeX. Además, se pueden habilitar funciones avanzadas para refinar aún más la apariencia y estructura general de la presentación, tales como:  

* Cambiar la relación de aspecto (4:3 a 16:9).  
* Crear diapositivas de título para cada sección.  
* Generar automáticamente un marco de esquema para cada sección.  
<img src="https://github.com/user-attachments/assets/07629d96-ba38-4e5b-87ff-c1648598ad9f" width="600">  

<img src="https://github.com/user-attachments/assets/bb47ffe5-7d92-408e-a42d-1cd734f53d51" width="600">  

<img src="https://github.com/user-attachments/assets/9149eb46-020a-4f02-b3fe-9959fb231fd3" width="600">  

## Generación de LaTeX  

Cuando el usuario está satisfecho con el contenido y el diseño, al hacer clic en el botón **Generar LaTeX** se exporta la presentación a LaTeX y se ejecuta pdflatex para compilar un PDF. El PDF resultante se muestra de inmediato, permitiendo una revisión rápida.  

El botón **Carpeta LaTeX** abre el directorio de salida, permitiendo personalizaciones adicionales o integración con otras herramientas. Tenga en cuenta que cada generación de LaTeX sobrescribe los archivos en la carpeta de salida.  

## Formato de archivo  

BeamerQT utiliza un formato de archivo .bqt, que es esencialmente un directorio comprimido que contiene todos los metadatos necesarios, tales como:  

* Un archivo XML con detalles de la presentación.  
* Imágenes de vista previa de las diapositivas.  
* (Función futura) Imágenes incrustadas y temas personalizados para asegurar portabilidad.  

Este enfoque garantiza que los archivos .bqt puedan compartirse fácilmente, realizar copias de seguridad y editarse en diferentes sistemas sin perder datos esenciales.  

## Instalación







* Windows

  Instalar MikTex:
  
  https://miktex.org/download

  Instalar BeamerQT:
  
  https://sourceforge.net/projects/beamerqt/

* Linux
  Instalar python3, TexLive e Inkscape, según tu distribución:
  

  Basado en Debian:
  ```
  apt-get install python3 texlive-beamer inkscape 
  ```
  Instalar PyQt6 y PyMuPDF:
  ```
  pip install pyqt6 pymupdf
  ```
  

  Ejecutar BeamerQT:

  Descargue el código fuente de BeamerQT desde este repositorio.
  
  Abra una terminal en el directorio que contiene el archivo main.py
  ```
  python3 main.py
  ```

## Video de ejemplo:

https://www.youtube.com/watch?v=XQKJbuT8q1g

## Capturas de pantalla:
### Interfaz gráfica de BeamerQT
<img src="https://github.com/user-attachments/assets/cf332d4e-9962-4251-9619-67e146af9851" width="600">

### Salida PDF
<img src="https://github.com/user-attachments/assets/be7b2e0c-20a4-41f0-b09d-93131973c4d4" width="600">


## Donar
Por favor, done para ayudarme a desarrollar este software. Enlace para donación Paypal:

https://www.paypal.com/donate/?business=2PP5H8Z8L5E8E&no_recurring=0&item_name=Support+the+development+of+BeamerQT&currency_code=USD


## Libro de ciencia ficción
Si le gustó esto, también podría interesarle mi libro de ciencia ficción, Synapses: The Chaos of Order.

http://synapsesbook.wordpress.com/

Jorge Guerrero



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-22

---