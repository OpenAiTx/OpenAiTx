# Whispera

Una aplicación nativa para macOS que reemplaza la dictación integrada con Whisper de OpenAI para una precisión superior en la transcripción. Transcribe voz, archivos locales, videos de YouTube y transmisiones de red, todo procesado localmente en tu Neural Engine.
<div align="center">
  
  ### [⬇️ Descargar Última Versión](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## Demostraciones

<table>
  <tr>
    <th>Campo de Voz a Texto</th>
    <th>Transcripción de Archivo/URL con Tiempos</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        Tu navegador no soporta la etiqueta de video.
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        Tu navegador no soporta la etiqueta de video.
      </video>
    </td>
  </tr>
</table>

## Características

- **Transcripción en vivo** (beta)
- **De voz a texto** - Reemplaza la dictación nativa de macOS con WhisperKit (modelo Whisper de OpenAI en Neural Engine) para mayor precisión
- **Transcripción de archivos** - Archivos de audio y video
- **Transcripción de medios en red** - Transmisión de URLs de video/música
- **Transcripción de YouTube**

Todo el procesamiento se realiza localmente. Internet solo es necesario para la descarga inicial del modelo.  
## Hoja de ruta

- [x] Soporte multilingüe más allá del inglés  
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/2  
  - **Lanzamiento**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3  
- [x] Capacidades de traducción en tiempo real  
  - **PR**: https://github.com/sapoepsilon/Whispera/pull/17  
  - **Lanzamiento**: https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18  
- [ ] Opciones adicionales de personalización  

## Uso

Simplemente use su atajo global configurado para comenzar a transcribir con Whisper en lugar de la dictado predeterminado de macOS.

## Problemas conocidos

- La aplicación no funciona con Mac Intel (ver [Issue 15](https://github.com/sapoepsilon/whispera/issues/15))  
- La instalación automática no funciona, después de descargar una aplicación, arrástrela y suéltela manualmente en su carpeta `/Application`  
## Requisitos

- macOS 13.0 o superior  
- Apple Silicon  
- Estamos trabajando en soporte para Mac Intel  

## Créditos

Construido con:  
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - Transcripción Whisper en dispositivo para Apple Silicon  
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - Extracción de contenido de YouTube  
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)  

Gracias a estos proyectos por hacer realidad una transcripción local centrada en la privacidad.

## Licencia

Licencia MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---