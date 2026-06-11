# MDE-troubleshooter
# INFO

Esta herramienta está diseñada para ayudarte a analizar problemas relacionados con Defender for Endpoint en tu endpoint local. Ofrece una vista centralizada de la configuración de seguridad, archivos de registro, actualizaciones y proporciona acceso al Analizador de Rendimiento.

Ten en cuenta que esta es la versión inicial de la herramienta. Si encuentras algún error o tienes sugerencias para mejoras, te animo a que las envíes en mi página de GitHub. Tus comentarios e informes son muy apreciados.

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# Prerrequisitos

El script debe ejecutarse como administrador para ver todas las configuraciones.

# Descargo de responsabilidad

Script proporcionado tal cual. Úsalo bajo tu propio riesgo. No se ofrecen garantías ni responsabilidades.

# Contacto
linkedin: https://www.linkedin.com/in/thomasvrhydn/
twitter:  @thomasvrhydn

# Funcionalidades  

Defender AV  
Información de versión — Motor AM, Producto AM, Servicio AM, versiones de Motor NIS, Modo de ejecución AM, Estado del equipo  
Estado del servicio — Servicio AM, Antivirus, Antispyware, estados habilitados de NIS, detección de máquina virtual, ID del equipo  
Protección en tiempo real — Protección en Tiempo Real, Protección al Acceso, Monitor de Comportamiento, Protección IOAV, estado y fuente de Protección contra manipulación  
Información de escaneo — Antigüedad del escaneo completo y rápido, horas de inicio/fin  
Configuración de protección — Nivel de bloqueo en la nube, Bloquear al primer visto, Tiempo de espera en la nube, días para purga de cuarentena, Cómputo de hash de archivo, estado del Control de dispositivo  
Información adicional — Orden de respaldo de firmas, última actualización de firma NIS, última fuente de escaneo rápido  

Reducción de superficie de ataque  
Estado de reglas ASR — Ver las 19 reglas ASR con su estado actual (Habilitado / Auditoría / Advertencia / No habilitado), con filtrado por estado en una ventana emergente DataGrid ordenable  
Exclusiones por regla ASR — Ver exclusiones ASR por regla y globales leídas del registro (HKLM:\...\Windows Defender Exploit Guard\ASR), con filtrado por nombre de regla  
Protección contra exploits — Exportar y abrir la configuración XML de Protección contra Exploits  

Exclusiones  
Exclusiones de Defender AV — Ver todas las exclusiones configuradas (Ruta, Extensión, Proceso, Dirección IP) con búsqueda y filtrado por tipo en una ventana emergente DataGrid  
Información de la clave del registro — Muestra ManagedDefenderProductType, EnrollmentStatus, HideExclusionsFromLocalAdmins, DisableLocalAdminMerge, y determina el estado de gestión con validación de protección contra manipulaciones (solo Intune, ConfigMgr, escenarios co-gestionados)  

Actualizaciones  
Información actual de la firma — Versión/edad/última actualización de la firma AV, versión/edad de la firma antispyware, versión de la firma NIS  
Últimas versiones de Microsoft — Obtiene las últimas versiones del motor, plataforma y firmas desde el sitio web de Microsoft para comparación  
Acciones de actualización — Ejecuta una actualización de firmas mediante MpCmdRun.exe directamente desde la interfaz de usuario  

Registros  
Registros SENSE — Ver registros de eventos del sensor EDR (Microsoft-Windows-SENSE/Operational) con filtrado por texto y nivel (Información/Advertencia/Error), además de un panel de detalles para entradas seleccionadas  
Registros de Defender AV — Ver registros de eventos del antivirus (Microsoft-Windows-Windows Defender/Operational) con las mismas capacidades de filtrado y detalle  

Rendimiento  
Grabación de rendimiento — Iniciar una sesión de grabación de rendimiento de Defender AV (New-MpPerformanceRecording) que captura la actividad de escaneo en un archivo ETL  
Informes de rendimiento — Generar informes a partir de grabaciones ETL con tipos de informes seleccionables: Visión general, Top 10 archivos, Top 10 extensiones, Top 10 procesos, Top 10 escaneos (múltiples informes abiertos simultáneamente en ventanas separadas)  
Impacto estimado (MPlog) — Analizar el archivo MPlog más reciente para entradas EstimatedImpact, ordenadas por valor de impacto, para identificar objetivos de escaneo de alto impacto  
Descarga del analizador de cliente — Descargar la herramienta oficial Microsoft Defender Client Analyzer (MDEClientAnalyzer.zip) a una carpeta de su elección  

Proxy  
Configuración del proxy — Muestra la URL de proxy actual y el PAC proxy configurados para Defender  

Cortafuegos  
Estado del perfil — Ver configuraciones de perfil de cortafuegos de Dominio, Privado y Público (Habilitado, Acción predeterminada de entrada/salida, Registro permitido)  
Explorador de reglas del cortafuegos — Ver todas las reglas del cortafuegos de Windows en un DataGrid filtrable con búsqueda, dirección, acción, estado habilitado y filtros de perfil. Muestra nombre de regla, puertos, protocolo y ruta del programa  


# Referencias

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---