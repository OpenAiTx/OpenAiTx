# Azure-Runbooks 

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PowerShell](https://img.shields.io/badge/PowerShell-7.2+-blue.svg)](https://github.com/PowerShell/PowerShell)
[![Microsoft 365](https://img.shields.io/badge/Microsoft_365-compatible-brightgreen.svg)](https://www.microsoft.com/microsoft-365)
[![Graph API](https://img.shields.io/badge/Microsoft_Graph-v1.0-blue.svg)](https://developer.microsoft.com/en-us/graph)
[![Azure](https://img.shields.io/badge/Azure_Automation-compatible-0089D6.svg)](https://azure.microsoft.com/en-us/products/automation)
[![GitHub release](https://img.shields.io/github/release/sargeschultz11/Azure-Runbooks.svg)](https://GitHub.com/sargeschultz11/Azure-Runbooks/releases/)
[![Maintenance](https://img.shields.io/badge/Maintained-yes-green.svg)](https://github.com/sargeschultz11/Azure-Runbooks)
[![Made with](https://img.shields.io/badge/Made%20with-PowerShell-1f425f.svg)](https://www.microsoft.com/powershell)

A collection of Azure Automation runbooks for Microsoft 365 and Intune management.

## Overview

This repository contains PowerShell scripts designed to be used as Azure Automation runbooks for automating various Microsoft 365 and Intune management tasks. These scripts help streamline administrative processes, maintain consistency across your environment, and reduce manual overhead.

## Repository Structure

The repository is organized into folders, with each folder containing a specific runbook solution:

```
Azure-Runbooks/
├── DeviceCategorySync/             # Sync device categories with user departments
├── Report-DiscoveredApps/          # Generate reports of discovered applications
├── Report-IntuneDeviceCompliance/  # Generate device compliance reports
├── Report-DevicesWithApp/          # Find devices with specific applications
├── Alert-DeviceSyncReminder/       # Send reminders for devices needing sync
├── Update-AutopilotDeviceGroupTags/ # Sync Autopilot group tags with Intune categories
├── Alert-IntuneAppleTokenMonitor/  # Monitor Apple token expirations
├── Report-UserManagers/            # Generate reports of users and their managers
├── Report-MissingSecurityUpdates/  # Report on devices missing security updates
├── Sync-IntuneDevices/             # Force sync all managed Intune devices
├── Report-DeviceSyncOverdue/       # Report on devices overdue for sync
├── Report-OneDriveSharedItems/     # Generate reports of shared items in OneDrive
├── Task-SetCompanyAttribute/       # Set company attribute for all users
├── Snipe-IT-UserSync/              # Sync Microsoft 365 users to Snipe-IT users
├── Sync-IntuneToAction1Categories/ # Sync Intune device categories to Action1 custom attributes
```

Cada carpeta de runbook contiene:
- El script principal de PowerShell (`.ps1`)
- Un script auxiliar para configurar permisos (`Add-GraphPermissions.ps1`)
- Documentación detallada (`README.md`)

## Autenticación

Todos los runbooks en este repositorio están diseñados para usar la Identidad Administrada Asignada por el Sistema de Azure Automation para la autenticación, que es el enfoque recomendado para Azure Automation. Cada carpeta incluye un script `Add-GraphPermissions.ps1` que ayuda a asignar los permisos necesarios de la API de Microsoft Graph a la Identidad Administrada de su Cuenta de Automatización.

## Primeros Pasos

Cada runbook incluye documentación detallada para su implementación y uso. En general, para usar estos runbooks:

1. Importe el script en su cuenta de Azure Automation
2. Habilite la Identidad Administrada Asignada por el Sistema en su cuenta de Automatización
3. Use el script incluido `Add-GraphPermissions.ps1` para asignar los permisos necesarios de la API de Graph
4. Configure cualquier parámetro requerido específico para su entorno
5. Programe el runbook o ejecútelo bajo demanda según sea necesario

## Runbooks Disponibles

### Informes
- **Informe de Cumplimiento de Dispositivos**: Genere informes completos de cumplimiento para dispositivos gestionados por Intune.
- **Informe de Aplicaciones Descubiertas**: Cree informes detallados de aplicaciones descubiertas en dispositivos gestionados.
- **Informe de Dispositivos con Aplicación Específica**: Identifique todos los dispositivos con una aplicación específica instalada.
- **Informe de Gerentes de Usuarios**: Genere un informe de todos los usuarios internos con licencia junto con la información de su gerente.
- **Informe de Actualizaciones de Seguridad Faltantes**: Identifique dispositivos Windows que carecen de múltiples actualizaciones de seguridad con informes automatizados.
- **Informe de Sincronización de Dispositivos Atrasada**: Genere informes de dispositivos que no se han sincronizado dentro de un umbral especificado.
- **Informe de Elementos Compartidos en OneDrive**: Cree informes de elementos compartidos externamente en OneDrive para Empresas.

### Gestión de Dispositivos
- **Sincronización de Categorías de Dispositivos**: Sincronice automáticamente las categorías de dispositivos de Intune basándose en la información del departamento del usuario.
- **Sincronización de Etiquetas de Grupo Autopilot**: Mantenga las etiquetas de grupo de dispositivos Autopilot sincronizadas con las categorías de dispositivos de Intune.
- **Forzar Sincronización de Dispositivos**: Inicie comandos de sincronización para todos los dispositivos gestionados por Intune con protección contra lotes y limitación.
- **Sincronización de Categorías de Intune a Action1**: Sincronice las categorías de dispositivos de Intune con atributos personalizados de Action1 mediante la coincidencia de números de serie.

### Alertas y Notificaciones
- **Recordatorio de Sincronización de Dispositivos**: Envíe recordatorios automáticos por correo electrónico a usuarios cuyos dispositivos no se han sincronizado recientemente.
- **Monitor de Token de Apple**: Monitoree y alerte sobre expiraciones de certificados y tokens de notificaciones push de Apple.
### Gestión de Usuarios
- **Configuración del Atributo de Empresa**: Establezca un atributo de empresa consistente en todas las cuentas de usuario de su inquilino de Microsoft 365.
- **Sincronización de Usuarios Snipe-IT**: Cree o actualice usuarios de Snipe-IT desde su inquilino de Microsoft 365, usando el correo electrónico como ancla, con contraseñas seguras para nuevos usuarios y opciones de activación/invitación.

### Integración de Terceros
- **Integración con Action1**: Sincronice las categorías de dispositivos de Intune con los atributos personalizados de Action1 RMM para una gestión unificada de dispositivos en todas las plataformas.

## Gestión de Ramas

Este repositorio sigue un flujo de trabajo Git simplificado:

- La rama `main` contiene scripts estables y listos para producción
- Se crean ramas de desarrollo para nuevas características o modificaciones significativas
- Una vez que el trabajo de desarrollo se fusiona en `main`, normalmente se eliminan las ramas de desarrollo
- Para los usuarios que han clonado este repositorio, tenga en cuenta que las ramas de desarrollo pueden desaparecer después de completar su trabajo

Si está trabajando con una rama de desarrollo específica, considere crear su propio fork para asegurarse de que su trabajo no se vea afectado cuando se eliminen ramas.

## Novedades en la versión v1.4.0

### Nuevo Runbook: Sync-IntuneToAction1Categories
Esta versión introduce una nueva integración con Action1 RMM, que permite la sincronización automatizada de categorías de dispositivos de Intune a atributos personalizados de Action1. Las características clave incluyen:

- Coincidencia automática de dispositivos entre Intune y Action1 usando números de serie
- Sincroniza las categorías de dispositivos de Intune a atributos personalizados configurables de Action1
- Soporta múltiples regiones de Action1 (Norteamérica, Europa, Australia)
- Gestión segura de credenciales mediante variables cifradas de Azure Automation
- Modo WhatIf para pruebas sin realizar cambios
- Registro y estadísticas completas
- Construido sobre el módulo PSAction1 de PowerShell

Esta integración ayuda a las organizaciones a mantener una categorización consistente de dispositivos en las plataformas Microsoft Intune y Action1 RMM, facilitando mejores informes, aplicación de políticas y flujos de trabajo de gestión de dispositivos.

## Discusiones

He habilitado GitHub Discussions para este repositorio con el fin de fomentar la colaboración y el soporte entre usuarios. Este es el mejor lugar para:

* Hacer preguntas sobre la implementación de runbooks específicos
* Compartir sus historias de éxito e implementaciones

* Sugerir nuevas ideas o mejoras para runbooks  
* Discutir mejores prácticas para Azure Automation  
* Obtener ayuda con la solución de problemas  

Consulta la pestaña de [Discusiones](https://github.com/sargeschultz11/Azure-Runbooks/discussions) para unirte a la conversación. Te animamos a usar Discusiones para preguntas generales e interacción comunitaria, mientras que Issues debe usarse para reportar errores o problemas específicos con los scripts.  

## Contribuciones  

Siéntete libre de usar estos scripts como punto de partida para tus propias necesidades de automatización. ¡Las contribuciones, mejoras y sugerencias son bienvenidas!  

## Licencia  

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---