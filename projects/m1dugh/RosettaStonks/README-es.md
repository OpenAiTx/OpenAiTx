
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introducción](#introduccion)
- [Instalar](#instalar)
  - [Chrome](#navegadores-basados-en-chrome)
    - [Guía Visual](#navegadores-basados-en-chrome)
  - [Firefox](#navegadores-basados-en-firefox)
- [Cómo usar](#como-usar)
  - [Agregar tiempo](#agregar-tiempo)
    - [Fundamentos](#agregar-tiempo-en-fundamentos)
    - [Constructor de fluidez](#agregar-tiempo-en-constructor-de-fluidez)
  - [Validar lección](#validar-lección)
    - [Fundamentos](#validar-lección-en-fundamentos)
    - [Constructor de fluidez](#validar-lección-en-constructor-de-fluidez)

## Introducción

RosettaStonks es una extensión de navegador que permite agregar tiempo y validar
lecciones en la plataforma de aprendizaje de idiomas Rosetta Stone.

> RosettaStonks, y tu rosetta stone se vuelve stonks.

## Instalación

### Navegadores basados en Chrome

➡️ **¿Nuevo instalando extensiones de Chrome manualmente?** Consulta la [Guía Visual Paso a Paso](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — ¡incluye capturas de pantalla útiles! 🖼️

#### 1. Usando GitHub Release

Para usar la extensión en un navegador basado en Chrome, necesitas:

- descargar el archivo `rosettastonks-chrome.tar.gz` de la última versión en
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

- ve a `about:debugging#/runtime/this-firefox` en tu navegador
- haz clic en el botón de configuración y ve a `Depurar complementos`.
- haz clic en `Cargar complemento temporal`
- selecciona el archivo `/tmp/rosettastonks.xpi` en el selector de archivos.

_Advertencia: Este método solo instala la extensión temporalmente, lo que significa que si
cierras tu navegador, el complemento se desinstalará. Esto se debe a las políticas de firefox
que no permiten usar extensiones no verificadas._

## Cómo usar

### Añadir tiempo

#### Añadir tiempo en Foundations

Para añadir tiempo en el producto `foundations`, necesitas ir a tus ejercicios y
hacer clic en ignorar o resolver al menos una pregunta. Una vez hecho esto, debería
aparecer un campo de tiempo en la página de la extensión donde puedes añadir tu tiempo.

#### Añadir tiempo en Fluency builder

Para añadir tiempo en el producto `fluency builder`, necesitas ir a tus ejercicios y
responder al menos un ejercicio. Si el campo para añadir tiempo no aparece, significa
que no se capturó ninguna solicitud de tiempo, necesitas refrescar la pregunta y responderla
de nuevo. Para que el tiempo se agregue, debes terminar la lección que usaste para
añadir tiempo.

_Nota: Si no ves el campo para añadir tiempo, significa que las acciones que realizaste
en el sitio web de Rosetta Stone no generaron tiempo legítimo, por lo tanto,
debes responder otras preguntas._

### Validar lección

#### Validar lección en Foundations

Para validar una lección, necesitas iniciar una lección y pasar por todas las
preguntas usando el botón `ignorar` en la parte inferior derecha. Una vez que todas las
preguntas hayan sido vistas, hacer clic en el botón `validar lección` debería validar
la lección. Si no, regresa a tu página de inicio, haz clic en la misma lección, esta
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

Lo cual producirá `rosettastonks.xpi`, el archivo de la extensión que puede
cargarse en Firefox.

📸 ¿Prefieres lo visual? Revisa la [Guía de instalación de Chrome con imágenes](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---