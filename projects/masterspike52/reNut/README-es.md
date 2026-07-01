

<img width="1920" height="1080" alt="renut logo" src="https://github.com/user-attachments/assets/273bee28-755f-4494-920f-9333af72091e" />




Originally created with <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a>



DISCORD
--------------------------------------------
We have a discord, please join and direct any questions there. Myself or someone else will happily answer them.

https://discord.gg/D5Bz2ZsHdY



Credits
------------------------------------------------
<a href="https://github.com/rexglue/rexglue-sdk">Rexglue team</a> for creating Rexglue-SDK
<br>
the Rexglue SDK discord for helping with any info they have
<br>
SolarCookies for midasm hooks and future use of CRT functions and the reNut Launcher
<br>
ValcomDrifty for the renut logo
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
.
<br>
tú, el jugador?
<br>
.


REQUISITOS
-------------------------------------------------------------------
Versión estadounidense de banjo-kazooie: nuts and bolts default.xex


CÓMO CONSTRUIR
------------------------------------------------------
NOTA: DEBES ELIMINAR TODAS LAS INSTANCIAS DE .gitignore, DE LO CONTRARIO, LO QUE COMPILES NO PODRÁ VER LOS ARCHIVOS EN LAS ÁREAS DONDE ESTÁN.
<br>
NOTA: DEBES INSTALAR <a href="https://git-scm.com/install/windows">GIT</a> ANTES DE INSTALAR EL REXGLUE-SDK O DE CONSTRUIR ESTE REPOSITORIO.
<br>
NOTA: DEBES CONSTRUIR E INSTALAR EL REPOSITORIO PRINCIPAL DE <a href="https://github.com/rexglue/rexglue-sdk">Rexglue-SDK</a> ANTES DE CONTINUAR


1. Clona el repositorio con ```git clone https://github.com/masterspike52/reNut.git```
2. Dentro de la carpeta assets necesitas extraer el contenido del iso de banjo-kazooie: Nuts&Bolts y el default.xex. Recomiendo usar <a href="https://consolemods.org/wiki/images/5/5f/XBOX360_ISO_Extract.zip">iso extract</a>. (No sé qué usan los usuarios de Linux. Yo uso Windows, sin embargo iso extract funciona en Linux a través de WINE.)
3. Dentro de tu git clonado abre una terminal y ejecuta ```rexglue migrate --app_root .``` Esto asegura que si algo cambia con codegen en Rexglue, puedas hacer codegen correctamente.
   3b. Luego debes eliminar tu carpeta out, o si estás en Windows puedes abrir VS, hacer clic derecho en tu cmakelists.txt, eliminar la caché y reconfigurar para que hagas codegen con la versión que usas.
4. Ahora puedes abrir una terminal y ejecutar ```rexglue codegen renut_config.toml``` que te dará los archivos ppc para recompilar en la carpeta generated.
5. Si estás en Windows, puedes abrir el proyecto en VS, cambiar el tipo de compilación a `win-amd64-relwithdebinfo`, luego compilar todo.
   5b. Si estás en Linux y no tienes acceso a VS, necesitarás usar una terminal y ejecutar ```cmake --preset linux-amd64-relwithdebinfo``` y luego ```cmake --build --preset linux-amd64-relwithdebinfo```. (También puedes hacer esto en Windows, solo reemplaza `linux` por `windows`.)
6. Una vez compilado, necesitas tener el exe compilado en el mismo directorio que los assets, de lo contrario el juego no se abrirá.

HAY UN FORK PARA LINUX
-------------------------------------------------
Si deseas compilar para Linux, por favor usa este fork de <a href="https://github.com/etonedemid/reNut">reNut</a> hecho por etonedemid, requiere usar su fork de <a href="https://github.com/etonedemid/rexglue-sdk">rexglue</a> y él ha hecho un PR a rexglue para que estas cosas formen parte del main.


SI NO QUIERES COMPILAR
--------------------------------------------
Compilar es principalmente para quienes prefieren compilar o quieren ayudar a desarrollar el juego conmigo y otros. Si no quieres compilar;
* Ve a https://goopie.xyz/ y descarga el lanzador goopie
* En el lanzador selecciona banjo-kazooie: nuts and bolts
* Haz clic en Select ISO y selecciona tu iso de banjo-kazooie: nuts and bolts (debe ser la versión norteamericana) y espera a que termine la extracción
* Después de que la extracción haya terminado, haga clic en el botón de actualizar, el lanzador descargará la última versión de Windows de renut  
* Haga clic en jugar  

  
PROBLEMAS CONOCIDOS  
-----------------------------------------------  
1. Las animaciones están un poco irregulares (hay temblores, huesos de banjo y otros se rompen, algunas animaciones están a medio hacer, y otros pequeños detalles), pero no impiden el juego, es solo gracioso ver que sucede.  

  
CREAR UN PROBLEMA  
--------------------------  
La pestaña de Problemas es un lugar para cosas como fallos que ocurren en el juego y que no están ya anotados, por favor evite crear problemas como "El juego no se abre" o "¿Tengo que usar ISOs?".  
Debe usar la plantilla de fallo para cualquier problema relacionado con fallos (probablemente haré otras plantillas), para no saturarla con publicaciones mayormente de errores de usuario. Por favor, únase al discord y use el canal #help si tiene un problema no relacionado con un fallo.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---