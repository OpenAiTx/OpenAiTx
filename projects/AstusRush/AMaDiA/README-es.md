# AMaDiA
Aplicación de Visualización Matemática de Astus<br/><br/>
Características actuales:<br/>
 * Usa (Shift+)AltGr+Tecla para escribir símbolos matemáticos (Consulta AMaDiA_ReplacementTables)<br/>
 * Pestaña 1 : Calculadora Científica<br/>
   * Calcula con +,-,±,×,÷,√,^,°, Integral f(x) dx, d(f(x))/dx, y'(x), números complejos, sin(), cos(), tan(), exp(), log(), π, E y más<br/>
   * Resuelve una ecuación con variables desconocidas<br/>
   * Resuelve ecuaciones diferenciales (incluyendo soluciones particulares)<br/>
   * Prueba la igualdad de dos términos<br/>
   * Usa símbolos matemáticos Unicode para teclear más rápido!<br/>
   * Activa unidades en las opciones para hacer cosas como convert_to(7foot+3inch,m)<br/>
   * Para un uso más detallado consulta Ayuda/Ejemplos y copia/pega los ejemplos en los campos de entrada de la pestaña correspondiente<br/>
 * Pestaña 2 : Convierte la entrada a LaTeX y la muestra<br/>
 * Pestaña 3 : Grafica gráficos 2D (los gráficos 3D y complejos están en desarrollo)<br/>
 * Pestaña 4 : Ecuaciones con matrices y vectores así como sistemas de ecuaciones lineales<br/>
 * Ventana de Control del Sistema : Todo para el control del sistema (en desarrollo)<br/>
 * Programa de chat LAN (requiere revisión)<br/>
   * Diseñado para compartir ecuaciones con otros usuarios en la misma red para facilitar el trabajo cooperativo<br/>
   * Aplicaciones separadas de Servidor y Cliente<br/>
   * Permite enviar texto y archivos de texto<br/>
   * Comparte archivos de texto con todos los usuarios de la red mediante arrastrar y soltar en el campo de entrada<br/>
   * El servidor tiene algunas herramientas de moderación (Silenciar/Expulsar/Prohibir)<br/>
   * ADVERTENCIA: ¡Los mensajes actualmente no están cifrados! ¡No envíes datos sensibles!!!<br/>
 * Marcos de ventana personalizados<br/>
<br/>
Comentarios son bienvenidos<br/>
Sugerencias son bienvenidas<br/>
Solicitudes son bienvenidas<br/>
<br/><br/>

# Cómo instalar
En Windows:<br/>
 * Instala https://gitforwindows.org/<br/>
 * Instala https://www.anaconda.com/distribution/<br/>
 * Crea dos archivos "AMaDiA.bat" y "AMaDiA_INSTALL.bat" y copia el texto de los dos archivos en WINDOWS-INSTALL en ellos haciendo clic derecho y seleccionando la opción modificar<br/>
 * Haz doble clic en "AMaDiA_INSTALL.bat" para instalar AMaDiA (La ubicación de instalación es la carpeta del usuario. Esto se puede cambiar editando ambos archivos.)<br/>
 * A partir de ahora hacer doble clic en AMaDiA.bat actualizará y luego ejecutará AMaDiA<br/>
 
(Aviso legal: Usa estos archivos .bat bajo tu propio riesgo. Dudo que puedan causar daño, pero no soy un experto en archivos batch y no puedo prever todas las eventualidades)<br/>
<br/>
   En Linux [WIP]:<br/>
 * sudo apt-install git<br/>
 * Instalar https://www.anaconda.com/distribution/ o sudo apt-install ...<br/>
 * [Comandos de consola para instalación y Alias para Actualización/Inicio próximamente (¿más o menos?)]<br/>
<br/>

   En OSX [???]:<br/>
 * No tengo acceso a OSX y ni siquiera estoy seguro de qué tan bien funciona AMaDiA en él (¿debería funcionar perfectamente?)... Lo siento, pero no puedo ayudarte...<br/>
 * Si alguien tiene una buena descripción de cómo instalar/actualizar+ejecutar fácilmente un script de python en OSX, siéntase libre de informarme para poder agregarlo aquí<br/>
 * Aquí https://github.com/AstusRush/AMaDiA/issues/2 hay una descripción de alguien que lo instaló en OSX

<br/><br/>
# Captura de Pantalla
Captura de pantalla Versión 0.15.7.1<br/>
<img src="/AMaDiA v0.15.7.1 Demo.png" alt="Imagen de demostración"/>
<br/><br/>
# Hoja de Ruta a "Corto" Plazo
Funciones planeadas para un futuro cercano (el orden refleja prioridad) (nota que la palabra "corto" es muy relativa aquí):<br/>
- Graficar funciones 3D y complejas<br/>
- Mejorar la ventana de control del sistema<br/>
- (Continuo:) Mejor parser para permitir una entrada más flexible<br/>
<br/><br/>
# Hoja de Ruta a Largo Plazo
Funciones planeadas para el futuro (el orden refleja prioridad):<br/>
- Hacer que la Pestaña 4 sea aún más fácil de usar<br/>
- Editor de texto simple<br/>
- Mejor manejo de unidades (como simplificación automática)<br/>
- Reconocimiento automático de EDPs para que el usuario ya no tenga que ponerlas en "pdsolve(...)"<br/>
- Guardar/cargar el historial<br/>
- Visor de PDF<br/>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---