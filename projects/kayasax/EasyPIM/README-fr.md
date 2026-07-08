<p align="center">
  <img src="https://raw.githubusercontent.com/kayasax/EasyPIM/main/docs/assets/logo_transparent.svg" alt="Logo EasyPIM" width="180">
  <h1 align="center">🛡️ EasyPIM</h1>
  <p align="center">
    <strong>Automatisation PowerShell pour Azure Privileged Identity Management.</strong>
  </p>
  <p align="center">
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/v/easypim?label=Core&logo=powershell&color=blue" alt="Version Core"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/v/EasyPIM.Orchestrator?label=Orchestrator&logo=powershell&color=blue" alt="Version Orchestrator"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/dt/easypim?label=Core%20Downloads&color=green" alt="Téléchargements Core"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/dt/EasyPIM.Orchestrator?label=Orchestrator%20Downloads&color=green" alt="Téléchargements Orchestrator"></a>
    <a href="https://github.com/kayasax/EasyPIM/stargazers"><img src="https://img.shields.io/github/stars/kayasax/EasyPIM?style=social" alt="Étoiles GitHub"></a>
    <a href="https://github.com/kayasax/EasyPIM/blob/main/LICENSE"><img src="https://img.shields.io/github/license/kayasax/EasyPIM" alt="Licence"></a>
  </p>
</p>

---

Renforcez massivement les politiques de rôle. Clonez les paramètres entre rôles. Exportez les affectations. Détectez les dérives de configuration. Approuvez ou refusez les demandes. Déployez des modèles PIM complets depuis JSON.

**Un module PowerShell unique couvrant les ressources Azure, les rôles Entra ID, et les groupes de sécurité** — avec des cmdlets qui font ce que le portail ne peut pas. API ARM et Graph unifiées, plus de 50 commandes, 4 clouds Azure.

