<div align="center">
    <h1>GitQuill</h1>
    <img alt="Logo" src="https://raw.githubusercontent.com/adamsol/GitQuill/master/img/logo.jpg" width="200" />
    <h2>Interfaz gráfica multiplataforma para Git.</h2>
</div>

| ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/commit-history.png) | ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/file-diff.png) |
|-----------------------------------------|------------------------------------|


Características únicas
----------------------

* Edita archivos directamente en la vista de diferencias.
* Elige resaltado de sintaxis específico para tus extensiones de archivo.
* Modifica rápidamente commits anteriores con la herramienta de rebase.
* Configura enlaces desde mensajes de commit a tu gestor de incidencias.
* Configura botones para ejecutar cualquier comando Git con un clic.


Requisitos
----------

* [Git](https://git-scm.com/) 2.23+
* [Node.js](https://nodejs.org/) 18+


Instalación
-----------

```sh
npm install
npm run build
npm start
```
Notas
-----

* GitQuill tiene un mecanismo personalizado para guardar/restaurar el trabajo en progreso (WIP) usando ramas en lugar del stashing tradicional; esto se debe a que el stashing de Git tiene peculiaridades técnicas que dificultan su integración consistente en la interfaz.
* Si comienzas un rebase mientras tienes un archivo seleccionado, GitQuill revertirá todo el contenido del commit en el índice, manteniéndolo en el árbol de trabajo, para que puedas editar archivos sin salir de la aplicación.
* Cuando se detecta un conflicto, GitQuill reinicia automáticamente los archivos no fusionados, para evitar el estado especial del repositorio que complica el manejo. Los marcadores de conflicto permanecen para ser resueltos manualmente.
* GitQuill no vigila los archivos del repositorio para detectar cambios. El estado se actualiza cuando la aplicación recibe el foco o cuando realizas una acción relevante en la interfaz.
* GitQuill llama a los comandos `git` directamente. Puedes ver todas las operaciones ejecutadas en los archivos de registro de cada repositorio: `.git/.quill/app.log`.


Configuración
-------------

* Archivo de configuración por repositorio: `.git/.quill/config.json5`. Ejemplo:



  ```js
  {
      autolinks: [
          ['#(\\d+)', 'https://github.com/adamsol/GitQuill/issues/$1'],
      ],
      custom_actions: [
          { icon: 'mdi-download-outline', label: 'Pull', command: ['pull'] },
          { icon: 'mdi-upload-outline', label: 'Push', command: ['push'], click_twice: true },
      ],
  }
  ```

* Archivo de configuración global y automático (repositorios abiertos, diseño de la interfaz, etc): `%AppData%/GitQuill/config.json` para Windows; consulte https://electronjs.org/docs/api/app#appgetpathname para otras plataformas.


Contribuyendo
------------

¡Gracias por su interés en el proyecto! Generalmente no acepto solicitudes de extracción. La mejor manera de contribuir es reportar un error o sugerir una función a través de [Issues](https://github.com/adamsol/GitQuill/issues).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---