# qq-farm-bot-vision
# Robot clásico de la granja QQ (versión con visión AI)
## La primera versión basada en coincidencia visual CV ya está desarrollada, la versión Alpha está publicada, nota: esta es una versión temprana de prueba, funcionalidades incompletas y en continuo desarrollo y optimización, principalmente para que algunos usuarios la prueben y ayuden a reportar errores y dar sugerencias.
## Para ver el registro de últimas actualizaciones, consulta: [update_cv.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./update_cv.txt)
## Para reportar problemas durante la prueba, abre un issue aquí: [issue zona de problemas](https://github.com/flh155/qq-farm-bot-vision/issues)
## Para intercambio técnico puedes unirte a Discord: [canal de agricultores](https://discord.gg/xbpVKG9wKw)

## A continuación el método para desplegar y probar la versión CV
### Nota: como esta es una versión de prueba, puede contener muchos problemas y faltas de funciones, por lo que temporalmente no se ofrece método de instalación con docker, exe, etc., solo se proporciona el arranque desde código fuente para usuarios con cierta base técnica dispuestos a probar, cuando la versión esté más optimizada y estable se ofrecerá una solución de instalación automática, gracias por entender

## ❗ Lectura obligatoria antes de usar:
- La ventana del juego debe mantenerse siempre en primer plano, aunque puede estar cubierta
- Esta versión ya tiene una interfaz GUI inicial, para usarla ejecuta `python main_gui.py`
- Esta versión ya implementa las funciones de `cosecha automática`, `eliminación automática de maleza/insectos/riego`, `plantación automática (en prueba)`, `robo automático de cultivos`, `ayuda automática en eliminación de maleza/insectos/riego`, `recolección automática de fertilizante gratuito diario`, estas funciones siguen en prueba y optimización
- La coincidencia de plantillas de imagen puede fallar o dar falsos positivos por diversos factores, es necesario ajustar parámetros de umbral según uso, método para ajustar parámetros aquí: [threshold_adjust.txt](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./threshold_adjust.txt)
- Se configuraron teclas para control rápido del bot, atajos: `Ctrl+c` para detener y salir inmediatamente, `p` para pausar/reanudar la inspección del bot

---
## Explicación de ramas
- ### ~~[rama silence-click](https://github.com/flh155/qq-farm-bot-vision/tree/silence-click): modo de clic silencioso, la ventana del juego sigue en primer plano pero no compite por el ratón con el usuario, atención: este modo puede conllevar riesgo de baneo, usen bajo su propio criterio y observen resultados~~ (esta rama ya fue fusionada a main)
- ### [rama gui-pr](https://github.com/flh155/qq-farm-bot-vision/tree/gui-pr): rama para contribuciones de interfaz GUI, el proyecto por defecto tiene una GUI sencilla, si tienes un buen diseño puedes enviar PR a esta rama (actualmente sin envíos)

---
## Vista de la interfaz GUI
![GUI](https://raw.githubusercontent.com/flh155/qq-farm-bot-vision/main/./assert/gui.jpg)

## Requisitos del sistema
- Windows 10 o superior (Linux y otros sistemas aún no soportados)
- Python instalado localmente (recomendado entorno conda), versión Python ≥ 3.9
- QQ versión escritorio arquitectura NT instalada y capaz de abrir la página de la granja
## Método para desplegar y probar
- 1. Clona el repositorio localmente, abre y conecta con la versión PC de QQ
- 2. En la raíz del proyecto abre terminal (opcional: activa entorno conda), ejecuta `pip install -r requirement.txt` para instalar dependencias
- 3. Revisa el archivo `config.ini` en la raíz, ajusta parámetros según tus necesidades
- 4. Ejecuta `python main.py` para iniciar el bot, verifica que inicie correctamente en terminal (para GUI usa `python main_gui.py`)
- 5. Abre la ventana del juego de la granja (atención que debe estar sin obstrucciones)
- 6. El programa controlará automáticamente el ratón para pulsar botones y automatizar funciones
---
# Planes de desarrollo futuros
- ~~Primera versión implementó modo de coincidencia de imagen basado en cv para cosecha, control de insectos y maleza (una versión rápida y simple para transición de uso)~~ (ya implementado)
- ~~Incorporar interfaz GUI para facilitar el uso~~(Implementado)  
- Optimizar y enriquecer la función de versiones de coincidencia CV, corregir problemas existentes (en curso)  
- Recolectar conjunto de datos de imágenes: limpieza, etiquetado, aumento  
- Entrenar modelo de detección de objetos basado en red neuronal yolo  
- Utilizar redes neuronales para identificar íconos de manera más precisa y rica, ampliando funciones (cultivar, cosechar, robar cultivos, labrar tierra, etc.)  
# Tu star⭐ es mi motivación para seguir actualizando  
---  
## Primero, muchas gracias a todos por su atención y star⭐ al proyecto, pero como normalmente trabajo en construcción, solo tengo tiempo para actualizar y mantener el proyecto durante descansos o después del trabajo, y este proyecto comenzó desde cero, por lo que el progreso es más lento y la calidad del código puede ser un poco inferior; espero que lo comprendan, también invito a expertos a hacer PR y convertirse en contribuyentes del proyecto; finalmente, actualizaré el progreso de desarrollo oportunamente, por favor tengan paciencia  

# Descargo de responsabilidad ❗  
## Este proyecto es solo para investigación, aprendizaje e intercambio sobre aplicaciones de IA y visión por computadora, se compromete a ser siempre abierto y gratuito, está estrictamente prohibido que cualquier persona realice desarrollo secundario, empaquetado para venta, promoción u otros usos ilegales; además, usar este proyecto puede violar términos de servicio de juegos y causar sanciones como baneos; al usar el código del proyecto se entiende que aceptas esta información y asumes todas las consecuencias, sin responsabilidad para el autor.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---