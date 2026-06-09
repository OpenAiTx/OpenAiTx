# Panneau d'Alarme Hornet Nest pour ESPHome

Ce dépôt contient les fichiers de configuration du firmware **ESPHome** officiellement pris en charge pour le **Panneau d'Alarme Hornet Nest**, développé par **Technology Automation Consulting LLC**. Le Panneau d'Alarme Hornet Nest est une solution IoT évolutive et personnalisable conçue pour intégrer les systèmes d'alarme filaires traditionnels dans votre maison intelligente via **Home Assistant**. Avec 42 zones optocouplées, 3 sorties relais et des options d’alimentation flexibles PoE ou 12V, il est conçu pour la flexibilité et la fiabilité.

<div style="display: flex; justify-content: space-between;">
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/3D_AlarmPanel_2024-10-06.png" alt="Modèle 3D" width="400"/>
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/hornet-nest-operational.jpg" alt="Installé" width="400"/>
</div>

## Démarrage Rapide

Commencez rapidement en adoptant et en flashant votre Panneau d'Alarme Hornet Nest avec le dernier firmware ESPHome :

1. Branchez un câble Ethernet alimenté en PoE dans le Panneau d'Alarme Hornet Nest.
2. Ouvrez le **Tableau de bord ESPHome** et localisez l’appareil "hornet-nest-XXXXXX" (où XXXXXX est un identifiant hexadécimal unique).
3. Cliquez sur l’option **Adopter** sur l’appareil.
4. La boîte de dialogue **Adopter l’appareil** s’ouvre. Vous pouvez renommer votre appareil si vous le souhaitez puis cliquez de nouveau sur l’option **Adopter**.
5. La boîte de dialogue **Configuration créée** s’ouvre et indique qu’une nouvelle configuration doit être installée sur l’appareil, cliquez sur le bouton **Installer**.
6. ESPHome commencera à compiler le nouveau firmware. Lorsque la ligne **"INFO Sucessfully uploaded program."** s’affiche, cliquez sur **STOP** pour fermer la fenêtre.
4. Découvrez le Panneau d'Alarme Hornet Nest dans **Home Assistant** > **Paramètres** > **Appareils & Services**.
5. Cliquez sur **Configurer** sur le nouvel appareil pour l’ajouter dans Home Assistant.

## Modifications et Notes de Version

Consultez les **Releases** pour les notes de version et les images firmware précompilées téléchargeables.

## Conçu pour ESPHome

Le **Panneau d'Alarme Hornet Nest** utilise le microcontrôleur **wESP32 PoE** et est entièrement compatible avec le firmware **ESPHome**. C’est un produit open-source, conçu pour une personnalisation facile par l’utilisateur, idéal pour les utilisateurs de Home Assistant qui recherchent une solution d’alarme évolutive et flexible. Les **fichiers de configuration YAML ESPHome** inclus sont entièrement documentés, permettant aux utilisateurs avancés de personnaliser, construire et mettre à jour leur appareil avec quelques modifications simples.

## Fonctionne avec Home Assistant

Ces configurations firmware **ESPHome** permettent une installation simple et plug-and-play dans **Home Assistant**. L’intégration est locale, rapide et entièrement personnalisable, offrant aux utilisateurs un contrôle complet sur leur système de sécurité domestique.
<img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/esphome-integrated.png" alt="Appareil ESPHome" width="600">

## Dans Ce Dépôt

Ce dépôt contient des **modèles complets de configuration firmware YAML** pour le **Panneau d'Alarme Hornet Nest** au niveau supérieur. Ces modèles sont prêts à être importés via le **Tableau de bord ESPHome**, où ils peuvent être personnalisés et déployés.

## Manuel Utilisateur
Pour des instructions détaillées, veuillez vous référer au manuel utilisateur officiel [ici.](https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/hnap-user-manual.pdf)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---