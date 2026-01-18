# ESP32 Transpiler

[![License](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![Releases](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go Report Card](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![Maintainability](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## Propósito

El [Arduino IDE](https://www.arduino.cc/en/Main/Software) es fácil de usar.  
Pero me enfrenté a problemas como la mantenibilidad y la capacidad de prueba en proyectos IoT más complicados.  
Necesitaba compilar y cargar el ESP32 antes de probar la funcionalidad de mi código, haciéndolo 100% manualmente.

Esta solución transpila Golang a código Arduino, que puede ser compilado a una imagen usando la cadena de herramientas ESP32.  
Ahora puedo usar un enfoque de pruebas totalmente automatizado en lugar de hacerlo 100% manualmente.

**Importante**:

El Transpiler solo soporta un pequeño subconjunto de la [Especificación del Lenguaje Golang](https://golang.org/ref/spec).  
Mira el [mapeo](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go) y las [pruebas](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go) para conocer la funcionalidad actual.  
Tampoco es posible activar la recolección de basura de C/C++, porque Golang la maneja automáticamente "tras bambalinas".  
Las cadenas de Go serán transpileadas a arrays constantes de caracteres C, que podrían manejarse en la pila.

### Requisitos previos

1. Instala la última versión de [Go](https://golang.org/dl/).  
2. Instala la última versión de [Just](https://github.com/casey/just).  
3. Incluye `$HOME/bin` en tu `$PATH`.

## Instalación

Clona el repositorio e instala el binario `esp32-transpiler` en `$HOME/bin`:

    just install

## Uso

Transpila un archivo fuente Golang a un sketch de Arduino:

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-18

---