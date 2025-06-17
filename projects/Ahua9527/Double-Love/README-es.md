# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Amor entre fotogramas, eficiencia duplicada

[//]: # (Huevo de pascua oculto en el código)
<!Double Love：Deja que cada toma esconda la tasa de fotogramas que nunca dije -->

[English](./README.en.md) · 简体中文 · [Experiencia en línea](https://double-love.ahua.space)

</div>

Double Love proporciona un procesamiento automatizado y estandarizado de metadatos de claqueta. Soporta uso sin conexión. Mediante procesamiento por lotes y procesamiento local, permite la integración perfecta con Adobe Premiere, Silverstack y DTG Slate para garantizar la consistencia de los metadatos. Mejora eficazmente la eficiencia del flujo de trabajo de postproducción.

## ✨ Características

- 🎬 Soporte para el flujo de trabajo industrial cinematográfico
- 📝 Procesamiento inteligente y estandarizado de metadatos
- ⚡ Procesamiento local sin latencia
- 🧩 Integración perfecta con Adobe Premiere

## 🚀 Inicio rápido

### Flujo de trabajo básico

1. Registro de claqueta: usa DTG Slate para generar hojas de claqueta interactivas
2. Gestión de datos: importa datos de claqueta mediante Silverstack Lab
3. Exportación de archivos: genera XML para Adobe Premiere Pro
4. Procesamiento estandarizado: usa Double Love para optimización inteligente

Ejemplo:
- xml de entrada: `UnitA_304_20250127.xml`
- xml de salida: `UnitA_304_20250127_Double_LOVE.xml`

### Ejemplo detallado

#### Optimización de nombres de archivo
- El programa procesa automáticamente el formato de número de escena, número de plano y número de toma
- Añade ceros a la izquierda automáticamente a los números
- Normaliza automáticamente mayúsculas y minúsculas
- Limpia automáticamente guiones bajos innecesarios

#### Reglas de nomenclatura de clips

El nombre del clip procesado sigue este formato:
```
{prefijo_proyecto}{escena}_{plano}_{toma}{cámara}{calificación}
```

- `prefijo`: prefijo personalizado (opcional)
- `escena`: número de escena (3 dígitos, ej. 001)
- `plano`: número de plano (2 dígitos, ej. 01)
- `toma`: número de toma (2 dígitos, ej. 01)
- `cámara`: identificador de cámara (letra minúscula, ej. a)
- `calificación`: valoración (ok/kp/ng)

#### Procesamiento de valoración
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Información DIT
- Añade automáticamente la información DIT: 'DIT: 哆啦Ahua 🌱'
- Si deseas quitarlo, despliega por tu cuenta 😁😁

#### Ejemplo de prefijo personalizado

1. Establecer el prefijo como "PROJECT_A_":
   - Archivo de entrada: `A304C007_250123G3`
   - Archivo de salida: `PROJECT_A_004_01_07a_kp`

2. Sin prefijo:
   - Archivo de entrada: `A304C007_250123G3`
   - Archivo de salida: `004_01_07a_kp`

#### Ejemplo de configuración de resolución de secuencia

1. Resolución FHD (por defecto):
   - Ancho: 1920
   - Alto: 1080   
2. Resolución DCI 2K (personalizada):
   - Ancho: 2048
   - Alto: 1080   

#### Ejemplo de procesamiento por lotes

1. Subir varios archivos al mismo tiempo:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Tras el procesamiento se obtendrá:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Stack tecnológico

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Soporte PWA

## 📦 Instalación y uso

1. Clonar el proyecto

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Instalar dependencias

```bash
npm install
```

3. Desarrollo local

```bash
npm run dev
```

4. Construir el proyecto

```bash
npm run build
```

## 🔒 Nota de seguridad

- Todo el procesamiento de archivos se realiza localmente en el navegador, no se suben archivos al servidor
- Soporta archivos de hasta 50MB
- Solo soporta archivos en formato XML

## 🌈 Nota para desarrolladores

### Estructura del proyecto

```
Double-Love/
├── src/
│   ├── components/     # Componentes React
│   ├── context/       # Contexto React
│   ├── utils/         # Funciones utilitarias
│   ├── styles/        # Archivos de estilos
│   └── App.tsx        # Componente principal
├── public/            # Recursos estáticos
└── ...archivos de configuración
```

## 📃 Licencia

[Licencia MIT](LICENSE)

## 🤝 Guía de contribución

¡Bienvenidos Issues y Pull Requests!

## 👨‍💻 Autor

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---