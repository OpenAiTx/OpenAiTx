# sunsetr

<p align="center">
    <img src="https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/logo.png" alt="logo sunsetr" width="144" />
</p>
<p align="center">
    Filtre automatique de lumière bleue pour Hyprland, Niri, et tout ce qui utilise Wayland
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/"><img src="https://img.shields.io/badge/Documentation-mdBook-blue" alt="Documentation"></a>
  <a href="https://github.com/psi4j/sunsetr/blob/main/LICENSE"><img src="https://img.shields.io/github/license/psi4j/sunsetr" alt="Licence"></a>
  <a href="https://github.com/psi4j/sunsetr/releases"><img src="https://img.shields.io/github/v/release/psi4j/sunsetr" alt="Version"></a>
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/installation.html">Installation</a> | <a href="https://psi4j.github.io/sunsetr/quick-start.html">Démarrage Rapide</a> | <a href="https://psi4j.github.io/sunsetr/configuration/">Configuration</a> | <a href="https://psi4j.github.io/sunsetr/commands/">Commandes</a>
</p>

![Cette image a été prise en utilisant un shader pour simuler l'effet de sunsetr](https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/sunsetr.png)

Sunsetr est un filtre automatique de lumière bleue pour les compositeurs Wayland. Il automatise des transitions en douceur de la température des couleurs, de neutre à des tons plus chauds, conçu pour réduire la fatigue oculaire et améliorer le sommeil. Sunsetr ajuste automatiquement vos écrans selon votre géolocalisation ou des réglages horaires manuels. Il peut aussi être utilisé pour maintenir indéfiniment la même température de couleur et gamma, et peut alterner entre différents profils définis par l'utilisateur. Le contrôleur peut s'intégrer et automatiser des changements dans votre shell ou applications UI via IPC.

## Fonctionnalités

- **Support Multi-Compositeur** : Fonctionne avec Hyprland, Niri, Sway, River, Wayfire, et d'autres compositeurs Wayland
- **Backend CTM natif Hyprland** : Support direct de la Matrice de Transformation de Couleur pour Hyprland
- **Gestion améliorée de hyprsunset** : Ajoute des transitions de coucher/lever de soleil plus longues, plus propres et plus précises à hyprsunset (Hyprland)
- **Transitions Douces** : Effets de fondu configurables avec algorithme adaptatif
- **Gestion des Profils** : Changement rapide entre profils de configuration (ex. jour, jeu, weekend)
- **Rechargement à chaud** : Mises à jour en direct lors de changements des fichiers de configuration - sans redémarrage
- **IPC pour automatisation** : IPC basé sur socket Unix pour scripts et intégrations externes
- **Transitions basées sur la géolocalisation** : Calcul automatique du lever/coucher du soleil selon votre position
- **Sélection interactive de ville** : Choisissez parmi plus de 10 000 villes dans le monde pour une précision des coordonnées
- **Détection automatique du fuseau horaire** : Retour au fuseau horaire système pour approximation de localisation
- **Support universel Wayland** : Communication directe au protocole sur compositeurs Wayland
- **Paramètres par défaut intelligents** : Fonctionne parfaitement dès l'installation avec des réglages finement adaptés
- **Configuration flexible** : Options de personnalisation étendues pour utilisateurs avancés

## À FAIRE
- [x] Configurer le paquet AUR  
- [x] Rendre l'installation de Nix disponible  
- [x] Implémenter des transitions progressives  
- [x] Support multi-compositeur Wayland  
- [x] Transitions basées sur la géolocalisation  
- [x] Implémenter le backend CTM natif Hyprland  
- [x] Implémenter l'IPC pour le scripting et les intégrations externes  
- [ ] Rendre l'installation Fedora Copr disponible  
- [ ] Rendre l'installation Debian/Ubuntu disponible  

## 💛 Remerciements  

- à wlsunset, hyprsunset, et redshift pour l'inspiration  
- à l'équipe Hyprwm pour avoir rendu Hyprland possible  
- à l'équipe niri pour avoir créé le meilleur compositeur Wayland en Rust  
- à la communauté Wayland pour l'écosystème robuste du protocole



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---