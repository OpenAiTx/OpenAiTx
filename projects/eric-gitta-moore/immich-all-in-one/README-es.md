# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~En el futuro planeo migrar a ente-io/ente, porque necesito s3 para almacenar fotos~~
> 
> Ente todavía tiene pocas funciones
> 
> Cambié a usar juicedata/juicefs para montar s3

## Introducción al Proyecto

Este proyecto es una solución para mejorar las capacidades de IA del sistema de gestión de fotos [Immich](https://github.com/immich-app/immich). Principalmente amplía las funciones nativas de Immich a través de los siguientes componentes:

- **inference-gateway**: Servicio gateway escrito en Go, responsable de enrutar inteligentemente las solicitudes de aprendizaje automático de Immich
- **mt-photos-ai**: Servicio de IA basado en Python y FastAPI, integrado con RapidOCR y el modelo cn-clip
- Extensión de funciones de Immich, incluyendo búsqueda por reconocimiento de texto OCR y reprocesamiento de datos de IA en medios individuales, clasificación combinada de vectores OCR completos y puntuación de vectores CLIP
- Se añade segmentación de palabras en chino zhparser en PostgreSQL

## Funcionalidades Principales

### 1. Reconocimiento y búsqueda de texto OCR

- Usa RapidOCR para reconocer texto en imágenes
- Soporta reconocimiento de texto en chino e inglés mezclados
- Implementa búsqueda basada en el contenido textual de las imágenes

### 2. Procesamiento de vectores de imagen CLIP

- Basado en el modelo cn-clip para coincidencia imagen-texto más precisa en chino
- Soporta búsqueda semántica, mejorando la precisión de búsqueda

### 3. Reprocesamiento de datos de IA en medios individuales

- Permite regenerar datos OCR para una imagen/video individual
- Permite regenerar datos de vectores CLIP para una imagen/video individual
- Proporciona la capacidad de actualizar manualmente en caso de resultados de reconocimiento inexactos

## Arquitectura del sistema

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Detalle de componentes

### inference-gateway

Servicio de gateway escrito en Go, principales responsabilidades:
- Recibe solicitudes de aprendizaje automático de Immich
- Redirige las solicitudes OCR y CLIP al servicio mt-photos-ai según el tipo de solicitud
- Redirige otras solicitudes de aprendizaje automático (como reconocimiento facial) al servicio nativo de aprendizaje automático de Immich
- Maneja la autenticación y la conversión de formatos de datos

### mt-photos-ai

Servicio de IA escrito en Python y FastAPI, ofrece:
- API de reconocimiento de texto OCR (basado en RapidOCR)
- API de procesamiento de vectores CLIP (basado en cn-clip)
- Soporte para aceleración por GPU

## Instrucciones de despliegue

### Requisitos del entorno

- Docker y Docker Compose
- NVIDIA GPU (opcional, pero recomendada para procesamiento acelerado)
- Espacio de almacenamiento suficiente

### Instrucciones de configuración

1. **Configuración de inference-gateway**

Principales variables de entorno:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Configuración de mt-photos-ai**

Principales variables de entorno:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Pasos de implementación

1. Clonar el repositorio:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Iniciar el servicio:

```bash
docker-compose up -d
```
## Instrucciones de uso

1. **Configurar Immich para usar un servicio ML personalizado**

En el archivo de configuración de Immich, apunte la dirección del servicio de aprendizaje automático a inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Uso de búsqueda OCR**

- Utiliza el prefijo `ocr:` en la barra de búsqueda de Immich para realizar una búsqueda OCR
- Por ejemplo: `ocr:factura` buscará fotos que contengan la palabra "factura" en la imagen

3. **Reprocesamiento de datos AI de un solo medio**

- En la página de detalles de la foto, haz clic en la opción de menú
- Selecciona "Regenerar datos OCR" o "Regenerar vectores CLIP"
- El sistema reprocesará los datos de IA de esa foto

## Guía de desarrollo

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

- [Immich](https://github.com/immich-app/immich) - Solución de respaldo de fotos y videos autoalojada y de código abierto
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Biblioteca OCR multiplataforma basada en PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modelo preentrenado de aprendizaje contrastivo multimodal en chino



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---