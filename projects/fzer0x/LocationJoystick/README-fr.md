# Location Joystick

## Français

Location Joystick est un module Xposed conçu pour la simulation de localisation. Il fournit une superposition de joystick et divers réglages liés à la localisation pour améliorer l'expérience de simulation.

⚠️ **[NOUVEAU] Fonctionnalité sans Root/Xposed (Simulation de localisation)** ⚠️

# DERNIÈRE VERSION : https://github.com/fzer0x/LocationJoystick_V4/releases

<div align="center">

## 🚀 REJOIGNEZ NOTRE COMMUNAUTÉ 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_CLIQUEZ_ICI_POUR_REJOINDRE-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 Rejoignez et obtenez support & mises à jour !

</div>

![Capture d’écran](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## Fonctionnalités

- **Superposition Joystick :** Naviguez en temps réel avec un joystick personnalisable.
- **Simulation de localisation :** Simulez votre position GPS avec précision.
- **Simulation GNSS :** Simulation complète du statut GNSS (nombre de satellites, SVID, C/N0, etc.) pour simuler un comportement de positionnement réaliste.
- **Randomisation :** Ajoutez un rayon de décalage aléatoire à votre position pour un mouvement plus naturel.
- **Favoris :** Sauvegardez et gérez vos emplacements favoris pour un changement rapide.
- **Interface personnalisable :**
    - Ajustez la transparence (alpha) du joystick et de la mini-carte.
    - Vitesse du joystick configurable.
    - Sauvegarde persistante de la position du joystick.

## Exigences

- **Android :** 10+ (SDK min 30)
- **Root :** Requis pour l’utilisation du framework Xposed.
- **Xposed Framework :** LSPosed est recommandé.
- **[NOUVEAU] Fonctionnalité sans Root/Xposed (Localisation factice)**

## Installation & Configuration du Scope LSPosed

1. Installez l’APK Location Joystick.
2. Ouvrez votre gestionnaire Xposed (ex. LSPosed).
3. Activez le module **Location Joystick**.
4. **Important :** Configurez le scope dans LSPosed :
    - **Android-System** (doit être activé pour GNSS & simulation système complète).
    - **Application(s) cible(s)** (ex. Pokémon GO, Maps).
5. Redémarrez votre appareil (ou forcez l’arrêt de l’application cible et de l’interface système si vous utilisez LSPosed).
6. Ouvrez Location Joystick et accordez les permissions requises (Overlay, Localisation).

## Utilisation

1. Ouvrez l’application et définissez votre position de départ souhaitée sur la carte.
2. Configurez vos paramètres de simulation (vitesse, précision, etc.).
3. Démarrez le service pour afficher le joystick en superposition.
4. Ouvrez votre application cible et déplacez-vous en utilisant le joystick.

## Avertissement

Cet outil est destiné uniquement à des fins éducatives et de développement. Utilisez-le à vos risques et périls.

## Licence

Voir le fichier [LICENSE](LICENSE) pour les détails.

---

# Location Joystick

## 中文

Location Joystick 是一款用于模拟定位的 Xposed 模块。它提供了一个虚拟摇杆悬浮窗以及多种与定位相关的设置，以增强模拟体验。

⚠️ **[新功能] 无需 Root 或 Xposed 的模拟定位功能** ⚠️


<div align="center">

## 🚀 Rejoignez notre communauté 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_Cliquez_pour_rejoindre-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 Rejoignez-nous pour obtenir des avantages gratuits et les dernières mises à jour !

# DERNIÈRE VERSION : https://github.com/fzer0x/LocationJoystick_V4/releases

</div>

![Capture d'écran](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## Fonctionnalités

- **Joystick virtuel flottant :** Utilisez un joystick personnalisable pour un déplacement en temps réel.
- **Simulation de localisation :** Simulez précisément votre position GPS.
- **Simulation GNSS :** Simulation complète de l’état GNSS (nombre de satellites, SVID, C/N0, etc.), utile pour contrer les mécanismes avancés de détection de localisation.
- **Randomisation :** Ajoutez une plage de décalage aléatoire à la localisation pour rendre la trajectoire de déplacement plus naturelle.
- **Favoris :** Sauvegardez et gérez les emplacements fréquemment utilisés pour un changement rapide.
- **Interface personnalisable :**
    - Ajustez la transparence (Alpha) du joystick et de la mini-carte.
    - Configurez la vitesse de déplacement du joystick.
    - Sauvegarde automatique de la position du joystick.

## Exigences système

- **Android :** 10+ (SDK minimum 30)
- **Root :** L’utilisation du framework Xposed nécessite les droits Root.
- **Framework Xposed :** LSPosed est recommandé.
- **[Nouvelle fonctionnalité] Fonction de simulation de localisation sans Root/Xposed**

## Installation et configuration de la portée LSPosed

1. Installez le fichier APK de Location Joystick.
2. Ouvrez le gestionnaire Xposed (par exemple LSPosed).

3. Activez le module **Location Joystick**.  
4. **Important :** Configurez le scope dans LSPosed :  
    - **Android-System** (doit être coché, pour la simulation GNSS et la localisation au niveau système).  
    - **Application cible** (par exemple Pokémon GO, applications de cartographie, etc.).  
5. Redémarrez l’appareil (si vous utilisez LSPosed, vous pouvez aussi forcer l’arrêt de l’application cible et de System UI).  
6. Ouvrez Location Joystick et accordez les autorisations nécessaires (fenêtre flottante, localisation).  

## Mode d’emploi  

1. Ouvrez l’application et définissez la position de départ sur la carte.  
2. Configurez les paramètres de simulation (vitesse, précision, etc.).  
3. Lancez le service pour afficher le joystick flottant.  
4. Ouvrez l’application cible et utilisez le joystick pour vous déplacer.  

## Avertissement  

Cet outil est uniquement destiné à l’apprentissage et au développement, utilisez-le à vos risques et périls.  

## Licence  

Pour les détails de la licence, veuillez consulter le fichier [LICENSE](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---