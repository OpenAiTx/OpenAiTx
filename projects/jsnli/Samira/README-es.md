# Samira

Un gestor de logros de Steam para Linux

![example](https://raw.githubusercontent.com/jsnli/Samira/master/./assets/screenshot.png)

## Descripción
Samira es una aplicación de escritorio que te permite desbloquear logros y establecer estadísticas.  

## Instalación y Uso
Las versiones se pueden encontrar [aquí](https://github.com/jsnli/Samira/releases).

Steam debe estar en ejecución y el usuario debe haber iniciado sesión.

Flatpak no está soportado. Steam debe estar instalado a través del gestor de paquetes de tu distribución o mediante el instalador de la [página oficial de Steam](https://store.steampowered.com/about/).

## Compilación

Para compilar este proyecto necesitarás los [prerrequisitos](https://tauri.app/start/prerequisites/) para Tauri así como Rust, Node y npm.

Clona el repositorio e instala: 
```
cd Samira && npm install
```
Tauri no establece automáticamente las rutas de búsqueda de bibliotecas. Este es un problema conocido en Tauri y hasta que haya una solución oficial disponible, debemos configurarlo nosotros mismos: 

```
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/lib/libsteam_api.so
```

The `libsteam_api.so` file is available in `/assets/`.

**Dev**
```
npm run tauri dev
```
**Construir**

```
npm run tauri build
```

En las distribuciones basadas en Arch, puede ocurrir un error de empaquetado debido a que Tauri y linuxdeploy utilizan el binario `strip` incorrecto. Está disponible una solución alternativa:
```
NO_STRIP=true npm run tauri build
```

## Contribuyendo
Al igual que sus predecesores, Samira es de código abierto y está abierta a contribuciones. No dude en hacer preguntas, abrir solicitudes de extracción y reportar problemas.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---