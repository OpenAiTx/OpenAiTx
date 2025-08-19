# Rosetta Stonks

- [Introducción](#introducción)
- [Instalación](#instalación)
  - [Chrome](#navegadores-basados-en-chrome)
    - [Guía visual](#navegadores-basados-en-chrome)
  - [Firefox](#navegadores-basados-en-firefox)
- [Cómo usar](#cómo-usar)
  - [Añadiendo tiempo](#añadiendo-tiempo)
    - [Foundations](#añadiendo-tiempo-en-foundations)
    - [Fluency builder](#añadiendo-tiempo-en-fluency-builder)
  - [Validando lección](#validando-lección)
    - [Foundations](#validando-lección-en-foundations)
    - [Fluency builder](#validando-lección-en-fluency-builder)

## Introducción

RosettaStonks es una extensión de navegador que permite añadir tiempo y validar
lecciones en la plataforma de aprendizaje de idiomas Rosetta Stone.

> RosettaStonks, y tu Rosetta Stone sube en stonks.

## Instalación

### Navegadores basados en Chrome

➡️ **¿Nuevo en la instalación manual de extensiones de Chrome?** Consulta la [Guía Visual Paso a Paso](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — ¡incluye capturas de pantalla útiles! 🖼️

#### 1. Usando GitHub Release

Para usar la extensión en un navegador basado en Chrome, necesitas:

- descargar el archivo `rosettastonks-chrome.tar.gz` desde la última versión en
  tu equipo.
- crear una carpeta llamada `rosettastonks` en algún lugar de tu equipo para almacenar la
  extensión
- ejecutar el siguiente comando en la carpeta `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Uso del gestor de paquetes nix

En lugar de los comandos anteriores, si estás en un sistema nix **que soporta
flakes**, puedes ejecutar los siguientes comandos, que instalarán una carpeta
bajo la ruta `/tmp/rosettastonks` con todos los archivos.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

La carpeta ahora está instalada en `/tmp/rosettastonks/`

**Esta parte es para todos los usuarios independientemente de si están usando el método github
o el método nix.**

En tu navegador:

- ve a `chrome://extensions`
- activa el interruptor `Modo desarrollador`
- haz clic en `Cargar sin empaquetar`
- Selecciona tu carpeta `rosettastonks`

### Navegadores basados en Firefox

- descarga el archivo `rosettastonks.xpi` desde la última versión.
- alternativamente, si usas el gestor de paquetes nix con soporte para flake, puedes ejecutar
  el siguiente comando.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- ve a `about:addons` en tu navegador  
- haz clic en el botón de configuración y ve a `Depurar complementos`.  
- haz clic en `Cargar complemento temporal`  
- selecciona el archivo `/tmp/rosettastonks.xpi` en el selector de archivos.  

_Advertencia: Este método solo instala la extensión temporalmente, lo que significa que si  
cierras tu navegador, el complemento se desinstalará. Esto se debe a las políticas de Firefox  
que no permiten usar extensiones no verificadas._  

## Cómo usar  

### Añadir tiempo  

#### Añadir tiempo en Foundations  

Para añadir tiempo en el producto `foundations`, necesitas ir a tus ejercicios, y  
hacer clic en ignorar o resolver al menos una pregunta. Una vez hecho esto, debería aparecer un campo de tiempo  
en la página de la extensión en el que puedes añadir tu tiempo.  

#### Añadir tiempo en Fluency builder  

Para añadir tiempo en el producto `fluency builder`, necesitas ir a tus ejercicios, y  
responder al menos un ejercicio. Si el campo para añadir tiempo no aparece, significa  
que no se detectó ninguna solicitud de tiempo, necesitas refrescar la pregunta y responderla  
nuevamente. Para que se añada el tiempo, necesitas terminar la lección que usaste para  
añadir tiempo.  

_Nota: Si no ves el campo para añadir tiempo, significa que las acciones que realizaste  
en la página web de Rosetta Stone no condujeron a añadir tiempo legítimo, y por lo tanto,  
necesitas responder otras preguntas._  

### Validar lección  

#### Validar lección en Foundations  

Para validar una lección, se debe comenzar una lección, y pasar por todas las  
preguntas usando el botón `ignorar` en la parte inferior derecha. Una vez que todas las  
preguntas han sido vistas, hacer clic en el botón `validar lección` debería validar  
la lección. Si no, vuelve a tu página principal, haz clic en la misma lección, que

debería preguntarte `¿Quieres continuar o reiniciar?`, puedes elegir ambas opciones, y
validar la lección nuevamente hasta que funcione. Debería funcionar después de 3/4 intentos como máximo.

#### Validando la lección en Fluency builder

Actualmente, la función de validar lección no está disponible en rosetta stonks.

## Construyendo la aplicación

### Construyendo el trabajador

El trabajador puede ser empaquetado usando el siguiente comando

```
$ deno task build:worker
```

Lo que crea el archivo empaquetado `/dist/worker.esm.js` que es el archivo empaquetado para el worker.

### Construcción del frontend

El worker puede ser empaquetado usando el siguiente comando


```
$ deno task build:frontend
```

Lo que crea el archivo empaquetado `/dist/frontend.esm.js` que es el archivo empaquetado para el frontend.

## Empaquetando la extensión

### Chrome

Para empaquetar la extensión para Chrome, se puede ejecutar el siguiente comando:


```
$ make chrome
```

### Firefox

Para empaquetar la extensión para Firefox, se puede ejecutar el siguiente comando:

```
$ make firefox
```

Lo que producirá `rosettastonks.xpi`, el archivo para la extensión que se puede
cargar en Firefox.

📸 ¿Prefieres imágenes? Consulta la [Guía de Instalación para Chrome con Imágenes](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---