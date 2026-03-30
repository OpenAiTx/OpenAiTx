
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Descripción del Proyecto](#project-description)
- [Requisitos del Sistema:](#os-requirements)
- [Preguntas Frecuentes](#faqs)
- [hoja de ruta](#roadmap)
- [Capturas de Pantalla](#screenshots)

## Descripción del Proyecto

Elucidate es una interfaz gráfica para Windows que funciona como front-end del aplicativo SnapRAID de línea de comandos.

*Este proyecto continúa la combinación del excelente trabajo realizado por mí y otros colaboradores.

## Requisitos del Sistema

- Sistema Operativo Windows
- .Net Runtime 4.8.0
- SnapRaid Versión 11.5 o inferior
- 10MB de espacio libre en la unidad de destino

## Preguntas Frecuentes

**P**: ¿Qué es SnapRAID?<br/>
**R**: SnapRAID es un motor de paridad por instantáneas definido por software para sistemas operativos Windows y Linux. En el nivel más básico, ofrece protección al contenido de un sistema de archivos bajo su gestión, calculando los hashes de sus archivos componentes y almacenando los resultados en un archivo de paridad. En caso de una falla completa del disco duro, este archivo de paridad puede usarse para reconstruir los datos perdidos. Para más detalles, visite la [comparación oficial de motores de protección de archivos de SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**P**: ¿Por qué una GUI, si la Línea de Comandos funciona?<br/>
**R**: El objetivo principal es crear una interfaz gráfica con funciones adicionales de gestión diseñadas para ayudar al usuario a mantener un entorno SnapRAID funcional. A veces, los ‘clics y puntos’ son más fáciles para un principiante. La documentación técnica y la amplia configurabilidad de SnapRAID pueden dificultar su adopción para quienes desean probarlo.

**P**: Todavía estoy inseguro, ¿hay algo más?<br/>
**R**: Sí, eche un vistazo a la [documentación](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) para imágenes, etc.

**P**: ¿Cuáles son los "Objetivos Mayores"?<br/>
**R**: Vea el __Roadmap__ debajo para una descripción completa.

## Hoja de Ruta

- [x] Fase I
  - [x] Intentar mantener el soporte mínimo de la última versión de SnapRAID. - __En curso.__
  - [x] Facilidad de uso
  - [x] SnapRAID tiene tres comandos, así que hagámoslos fáciles de acceder para un principiante 
  - [x] Indicador(es) de progreso 
  - [x] Registro "Interactivo" y directo al log. 
  - [x] Inicio automático al iniciar sesión el usuario 
  - [x] Mensajes de ayuda para guiar •

- [x] Fase II Solicitudes de funciones de la Fase II
  - [x] Pausa, cambio de prioridad, abortar.
  - [x] Extensión de Comandos - "Permitir parámetros adicionales a los valores predeterminados usados."
  - [x] Programación 
    - Eliminado, utilice la línea de comandos
  - [x] Vista(s) gráfica(s) de los datos protegidos.

- [ ] Fase III (Reinicio desde 2017-03 en adelante)
  - [x] Nuevo compilador y .Net 4.7.x	
  - [x] Interfaz de línea de comandos
  - [ ] Nuevo diseño a través de Krypton Toolkit / Navigator / etc.
    - En progreso
  - [ ] Traducciones 
  - [x] Nuevos comandos
  - [ ] Envío de correos con informes de estado
  - [ ] Documentar los pasos de prueba
    - En progreso
  - [ ] Agregar a la documentación / Actualizar imágenes
    - En progreso
  - [ ] Agregar informes de errores al _Windows EventLog_
  - [x] Agregar _ExceptionLess_ para reportes en línea de excepciones
  - [x] Mostrar lo que se podría recuperar.

- [ ] Fase IV (¿Nuevos comandos SnapRAID?) 
  - [ ] Ayuda extendida con recuperación de discos - guías interactivas, etc.
  - [ ] Notificar al usuario si su versión de SnapRAID está desactualizada
  - [ ] Interpretar los registros de SnapRAID (utilizado por los cambios a continuación)
  - [ ] Proporcionar el estado del arreglo después de ejecutar un comando
  - [ ] Modificar el comando de sincronización para incluir un diff inicial
  - [ ] Modificar el comando de sincronización para lanzar una advertencia si el diff reporta problemas por encima de un umbral
  - [ ] Agregar configuraciones personalizables por el usuario para requisitos de umbral de sincronización


## Capturas de Pantalla

![Vista Inicial](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulario de Configuración](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## ¿Puedes ayudar?
- Buscando testers (todas las plataformas .Net)
- Puede ayudar a traducir
- Ayuda / Guías de interfaz de usuario
- Cualquier otra idea :-)
- Desarrolladores para las ideas


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---