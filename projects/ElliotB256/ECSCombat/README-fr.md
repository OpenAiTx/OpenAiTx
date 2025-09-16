# ECSCombat

Une simulation de bataille de science-fiction, utilisant le framework ECS de Unity.

[![Une image d'aperçu](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

Une vidéo d'une bataille infinie peut être vue [ici](https://www.youtube.com/watch?v=S2RJfbJly_A).

## Suggestions de ce qu'il faut regarder :

* Différents comportements d'IA se trouvent dans `Battle/AI`.
* Les systèmes de combat se trouvent dans `Battle/Combat`. Cela inclut différents types d'armes (projectile/instantané), l'efficacité des armes selon la portée, l'interception des attaques avec des boucliers.
* L'équipement et les accessoires se trouvent dans `Battle/Equipment`. Les vaisseaux peuvent avoir différents équipements attachés, et ceux-ci peuvent avoir des effets comme changer la vitesse ou le taux de rotation des vaisseaux. L'équipement peut être endommagé et désactivé lorsqu'un vaisseau est attaqué, par exemple des moteurs endommagés entraînent des vaisseaux handicapés.

## Détails techniques :

* Unity 2020.1.0b7
* Universal Render Pipeline (shaders de vaisseaux dans shader graph)

## Un mot de prudence !

Ce projet a été initialement commencé comme un moyen pour moi de pratiquer la programmation dans le style ECS (Entity-Component-System), à l'époque où le package Unity Entities était encore très jeune.
Depuis ses débuts, il y a eu des changements importants à la fois dans l'API Unity Entities et dans ce qui est considéré comme une bonne pratique.
J'ai fait un effort pour garder les choses à jour quand je le pouvais, mais compte tenu de mon temps libre limité, il y aura inévitablement des endroits qui ont besoin d'être retravaillés.
Donc, n'hésitez pas à vous en inspirer, mais gardez à l'esprit qu'il peut y avoir une meilleure façon de faire certaines choses !

## Remerciements finaux

Certaines des sprites sont faites par moi, mais les plus belles ont été prises [ici](https://opengameart.org/content/spaceships-1) où elles sont créditées à [Wuhu](https://opengameart.org/users/wuhu).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---