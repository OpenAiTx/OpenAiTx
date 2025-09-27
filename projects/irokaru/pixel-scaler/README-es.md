<div align="center">  
  <a href="https://irokaru.github.io/pixel-scaler/">
    <img src="https://raw.githubusercontent.com/irokaru/pixel-scaler/master/./public/logo.png" width="33%" alt="Logo de Pixel Scaler"/>
  </a>
  <p><b>Una herramienta para escalar pixel art</b></p>

  <!-- Badges -->
  <p>
    <a href="https://github.com/irokaru/pixel-scaler/releases/latest"><img src="https://img.shields.io/github/v/release/irokaru/pixel-scaler.svg?style=for-the-badge" alt="Última versión"/></a>
    <img src="https://img.shields.io/github/downloads/irokaru/pixel-scaler/total?style=for-the-badge" alt="Descargas"/>
    <a href="https://app.codecov.io/gh/irokaru/pixel-scaler/tree/master"><img src="https://img.shields.io/codecov/c/github/irokaru/pixel-scaler?style=for-the-badge" alt="Cobertura"/></a>
    <a href="https://x.com/IroKaru"><img src="https://img.shields.io/twitter/follow/irokaru?style=for-the-badge" alt="Seguir en X"/></a>
  </p>
</div>

## Entorno de desarrollo

* node (>= 22.x)
* rust (>=1.85.0)
  * (requerido para el desarrollo con Tauri)

## Configuración para desarrollo (WSL)

Instalar dependencias:

```sh
npm ci
```

(Opcional) Si desea usar Tauri:

```sh
cargo install tauri-cli
sudo apt install -y libsoup2.4-dev javascriptcoregtk-4.1 libsoup-3.0 webkit2gtk-4.1 \
                    libjavascriptcoregtk-4.0-dev libwebkit2gtk-4.0-dev librsvg2-dev
```
## Comandos Disponibles

| Comando                 | Descripción                                              |
|-------------------------|----------------------------------------------------------|
| `npm run dev`           | Iniciar servidor de desarrollo con Vite                  |
| `npm run dev:tauri`     | Iniciar servidor de desarrollo Tauri                      |
| `npm run build`         | Construir el proyecto para producción                     |
| `npm run build:tauri`   | Construir el proyecto con tauri                           |
| `npm run preview`       | Previsualizar el proyecto construido (requiere `npm run build` primero) |
| `npm run test`          | Ejecutar pruebas                                          |
| `npm run test:watch`    | Ejecutar pruebas en modo observación                      |
| `npm run test:coverage` | Ejecutar pruebas con cobertura                            |
| `npm run test:e2e`      | Ejecutar pruebas con playwright                           |
| `npm run clean`         | Eliminar archivos generados                               |
| `npm run lint-staged`   | Ejecutar linting en archivos preparados                   |
| `npm run prepare`       | Configurar Husky para hooks de Git                        |

## Biblioteca de Escalado

* xBRjs (Copyright 2020 Josep del Rio)
  * https://github.com/joseprio/xBRjs



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---