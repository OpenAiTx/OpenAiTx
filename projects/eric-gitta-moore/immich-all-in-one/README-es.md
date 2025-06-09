# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Plan futuro: migrar a ente-io/ente, porque necesito s3 para almacenar fotos~~
>
> ente sigue teniendo pocas funciones
>
> Cambiado a utilizar juicedata/juicefs para montar s3

## Introducción al Proyecto

Este proyecto es una solución de mejora de capacidades de IA para el sistema de gestión de fotos [Immich](https://github.com/immich-app/immich). Principalmente expande las funciones nativas de Immich mediante los siguientes componentes:

- **inference-gateway**: Servicio gateway escrito en Go, responsable de enrutar inteligentemente las solicitudes de machine learning de Immich
- **mt-photos-ai**: Servicio de IA basado en Python y FastAPI, integrado con los modelos RapidOCR y cn-clip
- Expansión de funciones para Immich, incluyendo búsqueda OCR y reprocesamiento de datos AI de medios individuales, ordenamiento mixto por puntuación de vectores OCR completos y CLIP
- PostgreSQL añade tokenización china con zhparser

## Funcionalidades Principales

### 1. Reconocimiento y Búsqueda de Texto OCR

- Utiliza RapidOCR para reconocer texto en imágenes
- Soporta reconocimiento de texto mixto chino-inglés
- Permite búsqueda basada en contenido textual en imágenes

### 2. Procesamiento de Vectores de Imagen CLIP

- Implementa emparejamiento imagen-texto en chino más preciso basado en el modelo cn-clip
- Soporta búsqueda semántica para mejorar la precisión de búsqueda

### 3. Reprocesamiento de Datos AI para Medios Individuales

- Permite regenerar datos OCR para imágenes/videos individuales
- Permite regenerar datos de vectores CLIP para imágenes/videos individuales
- Proporciona capacidad de actualización manual en caso de resultados inexactos

## Arquitectura del Sistema

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ Solicitudes OCR/CLIP
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Servicio Python) │
                     │                  │
                     └──────────────────┘
```

## Detalles de los Componentes

### inference-gateway

Servicio gateway escrito en Go, responsabilidades principales:
- Recibe solicitudes de machine learning de Immich
- Redirige solicitudes OCR y CLIP al servicio mt-photos-ai según tipo de solicitud
- Redirige otras solicitudes de machine learning (como reconocimiento facial) al servicio nativo de ML de Immich
- Maneja autenticación y conversión de formato de datos

### mt-photos-ai

Servicio de IA escrito en Python y FastAPI, proporciona:
- API de reconocimiento de texto OCR (basado en RapidOCR)
- API de procesamiento de vectores CLIP (basado en cn-clip)
- Soporte para aceleración GPU

## Instrucciones de Despliegue

### Requisitos del Entorno

- Docker y Docker Compose
- GPU NVIDIA (opcional, pero recomendado para aceleración)
- Espacio de almacenamiento suficiente

### Descripción de la Configuración

1. **Configuración de inference-gateway**

Variables de entorno principales:
```
IMMICH_API=http://localhost:3003  # Dirección API de Immich
MT_PHOTOS_API=http://localhost:8060  # Dirección del servicio mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # Clave API
PORT=8080  # Puerto de escucha del gateway
```

2. **Configuración de mt-photos-ai**

Variables de entorno principales:
```
CLIP_MODEL=ViT-B-16  # Nombre del modelo CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Ruta de descarga de modelos
DEVICE=cuda  # o cpu, dispositivo de inferencia
HTTP_PORT=8060  # Puerto de escucha del servicio
```

### Pasos de Despliegue

1. Clonar el repositorio:
```bash
git clone https://github.com/tu_usuario/immich-all-in-one.git
cd immich-all-in-one
```

2. Iniciar los servicios:
```bash
docker-compose up -d
```

## Instrucciones de Uso

1. **Configurar Immich para usar el servicio ML personalizado**

En el archivo de configuración de Immich, apunta la dirección del servicio ML a inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Uso de búsqueda OCR**

- En la barra de búsqueda de Immich, utiliza el prefijo `ocr:` para búsquedas OCR
- Por ejemplo: `ocr:factura` buscará fotos que contengan el texto "factura" en la imagen

3. **Reprocesamiento de datos AI de medios individuales**

- En la página de detalles de la foto, haz clic en las opciones de menú
- Selecciona "Regenerar datos OCR" o "Regenerar vectores CLIP"
- El sistema reprocesará los datos AI de la foto

## Guía de Desarrollo

### inference-gateway (Go)

Compilar y ejecutar:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Configuración del entorno de desarrollo:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licencia

Este proyecto está abierto bajo la licencia MIT.

## Agradecimientos

- [Immich](https://github.com/immich-app/immich) - Solución de respaldo de fotos y videos autohospedada y de código abierto
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Librería OCR multiplataforma basada en PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modelo preentrenado multimodal de aprendizaje contrastivo para chino

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---