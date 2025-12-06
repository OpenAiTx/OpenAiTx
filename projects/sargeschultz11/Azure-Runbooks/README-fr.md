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

Chaque dossier de runbook contient :
- Le script principal PowerShell (`.ps1`)
- Un script d’aide pour configurer les permissions (`Add-GraphPermissions.ps1`)
- Une documentation détaillée (`README.md`)

## Authentification

Tous les runbooks de ce dépôt sont conçus pour utiliser l’identité managée attribuée par le système d’Azure Automation pour l’authentification, ce qui est la méthode recommandée pour Azure Automation. Chaque dossier inclut un script `Add-GraphPermissions.ps1` qui aide à attribuer les permissions nécessaires à l’API Microsoft Graph à l’identité managée de votre compte Automation.

## Premiers pas

Chaque runbook comprend une documentation détaillée pour l’implémentation et l’utilisation. En général, pour utiliser ces runbooks :

1. Importez le script dans votre compte Azure Automation
2. Activez l’identité managée attribuée par le système sur votre compte Automation
3. Utilisez le script `Add-GraphPermissions.ps1` inclus pour attribuer les permissions nécessaires à l’API Graph
4. Configurez les paramètres requis spécifiques à votre environnement
5. Planifiez le runbook ou exécutez-le à la demande selon vos besoins

## Runbooks disponibles

### Rapports
- **Rapport de conformité des appareils** : Générer des rapports complets de conformité pour les appareils gérés par Intune.
- **Rapport des applications découvertes** : Créer des rapports détaillés des applications détectées sur les appareils gérés.
- **Rapport des appareils avec application spécifique** : Identifier tous les appareils avec une application spécifique installée.
- **Rapport des responsables utilisateurs** : Générer un rapport de tous les utilisateurs internes licenciés avec les informations de leur responsable.
- **Rapport des mises à jour de sécurité manquantes** : Identifier les appareils Windows manquant plusieurs mises à jour de sécurité avec rapport automatisé.
- **Rapport des appareils en retard de synchronisation** : Générer des rapports des appareils n’ayant pas synchronisé dans un délai défini.
- **Rapport des éléments partagés OneDrive** : Créer des rapports des éléments partagés en externe dans OneDrive for Business.

### Gestion des appareils
- **Synchronisation des catégories d’appareils** : Synchroniser automatiquement les catégories d’appareils Intune en fonction des informations de département des utilisateurs.
- **Synchronisation des tags de groupe Autopilot** : Maintenir la synchronisation des tags de groupe d’appareils Autopilot avec les catégories d’appareils Intune.
- **Forcer la synchronisation des appareils** : Initier les commandes de synchronisation pour tous les appareils Intune gérés avec protection contre le batching et la limitation.
- **Synchronisation Intune vers Action1 des catégories** : Synchroniser les catégories d’appareils Intune vers les attributs personnalisés Action1 en faisant correspondre les numéros de série.

### Alertes et notifications
- **Rappel de synchronisation des appareils** : Envoyer des rappels automatisés par email aux utilisateurs dont les appareils ne se sont pas synchronisés récemment.
- **Surveillance du jeton Apple** : Surveiller et alerter sur l’expiration des certificats et jetons Apple Push Notification.

### Gestion des utilisateurs
- **Paramètre d'attribut d'entreprise** : Définissez un attribut d'entreprise cohérent pour tous les comptes utilisateurs de votre locataire Microsoft 365.
- **Synchronisation des utilisateurs Snipe-IT** : Créez ou mettez à jour les utilisateurs Snipe-IT à partir de votre locataire Microsoft 365, en utilisant l’email comme identifiant, avec des mots de passe sécurisés pour les nouveaux utilisateurs et des options de connexion/invitation.

### Intégration tierce
- **Intégration Action1** : Synchronisez les catégories d’appareils Intune avec les attributs personnalisés Action1 RMM pour une gestion unifiée des appareils sur plusieurs plateformes.

## Gestion des branches

Ce dépôt suit un flux Git simplifié :

- La branche `main` contient des scripts stables et prêts pour la production
- Des branches de développement sont créées pour les nouvelles fonctionnalités ou modifications importantes
- Une fois les travaux de développement fusionnés dans `main`, les branches de développement sont généralement supprimées
- Pour les utilisateurs ayant cloné ce dépôt, notez que les branches de développement peuvent disparaître après la fin de leurs travaux

Si vous travaillez sur une branche de développement spécifique, envisagez de créer votre propre fork pour assurer que votre travail ne soit pas affecté lors de la suppression des branches.

## Nouveautés de la version v1.4.0

### Nouveau runbook : Sync-IntuneToAction1Categories
Cette version introduit une nouvelle intégration avec Action1 RMM, permettant la synchronisation automatisée des catégories d’appareils Intune vers les attributs personnalisés Action1. Les principales fonctionnalités incluent :

- Correspondance automatique des appareils entre Intune et Action1 via les numéros de série
- Synchronisation des catégories d’appareils Intune vers des attributs personnalisés Action1 configurables
- Prise en charge de plusieurs régions Action1 (Amérique du Nord, Europe, Australie)
- Gestion sécurisée des identifiants via des variables chiffrées d’Azure Automation
- Mode WhatIf pour tester sans effectuer de modifications
- Journalisation et statistiques complètes
- Basé sur le module PowerShell PSAction1

Cette intégration aide les organisations à maintenir une catégorisation cohérente des appareils à la fois sur Microsoft Intune et Action1 RMM, facilitant ainsi les rapports, l’application des politiques et les workflows de gestion des appareils.

## Discussions

J’ai activé GitHub Discussions pour ce dépôt afin de favoriser la collaboration et le support entre utilisateurs. C’est le meilleur endroit pour :

* Poser des questions sur la mise en œuvre de runbooks spécifiques
* Partager vos réussites et mises en œuvre 
* Suggérer de nouvelles idées de runbook ou des améliorations
* Discuter des meilleures pratiques pour Azure Automation
* Obtenir de l’aide pour le dépannage

Consultez l’onglet [Discussions](https://github.com/sargeschultz11/Azure-Runbooks/discussions) pour rejoindre la conversation. Nous vous encourageons à utiliser les Discussions pour les questions générales et l’interaction communautaire, tandis que les Issues doivent être utilisées pour signaler des bugs ou des problèmes spécifiques avec les scripts.

## Contribution

N’hésitez pas à utiliser ces scripts comme point de départ pour vos propres besoins d’automatisation. Les contributions, améliorations et suggestions sont les bienvenues !

## Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---