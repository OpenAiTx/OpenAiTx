<p align="center">
  <img src="https://raw.githubusercontent.com/kayasax/EasyPIM/main/docs/assets/logo_transparent.svg" alt="Logotipo de EasyPIM" width="180">
  <h1 align="center">🛡️ EasyPIM</h1>
  <p align="center">
    <strong>Automatización PowerShell para Azure Privileged Identity Management.</strong>
  </p>
  <p align="center">
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/v/easypim?label=Core&logo=powershell&color=blue" alt="Versión Core"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/v/EasyPIM.Orchestrator?label=Orchestrator&logo=powershell&color=blue" alt="Versión Orchestrator"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/dt/easypim?label=Core%20Downloads&color=green" alt="Descargas Core"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/dt/EasyPIM.Orchestrator?label=Orchestrator%20Downloads&color=green" alt="Descargas Orchestrator"></a>
    <a href="https://github.com/kayasax/EasyPIM/stargazers"><img src="https://img.shields.io/github/stars/kayasax/EasyPIM?style=social" alt="Estrellas en GitHub"></a>
    <a href="https://github.com/kayasax/EasyPIM/blob/main/LICENSE"><img src="https://img.shields.io/github/license/kayasax/EasyPIM" alt="Licencia"></a>
  </p>
</p>

---

Endurezca políticas de roles en masa. Clone configuraciones entre roles. Exporte asignaciones. Detecte desviaciones en la configuración. Apruebe o deniegue solicitudes. Despliegue modelos completos de PIM desde JSON.

**Un módulo PowerShell que cubre Recursos de Azure, Roles de Entra ID y Grupos de Seguridad** — con cmdlets que hacen lo que el portal no puede. APIs ARM y Graph unificadas, más de 50 comandos, 4 nubes de Azure.

