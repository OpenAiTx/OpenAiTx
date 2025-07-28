# Godot-Easy-Vehicle-Physics
Un système de véhicule à corps rigide basé sur des rayons pour Godot 4.2 et supérieur

## Description
Un contrôleur de véhicule basé sur la physique conçu pour bien fonctionner au clavier et facile à configurer. Tous les paramètres sont contenus dans un seul script (vehicle.gd) et des info-bulles sont fournies pour chacun d’eux.

## Caractéristiques
Ce contrôleur comprend de nombreux systèmes qui aident à créer un véhicule performant tels que :
- Assistances à la direction
- Assistances au contre-braquage
- Contrôle de traction
- Freins antiblocage
- Assistance à la stabilité
- Assistance en l’air
- Boîte de vitesses automatique
- Différentiels à verrouillage
- Assistances à l’adhérence des pneus
- Paramètres de suspension calculés ; obtenir des paramètres de suspension corrects peut être difficile, donc ce contrôleur calcule les taux de ressort et d’amortissement basés sur des ratios et la répartition du poids.

## Exemples
4 véhicules d’exemple sont inclus :
- demo_arcade.tscn : Se conduit comme une voiture de course arcade, beaucoup d’adhérence, facile à contrôler, avec beaucoup d’assistances.
- demo_simcade.tscn : Se conduit plus proche d’une vraie voiture avec des assistances pour aider à garder le contrôle.
- demo_monster_truck.tscn : Se conduit comme un monster truck, avec très peu d’assistances.
- demo_drift.tscn : Configuré pour un drift facile.

## Contrôles
- Direction : Gauche : ← ou a Droite : → ou d
- Accélérateur : ↑ ou w
- Frein : ↓ ou s
- Frein à main : Espace
- Embrayage : C
- Basculer Boîte de vitesses (Auto/Manuelle) : T
- Changer de vitesse (+) : F ou +
- Changer de vitesse (-) : R ou -
- Infos de débogage : ~
- Changer d’écran de débogage : < ou >

## Moteur Physique
Ce contrôleur fonctionne bien avec les moteurs physiques Godot et Jolt. Un taux de tick physique d’au moins 120 est recommandé et des valeurs plus élevées peuvent être utilisées, mais notez que le comportement du véhicule changera selon le taux de tick.

## Remerciements
Un grand merci à Dechode et Wolfe pour avoir partagé leurs projets à la communauté Godot. Partager ce projet est ma façon de rendre la pareille. Une partie de ce code est basée sur [Godot Advanced Vehicle de Dechode](https://github.com/Dechode/Godot-Advanced-Vehicle) et [SERIES : Driving Simulator Workshop](https://lupine-vidya.itch.io/gdsim/devlog/677572/series-driving-simulator-workshop-mirror) avec attribution incluse dans les fichiers sources appropriés.
Le modèle de voiture fourni en démo vient du [Kenney.nl Car Kit](https://www.kenney.nl/assets/car-kit)

## Projets utilisant Godot Easy Vehicle Physics
Si vous travaillez sur un projet utilisant cet add-on et souhaitez le lister ici, ouvrez une issue pour me le faire savoir.
- [Jack of all Cars](https://dashoe1.itch.io/jack-of-all-cars)
- [Another Lap](https://store.steampowered.com/app/3550210/Another_Lap/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---