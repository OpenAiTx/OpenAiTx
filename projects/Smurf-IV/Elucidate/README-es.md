# Elucidate

- [Descripción del Proyecto](#project-description)
- [Requisitos del Sistema:](#os-requirements)
- [Preguntas Frecuentes](#faqs)
- [Hoja de Ruta](#roadmap)
- [Capturas de Pantalla](#screenshots)

## Descripción del Proyecto

Elucidate es una interfaz gráfica para Windows del programa de línea de comandos SnapRAID.

*Este proyecto continúa la amalgama del gran trabajo realizado por mí y otros colaboradores.

## Requisitos del Sistema

- Sistema Operativo Windows
- .Net Runtime 4.8.0
- SnapRaid Versión 11.5 o inferior
- 10MB de espacio libre en el disco de destino

## Preguntas Frecuentes

**P**: ¿Qué es SnapRAID?<br/>
**R**: SnapRAID es un motor de paridad de instantáneas definido por software para sistemas operativos Windows y Linux. En el nivel más básico, ofrece protección al contenido de un sistema de archivos bajo su control calculando los hashes de sus archivos componentes y almacenando los resultados en un archivo de paridad. En caso de una falla completa del disco duro, este archivo de paridad puede usarse para reconstruir los datos perdidos. Para más detalles, visite la [comparación oficial de motores de protección de archivos de SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**P**: ¿Por qué una interfaz gráfica, la línea de comandos funciona!<br/>
**R**: El objetivo mayor es crear una GUI completa con características adicionales de gestión diseñadas para ayudar al usuario a mantener un entorno SnapRAID funcional. A veces, ‘apuntar y hacer clic’ es más fácil para un novato para empezar. La documentación técnica y la profunda configurabilidad de SnapRAID pueden hacer que adoptarlo sea desalentador para quienes desean probarlo.

**P**: Todavía tengo dudas, ¿hay más?<br/>
**R**: Sí, eche un vistazo a la [documentación](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) para imágenes, etc.

**P**: Entonces, ¿cuáles son los "Objetivos Mayores"?<br/>
**R**: Vea la __Hoja de Ruta__ abajo para un desglose completo.

## Hoja de Ruta

- [x] Fase I
  - [x] Intentar mantenerse al día con el soporte mínimo de la última versión de SnapRAID. - __En curso.__
  - [x] Facilidad de uso
  - [x] SnapRAID tiene tres comandos, así que hagámoslos simples de acceder para un novato  
  - [x] Indicador(es) de progreso  
  - [x] Registro "Interactivo" y directo al log.  
  - [x] Inicio automático al iniciar sesión el usuario  
  - [x] Consejos emergentes para guiar •	

- [x] Fase II Solicitudes de características de la Fase II  
  - [x] Pausar, Cambiar prioridad, Abort.  
  - [x] Extensión de Comando - "Permitir parámetros adicionales a los usados por defecto."  
  - [x] Programación  
    - Eliminado, usar la línea de comandos  
  - [x] Vista(s) gráfica(s) de los datos protegidos.  

- [ ] Fase III (Reinicio para 2017-03 en adelante)  
  - [x] Nuevo compilador y .Net 4.7.x	
  - [x] Interfaz de línea de comandos  
  - [ ] Nuevo diseño vía Krypton Toolkit / Navigator / etc.  
    - En progreso  
  - [ ] Traducciones  
  - [x] Nuevos comandos  
  - [ ] Enviador de correos con reportes de estado  
  - [ ] Documentar pasos de prueba  
    - En progreso  
  - [ ] Añadir a la documentación / Actualizar imágenes  
    - En progreso  
  - [ ] Añadir reporte en _Windows EventLog_ de errores  
  - [x] Añadir _ExceptionLess_ para reporte en línea de excepciones  
  - [x] Mostrar qué podría ser recuperado.  

- [ ] Fase IV (¿nuevos comandos SnapRAID?)  
  - [ ] Ayuda extendida con recuperación de disco - guías interactivas, etc.  
  - [ ] Notificar al usuario si su versión de SnapRAID está desactualizada  
  - [ ] Interpretar los logs de SnapRAID (usados por los cambios abajo)  
  - [ ] Proveer el estado del array tras la ejecución de un comando  
  - [ ] Modificar el comando sync para incluir una diferencia inicial  
  - [ ] Modificar el comando sync para lanzar una advertencia si la diferencia reportó problemas por encima de un umbral  
  - [ ] Añadir configuraciones ajustables por el usuario para los requisitos de umbral de sincronización  


## Capturas de pantalla

![Vista Inicial](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Formulario de Configuración](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## ¿Puedes Ayudar? 
- Buscando evaluadores (todas las plataformas .Net) 
- Puede ayudar con la traducción 
- Guías de ayuda / interfaz de usuario 
- Cualquier otra idea :-) 
- Desarrolladores para las ideas 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---