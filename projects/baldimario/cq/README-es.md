
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Motor de Consulta SQL de Alto Rendimiento para Archivos CSV

 [![Compilación y Pruebas Cruzadas (con el sistema de construcción zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Un procesador de consultas SQL ligero y rápido escrito en C que permite ejecutar consultas SQL directamente sobre archivos CSV sin requerir una base de datos. Para la documentación completa, consulte el directorio /doc.

 ![cq en acción](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentación

- Primeros pasos: `doc/GettingStarted.md`
- Instalación: `doc/Installation.md`
- Interfaz de línea de comandos: `doc/CLI.md`
- **TUI (Interfaz de usuario de terminal)**: `doc/TUI.md`
- Arquitectura: `doc/Architecture.md`
- Pruebas: `doc/Testing.md`
- Hoja de ruta: `doc/Roadmap.md`
- Contribución: `doc/Contributing.md`

## Inicio rápido

Compilar: `make`

### Línea de comandos

Ejecuta una consulta de ejemplo:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Interfaz de terminal

Inicia la TUI interactiva:
`./build/cqtui data/`

Características:
- Navega y abre archivos CSV como tablas
- Ejecuta consultas SQL de forma interactiva
- Interfaz de múltiples pestañas para varias tablas
- Navegación basada en teclado
- Sin dependencias externas

## Archivos SQL de ejemplo

El repositorio incluye ejemplos de SQL en assets/ (example_between.sql, example_aggregation.sql, etc.). Consulta assets/ para más detalles.

## Resumen de datos y características

- Consulta la carpeta /doc para secciones detalladas sobre tipos de datos, formatos de fecha, formato CSV y más.

## Licencia

Licencia MIT. Consulte el archivo LICENSE para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---