> 🌐 **Empiece aquí →** El **[Centro de Adopción EasyPIM](https://kayasax.github.io/EasyPIM/)** le guía desde la primera instalación hasta una gobernanza PIM de nivel empresarial en tres etapas.

## 🚀 Inicio Rápido

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Force

# Harden 3 Entra roles in one shot — try that in the portal
Set-PIMEntraRolePolicy -TenantID $tenantId `
    -RoleName "Global Administrator","Security Administrator","Exchange Administrator" `
    -ActivationRequirement "Justification","Ticketing","MultiFactorAuthentication" `
    -ActivationDuration "PT4H"

# Audit every eligible assignment across a subscription
Get-PIMAzureResourceEligibleAssignment -TenantID $tenantId -SubscriptionId $subId

# Deploy a full PIM model from JSON — Entra + Azure + Groups in one run
Invoke-EasyPIMOrchestrator -TenantId $tenantId -ConfigurationPath "./pim-config.json"
```

---

## ✨ Cosas Que El Portal No Puede Hacer

| | |
|---|---|
| ⚡ **Endurecer roles en masa** | Establecer MFA + justificación + ticketing en 30 roles con un solo comando |
| 🔄 **Clonar configuraciones de roles** | Copiar una política endurecida a otros roles/usuarios — sin hacer clic manualmente |
| 📊 **Exportar e importar** | Asignaciones a CSV, configuraciones completas a JSON — listo para auditorías en segundos |
| 🔍 **Detectar desviación de políticas** | Comparar estado en vivo vs configuración declarada, obtener un informe de diferencias |
| 🏢 **Gobernanza CI/CD** | GitHub Actions y Azure DevOps ([Demo impulsada por eventos](https://github.com/kayasax/EasyPIM-EventDriven-Governance)) |
| ☁️ **Multi-nube** | Público, Gobierno, China, Alemania — mismos cmdlets en todas partes |
| 🔗 **ARM + Graph unificados** | Un módulo abstrae ambas APIs — sin cambiar de contexto |

---

## 📦 Instalación

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Scope CurrentUser
```
| Requisito | Detalles |
|---|---|
| PowerShell | 5.1+ o 7.0+ |
| Módulos | `Az.Accounts`, `Microsoft.Graph.Authentication` (instalados automáticamente) |
| Recursos de Azure | `Owner` o `User Access Administrator` en la suscripción |
| Entra ID / Grupos | Permisos de Graph: `RoleManagement.ReadWrite.Directory`, `RoleManagementPolicy.ReadWrite.Directory`, y [otros](https://github.com/kayasax/EasyPIM/wiki/Documentation) |

---

## 📖 Aprende Más

| | |
|---|---|
| **[🌐 Adoption Hub](https://kayasax.github.io/EasyPIM/)** | **Viaje en tres etapas: inicio rápido, mejores prácticas, patrones empresariales** |
| [📋 Documentación Completa](https://github.com/kayasax/EasyPIM/wiki/Documentation) | Guías detalladas y referencia API |
| [🎯 Casos de Uso y Ejemplos](https://github.com/kayasax/EasyPIM/wiki/Use-Cases) | Escenarios de implementación reales |
| [🏗 Guía del Orquestador](https://github.com/kayasax/EasyPIM/wiki/Invoke%E2%80%90EasyPIMOrchestrator-step%E2%80%90by%E2%80%90step-guide) | Flujos de trabajo JSON paso a paso |
| [🔄 Migración v1→v2](https://github.com/kayasax/EasyPIM/wiki/Module-Migration) | Actualización desde v1.x |
| [📝 Registro de Cambios](https://github.com/kayasax/EasyPIM/wiki/Changelog) | Historial de versiones |

---

## 🔧 Dos Módulos, Una Plataforma

| Módulo | Propósito | Comandos Clave |
|---|---|---|
| **EasyPIM** (Núcleo) | Gestión directa de API PIM — políticas, asignaciones, aprobaciones | `Get-PIM*`, `Set-PIM*`, `New-PIM*` |
| **EasyPIM.Orchestrator** | Flujos JSON, detección de desviaciones, reglas de negocio, CI/CD | `Invoke-EasyPIMOrchestrator`, `Test-PIMPolicyDrift` |

<details>
<summary>Haz clic para expandir la lista completa de cmdlets (50+)</summary>

### Roles de Recursos de Azure

| Cmdlet | Descripción |
|---|---|
| `Get-PIMAzureResourcePolicy` | Obtener configuraciones de políticas de rol |
| `Set-PIMAzureResourcePolicy` | Configurar requisitos de activación, duración, aprobadores |
| `Get-PIMAzureResourceEligibleAssignment` | Listar asignaciones elegibles |

| `New-PIMAzureResourceEligibleAssignment` | Crear asignación elegible |
| `Remove-PIMAzureResourceEligibleAssignment` | Eliminar asignación elegible |
| `Get-PIMAzureResourceActiveAssignment` | Listar asignaciones activas |
| `New-PIMAzureResourceActiveAssignment` | Crear asignación activa |
| `Remove-PIMAzureResourceActiveAssignment` | Eliminar asignación activa |

### Roles de Entra ID

| Cmdlet | Descripción |
|---|---|
| `Get-PIMEntraRolePolicy` | Obtener configuración de políticas de roles Entra |
| `Set-PIMEntraRolePolicy` | Configurar requisitos de activación, MFA, aprobadores |
| `Get-PIMEntraRoleEligibleAssignment` | Listar asignaciones elegibles |
| `New-PIMEntraRoleEligibleAssignment` | Crear asignación elegible |
| `Remove-PIMEntraRoleEligibleAssignment` | Eliminar asignación elegible |
| `Get-PIMEntraRoleActiveAssignment` | Listar asignaciones activas |
| `New-PIMEntraRoleActiveAssignment` | Crear asignación activa |
| `Remove-PIMEntraRoleActiveAssignment` | Eliminar asignación activa |

### Grupos

| Cmdlet | Descripción |
|---|---|
| `Get-PIMGroupPolicy` | Obtener configuración de políticas PIM de grupo |
| `Set-PIMGroupPolicy` | Configurar requisitos de activación de grupo |
| `Get-PIMGroupEligibleAssignment` | Listar asignaciones elegibles de grupo |
| `New-PIMGroupEligibleAssignment` | Crear asignación elegible de grupo |
| `Remove-PIMGroupEligibleAssignment` | Eliminar asignación elegible de grupo |
| `Get-PIMGroupActiveAssignment` | Listar asignaciones activas de grupo |
| `New-PIMGroupActiveAssignment` | Crear asignación activa de grupo |
| `Remove-PIMGroupActiveAssignment` | Eliminar asignación activa de grupo |

### Operaciones y Utilidades

| Cmdlet | Descripción |
|---|---|
| `Approve-PIMPendingRequest` | Aprobar solicitudes de activación pendientes |
| `Deny-PIMPendingRequest` | Denegar solicitudes de activación pendientes |
| `Get-PIMReport` | Análisis de actividad PIM y registros de auditoría |
| `Backup-PIMConfiguration` | Respaldo completo del estado PIM |
| `Restore-PIMConfiguration` | Restaurar desde copia de seguridad |
| `Copy-PIMRoleSettings` | Clonar configuraciones entre roles |
| `Export-PIMAssignment` | Exportar asignaciones a CSV |
| `Import-PIMAssignment` | Importar asignaciones desde CSV |

### Orquestador

| Cmdlet | Descripción |
|---|---|
| `Invoke-EasyPIMOrchestrator` | Desplegar configuración completa de PIM desde JSON |
| `Test-PIMPolicyDrift` | Detectar desviación de políticas respecto al estado declarado |
| `Test-PIMEndpointDiscovery` | Validación de conectividad y permisos |

</details>

---

## 🌐 Cobertura

**3 ámbitos de PIM**: Recursos de Azure (suscripción, grupo de administración, grupo de recursos) · Roles de Entra ID · Grupos de seguridad

**4 nubes**: Pública · Gobierno · China · Alemania

---

## 🤝 Proyectos relacionados

| | |
|---|---|
| **[EasyTCM](https://github.com/kayasax/EasyTCM)** | Monitoreo de configuración de tenant — detectar desviación de configuración en Entra, Exchange, Intune, Teams y Compliance |
| **[Event-Driven Governance](https://github.com/kayasax/EasyPIM-EventDriven-Governance)** | Demostración de CI/CD en producción: GitHub Actions + Azure DevOps + Event Grid |

---

## 🤝 Contribuir

Consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/kayasax/EasyPIM/main/CONTRIBUTING.md) para las directrices.

### Colaboradores

- **[Loïc MICHEL](https://github.com/kayasax)** — Autor y mantenedor  
- **[AzureStackNerd](https://github.com/AzureStackNerd)** — Soporte de condición ABAC para asignaciones de recursos de Azure, optimización del alcance de Graph  
- **[Chase Dafnis](https://github.com/CHDAFNI-MSFT)** — Soporte para entornos multi-nube / Azure  
- **[jeenvan](https://github.com/jeevanions)** — Orquestador: formato de matriz y correcciones del alcance del grupo de administración  

---

<p align="center">  
  Construido con ❤️ para la Comunidad de Administradores de Azure<br>  
  <strong>También del autor: <a href="https://github.com/kayasax/EasyTCM">EasyTCM</a> — Detección de desviaciones en la configuración del tenant M365</strong>  
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---