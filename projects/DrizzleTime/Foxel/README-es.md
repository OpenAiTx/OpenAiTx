<p align="center">
    <img src="https://raw.githubusercontent.com/DrizzleTime/Foxel/dev/Web/public/logo.png" alt="Logo de Foxel" width="150"><br>
    <strong>Foxel - Sistema Inteligente de Búsqueda y Gestión de Imágenes</strong>
</p>
<p align="center">
    <a href="#-核心功能"><img src="https://img.shields.io/badge/功能-Features-blue?style=for-the-badge" alt="Funciones principales"></a>
    <a href="#-部署指南"><img src="https://img.shields.io/badge/部署-Deploy-orange?style=for-the-badge" alt="Despliegue"></a>
    <a href="#-贡献指南"><img src="https://img.shields.io/badge/贡献-Contribute-brightgreen?style=for-the-badge" alt="Contribuciones"></a>
    
</p>

<p>
    <strong>Foxel</strong> es un sistema moderno de búsqueda y gestión inteligente de imágenes desarrollado sobre <strong>.NET 9</strong>, que integra avanzados <strong>modelos visuales AI</strong> y <strong>tecnología de incrustación vectorial</strong>, ofreciendo funciones eficientes para la búsqueda y gestión de imágenes.
</p>

---

> 🖥️ **Demostración en línea:**  
> Visita [https://demo.foxel.cc](https://foxel.cc) para experimentar algunas funciones de Foxel.  
> Cuenta de administrador: `demo@foxel.cc` Contraseña: `foxel_demo`  
> ⚠️ **Atención: Los datos del entorno de demostración pueden limpiarse periódicamente, no almacene información importante.**

---

## 🌐 Comunidad

Únete a nuestra comunidad para intercambiar experiencias con otros usuarios, obtener soporte técnico y participar en discusiones del proyecto:

|     Plataforma     | Información del grupo                                     | Contacto                                                                   |
|:-----------------:|:--------------------------------------------------------|:--------------------------------------------------------------------------|
| 📱 **WeChat Group** | **Nombre del grupo:** Foxel Pequeño Zorro <br>*Si el código QR no funciona, añade `drizzle2001` para unirte* | <img src="https://foxel.cc/Uploads/wechat.png" alt="Código QR WeChat" width="100"> |

> 💡 **Reglas de la comunidad:**  
> - Mantén un ambiente amable y colaborativo  
> - Proporciona información detallada al publicar preguntas  
> - Prohibido publicar anuncios irrelevantes al proyecto  
> - Respeta las normas de cada plataforma comunitaria

## ✨ Funciones principales

### 🔍 Búsqueda inteligente de imágenes
- [x] Búsqueda en lenguaje natural - Comprensión y búsqueda de contenido de imágenes basada en IA
- [x] Búsqueda de imágenes similares - Localización rápida de imágenes con contenido parecido
- [x] Filtro por condiciones - Filtrado preciso por fecha, tamaño, formato, etc.
- [x] Búsqueda avanzada - Combinación multidimensional de condiciones de búsqueda

### 🗂️ Gestión de imágenes
- [x] Subida de imágenes - Soporte para arrastrar y soltar, subida masiva
- [x] Álbum anónimo - Subida y compartición de imágenes sin necesidad de registro
- [x] Etiquetas y categorías - Gestión flexible de categorías y etiquetas de imágenes
- [x] Operaciones en lote - Eliminación, traslado y marcado masivo de imágenes
- [x] Generación de miniaturas - Creación automática de miniaturas en varios tamaños
- [x] Conversión a WebP - Conversión inteligente de formatos para optimizar espacio

### 🤖 Funciones inteligentes AI
- [x] Reconocimiento facial - Detección y reconocimiento automático de rostros en imágenes
- [x] Descripción de imágenes AI - Generación inteligente de descripciones del contenido de imágenes
- [x] Clasificación automática AI - Clasificación inteligente de imágenes basada en contenido
- [ ] Detección de objetos - Identificación de diversos objetos en imágenes
- [ ] Reconocimiento de escenas - Identificación automática del entorno en que se tomó la imagen

### 💾 Funciones de almacenamiento
- [x] Almacenamiento local - Guardado de archivos en el servidor local
- [x] Canal de Telegram - Almacenamiento en la nube basado en Telegram
- [x] Amazon S3 - Almacenamiento de objetos compatible con protocolo S3
- [x] Tencent Cloud COS - Servicio de almacenamiento de objetos de Tencent Cloud
- [x] Configuración múltiple de almacenamiento - Soporte para usar varios backends de almacenamiento simultáneamente
- [x] WebDAV - Almacenamiento mediante protocolo estándar WebDAV

### 👥 Funciones para usuarios
- [x] Registro e inicio de sesión - Sistema completo de cuentas de usuario
- [x] Inicio de sesión con GitHub - Soporte para inicio rápido con cuenta GitHub
- [x] Inicio de sesión con LinuxDo - Soporte para inicio con cuenta de comunidad LinuxDo
- [x] Gestión de permisos - Control de roles y permisos múltiples
- [ ] Agrupación de usuarios - Función de gestión de grupos de usuarios
- [x] Perfil personal - Gestión completa del perfil de usuario

### 💬 Funciones sociales
- [x] Me gusta en imágenes - Dar "me gusta" a imágenes favoritas
- [x] Colección de imágenes - Guardar imágenes de interés
- [ ] Sistema de comentarios - Comentarios e interacciones en imágenes
- [ ] Función de compartir - Compartir imágenes en múltiples plataformas
- [ ] Sistema de seguimiento - Seguir a otros usuarios

---

## 🚀 Guía de despliegue

> ⚠️ **Aviso importante:**  
> Foxel está actualmente en una fase temprana de desarrollo, adecuado para **pruebas y experiencias iniciales**. La versión actual puede incluir **cambios que rompen compatibilidad** durante las actualizaciones, no se provee un proceso de migración de datos, y la actualización requiere **reinstalación completa**. Para un uso **estable a largo plazo**, se recomienda esperar a la publicación de la versión **Preview**, que incluirá un proceso de actualización automática robusto.

Foxel ofrece varias formas de despliegue para cubrir diferentes necesidades:

- 🐳 **Despliegue con Docker Compose de un solo comando** - Recomendado para principiantes  
- 🐋 **Despliegue con contenedor Docker único** - Adecuado para personalización de base de datos  
- 🔧 **Despliegue compilando desde el código fuente** - Para desarrolladores

📖 **Consulta el tutorial detallado en: [https://foxel.cc/guide/getting-started.html](https://foxel.cc/guide/getting-started.html)**

---
## 🤝 Guía de Contribución

Damos la bienvenida a todos los desarrolladores interesados en Foxel a unirse y contribuir para mejorar y potenciar este proyecto.

|      Paso      | Descripción                                                                                     |
|:------------:|:----------------------------------------------------------------------------------------------|
| **Enviar Issue** | - Si encuentra un error o tiene sugerencias, por favor envíe un Issue.<br>- Describa detalladamente el problema y los pasos para reproducirlo, para facilitar una rápida localización y solución. |
|   **Contribuir Código**   | - Haga un fork de este proyecto y cree una nueva rama.<br>- Siga las normas de codificación del proyecto.                                  |
|   **Extensión de Funcionalidades**   | - Invitamos a participar en el desarrollo de las siguientes funcionalidades clave:<br>• Algoritmos de búsqueda de imágenes más inteligentes<br>• Mejora de la interacción social<br>• Integración con almacenamiento en la nube/servicios de disco en red<br>• Más métodos inteligentes de procesamiento de imágenes (como etiquetado automático, transferencia de estilo, mejora de imágenes, etc.) |

Si tiene cualquier duda o sugerencia, no dude en contactarnos mediante un Issue. ¡Gracias por su contribución!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---