> 🌐 **Commencez ici →** Le **[Hub d’adoption EasyPIM](https://kayasax.github.io/EasyPIM/)** vous guide de la première installation à une gouvernance PIM de niveau entreprise en trois étapes.

## 🚀 Démarrage rapide

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

## ✨ Choses que le portail ne peut pas faire

| | |
|---|---|
| ⚡ **Renforcer les rôles en masse** | Configurer MFA + justification + ticketing sur 30 rôles en une seule commande |
| 🔄 **Cloner les paramètres de rôle** | Copier une politique renforcée vers d'autres rôles/utilisateurs — sans recliquer manuellement |
| 📊 **Exporter & importer** | Assignations en CSV, configurations complètes en JSON — audit prêt en quelques secondes |
| 🔍 **Détecter la dérive de politique** | Comparer l'état en direct avec la config déclarée, obtenir un rapport de différence |
| 🏢 **Gouvernance CI/CD** | GitHub Actions & Azure DevOps ([Démo pilotée par événements](https://github.com/kayasax/EasyPIM-EventDriven-Governance)) |
| ☁️ **Multi-cloud** | Public, Gouvernement, Chine, Allemagne — mêmes cmdlets partout |
| 🔗 **ARM + Graph unifiés** | Un seul module abstrait les deux API — pas de changement de contexte |

---

## 📦 Installation

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Scope CurrentUser
```
| Exigence | Détails |
|---|---|
| PowerShell | 5.1+ ou 7.0+ |
| Modules | `Az.Accounts`, `Microsoft.Graph.Authentication` (installés automatiquement) |
| Ressources Azure | `Propriétaire` ou `Administrateur de l'accès utilisateur` sur l'abonnement |
| Entra ID / Groupes | Permissions Graph : `RoleManagement.ReadWrite.Directory`, `RoleManagementPolicy.ReadWrite.Directory`, et [autres](https://github.com/kayasax/EasyPIM/wiki/Documentation) |

---

## 📖 En savoir plus

| | |
|---|---|
| **[🌐 Hub d'adoption](https://kayasax.github.io/EasyPIM/)** | **Parcours en trois étapes : démarrages rapides, bonnes pratiques, modèles d'entreprise** |
| [📋 Documentation complète](https://github.com/kayasax/EasyPIM/wiki/Documentation) | Guides approfondis et référence API |
| [🎯 Cas d'utilisation & Exemples](https://github.com/kayasax/EasyPIM/wiki/Use-Cases) | Scénarios d'implémentation réels |
| [🏗 Guide de l'orchestrateur](https://github.com/kayasax/EasyPIM/wiki/Invoke%E2%80%90EasyPIMOrchestrator-step%E2%80%90by%E2%80%90step-guide) | Workflows pilotés par JSON étape par étape |
| [🔄 Migration v1→v2](https://github.com/kayasax/EasyPIM/wiki/Module-Migration) | Mise à niveau depuis la version v1.x |
| [📝 Journal des modifications](https://github.com/kayasax/EasyPIM/wiki/Changelog) | Historique des versions |

---

## 🔧 Deux modules, une plateforme

| Module | Objectif | Commandes clés |
|---|---|---|
| **EasyPIM** (Noyau) | Gestion directe de l’API PIM — politiques, affectations, approbations | `Get-PIM*`, `Set-PIM*`, `New-PIM*` |
| **EasyPIM.Orchestrator** | Workflows JSON, détection de dérive, règles métier, CI/CD | `Invoke-EasyPIMOrchestrator`, `Test-PIMPolicyDrift` |

<details>
<summary>Cliquez pour déplier la liste complète des cmdlets (50+)</summary>

### Rôles des ressources Azure

| Cmdlet | Description |
|---|---|
| `Get-PIMAzureResourcePolicy` | Obtenir les paramètres de la politique de rôle |
| `Set-PIMAzureResourcePolicy` | Configurer les exigences d’activation, la durée, les approbateurs |
| `Get-PIMAzureResourceEligibleAssignment` | Lister les affectations éligibles |

| `New-PIMAzureResourceEligibleAssignment` | Créer une attribution éligible |
| `Remove-PIMAzureResourceEligibleAssignment` | Supprimer une attribution éligible |
| `Get-PIMAzureResourceActiveAssignment` | Lister les attributions actives |
| `New-PIMAzureResourceActiveAssignment` | Créer une attribution active |
| `Remove-PIMAzureResourceActiveAssignment` | Supprimer une attribution active |

### Rôles Entra ID

| Cmdlet | Description |
|---|---|
| `Get-PIMEntraRolePolicy` | Obtenir les paramètres de la politique de rôle Entra |
| `Set-PIMEntraRolePolicy` | Configurer les exigences d’activation, MFA, approbateurs |
| `Get-PIMEntraRoleEligibleAssignment` | Lister les attributions éligibles |
| `New-PIMEntraRoleEligibleAssignment` | Créer une attribution éligible |
| `Remove-PIMEntraRoleEligibleAssignment` | Supprimer une attribution éligible |
| `Get-PIMEntraRoleActiveAssignment` | Lister les attributions actives |
| `New-PIMEntraRoleActiveAssignment` | Créer une attribution active |
| `Remove-PIMEntraRoleActiveAssignment` | Supprimer une attribution active |

### Groupes

| Cmdlet | Description |
|---|---|
| `Get-PIMGroupPolicy` | Obtenir les paramètres de la politique PIM du groupe |
| `Set-PIMGroupPolicy` | Configurer les exigences d’activation de groupe |
| `Get-PIMGroupEligibleAssignment` | Lister les attributions de groupe éligibles |
| `New-PIMGroupEligibleAssignment` | Créer une attribution de groupe éligible |
| `Remove-PIMGroupEligibleAssignment` | Supprimer une attribution de groupe éligible |
| `Get-PIMGroupActiveAssignment` | Lister les attributions de groupe actives |
| `New-PIMGroupActiveAssignment` | Créer une attribution de groupe active |
| `Remove-PIMGroupActiveAssignment` | Supprimer une attribution de groupe active |

### Opérations & Utilitaires

| Cmdlet | Description |
|---|---|
| `Approve-PIMPendingRequest` | Approuver les demandes d’activation en attente |
| `Deny-PIMPendingRequest` | Refuser les demandes d’activation en attente |
| `Get-PIMReport` | Analyses d’activité PIM et pistes d’audit |
| `Backup-PIMConfiguration` | Sauvegarde complète de l’état PIM |
| `Restore-PIMConfiguration` | Restaurer à partir d'une sauvegarde |
| `Copy-PIMRoleSettings` | Cloner les paramètres entre rôles |
| `Export-PIMAssignment` | Exporter les affectations vers CSV |
| `Import-PIMAssignment` | Importer les affectations depuis CSV |

### Orchestrateur

| Cmdlet | Description |
|---|---|
| `Invoke-EasyPIMOrchestrator` | Déployer la configuration complète PIM depuis JSON |
| `Test-PIMPolicyDrift` | Détecter la dérive de politique par rapport à l'état déclaré |
| `Test-PIMEndpointDiscovery` | Validation de connectivité et des permissions |

</details>

---

## 🌐 Couverture

**3 périmètres PIM** : Ressources Azure (abonnement, groupe de gestion, groupe de ressources) · Rôles Entra ID · Groupes de sécurité

**4 clouds** : Public · Gouvernement · Chine · Allemagne

---

## 🤝 Projets associés

| | |
|---|---|
| **[EasyTCM](https://github.com/kayasax/EasyTCM)** | Surveillance de la configuration du locataire — détecter la dérive de configuration sur Entra, Exchange, Intune, Teams & Conformité |
| **[Event-Driven Governance](https://github.com/kayasax/EasyPIM-EventDriven-Governance)** | Démo CI/CD en production : GitHub Actions + Azure DevOps + Event Grid |

---

## 🤝 Contribution

Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/kayasax/EasyPIM/main/CONTRIBUTING.md) pour les directives.

### Contributeurs

- **[Loïc MICHEL](https://github.com/kayasax)** — Auteur et mainteneur
- **[AzureStackNerd](https://github.com/AzureStackNerd)** — Support des conditions ABAC pour les affectations de ressources Azure, optimisation de la portée Graph
- **[Chase Dafnis](https://github.com/CHDAFNI-MSFT)** — Support multi-cloud / environnement Azure
- **[jeenvan](https://github.com/jeevanions)** — Orchestrateur : format tableau & corrections de la portée du groupe de gestion

---

<p align="center">
  Construit avec ❤️ pour la communauté des administrateurs Azure<br>
  <strong>Aussi par l'auteur : <a href="https://github.com/kayasax/EasyTCM">EasyTCM</a> — Détection de dérive de configuration du locataire M365</strong>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---