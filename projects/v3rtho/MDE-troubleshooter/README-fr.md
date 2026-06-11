# MDE-troubleshooter
# INFO

Cet outil est conçu pour vous aider à analyser les problèmes liés à Defender pour Endpoint sur votre point de terminaison local. Il offre une vue centralisée de la configuration de sécurité, des fichiers journaux, des mises à jour et donne accès à l’Analyseur de Performance.

Veuillez noter qu’il s’agit de la version initiale de l’outil. Si vous rencontrez des bugs ou avez des suggestions d’améliorations, je vous encourage à les soumettre sur ma page GitHub. Vos retours et rapports sont grandement appréciés.

<img width="1482" height="1041" alt="2026-03-09 10_40_30-MDE Troubleshooter v3 0" src="https://github.com/user-attachments/assets/34d80bab-525d-4bf2-ae10-ae8b0c62358d" />



# Prérequis

Le script doit être exécuté en administrateur pour afficher tous les paramètres.

# Avertissement

Script fourni tel quel. Utilisation à vos risques et périls. Aucune garantie ou assurance fournie.

# Contact
linkedin : https://www.linkedin.com/in/thomasvrhydn/
twitter :  @thomasvrhydn

# Fonctionnalités  

Defender AV  
Informations sur la version — Moteur AM, Produit AM, Service AM, versions du moteur NIS, Mode d’exécution AM, État de l’ordinateur  
Statut du service — Service AM, Antivirus, Antispyware, états activés de NIS, détection de machine virtuelle, ID de l’ordinateur  
Protection en temps réel — Protection en temps réel, Protection à l’accès, Moniteur de comportement, Protection IOAV, état et source de la protection contre la falsification  
Informations sur l’analyse — Âge des analyses complètes et rapides, heures de début/fin  
Paramètres de protection — Niveau de blocage cloud, Blocage au premier aperçu, Délai d’attente cloud, Jours de purge de quarantaine, Calcul de hachage de fichier, état du contrôle des périphériques  
Informations supplémentaires — Ordre de repli des signatures, dernière mise à jour de la signature NIS, source de la dernière analyse rapide   

Réduction de la surface d’attaque  
Statut des règles ASR — Affiche les 19 règles ASR avec leur état actuel (Activée / Audit / Avertissement / Non activée), avec filtrage par état dans une fenêtre popup DataGrid triable  
Exclusions par règle ASR — Affiche les exclusions ASR par règle et globales lues depuis le registre (HKLM:\...\Windows Defender Exploit Guard\ASR), avec filtrage par nom de règle  
Protection contre les exploits — Exporter et ouvrir la configuration XML de la protection contre les exploits  

Exclusions  
Exclusions Defender AV — Affiche toutes les exclusions configurées (Chemin, Extension, Processus, Adresse IP) avec recherche et filtrage par type dans une fenêtre popup DataGrid  
Informations sur la clé de registre — Affiche ManagedDefenderProductType, EnrollmentStatus, HideExclusionsFromLocalAdmins, DisableLocalAdminMerge, et détermine le statut de gestion avec validation de la protection contre les altérations (scénarios Intune uniquement, ConfigMgr, co-gestion)  

Mises à jour  
Informations sur la signature actuelle — Version/âge/dernière mise à jour de la signature AV, version/âge de la signature Antispyware, version de la signature NIS  
Dernières versions Microsoft — Récupère les dernières versions du moteur, de la plateforme et des signatures depuis le site Microsoft pour comparaison  
Actions de mise à jour — Déclenche une mise à jour des signatures via MpCmdRun.exe directement depuis l’interface utilisateur  

Journaux  
Journaux SENSE — Visualiser les journaux d’événements du capteur EDR (Microsoft-Windows-SENSE/Operational) avec filtrage par texte et niveau (Information/Avertissement/Erreur), plus un panneau de détails pour les entrées sélectionnées  
Journaux Defender AV — Visualiser les journaux d’événements antivirus (Microsoft-Windows-Windows Defender/Operational) avec les mêmes capacités de filtrage et de détails  

Performance  
Enregistrement de performance — Démarrer une session d’enregistrement de performance Defender AV (New-MpPerformanceRecording) qui capture l’activité de scan dans un fichier ETL  
Rapports de performance — Générer des rapports à partir des enregistrements ETL avec types de rapports sélectionnables : Vue d’ensemble, Top 10 fichiers, Top 10 extensions, Top 10 processus, Top 10 scans (plusieurs rapports ouverts simultanément dans des fenêtres séparées)  
Impact estimé (MPlog) — Analyser le dernier fichier MPlog pour les entrées EstimatedImpact, triées par valeur d’impact, afin d’identifier les cibles de scan à fort impact  
Téléchargement Client Analyzer — Télécharger l’outil officiel Microsoft Defender Client Analyzer (MDEClientAnalyzer.zip) dans un dossier de votre choix  

Proxy  
Configuration du proxy — Affiche l’URL du proxy actuel et le PAC proxy configurés pour Defender  

Pare-feu  
Statut du profil — Voir les paramètres des profils de pare-feu Domaine, Privé et Public (Activé, Action par défaut Entrante/Sortante, Journalisation autorisée)  
Navigateur de règles de pare-feu — Voir toutes les règles du pare-feu Windows dans une DataGrid filtrable avec recherche, direction, action, état activé, et filtres de profil. Affiche nom de règle, ports, protocole, et chemin du programme  


# Références

https://github.com/ugurkocde/Intune/blob/main/Defender%20for%20Endpoint/MDE%20-%20Update%20Tool/MDE_Update_Tool.ps1

https://github.com/directorcia/Office365/blob/master/win10-asr-get.ps1

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/overview-attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction

https://docs.microsoft.com/en-us/windows/security/threat-protection/microsoft-defender-atp/attack-surface-reduction-faq





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-11

---