<div align="center">
  <img width="360" height="112" alt="onigiri" src="https://github.com/user-attachments/assets/eaebfec6-f6df-45b4-a3be-22e2ae97c1e8" />
  <br>
  <br>
  <h3>Onigiri (Bêta)</h3>
</div>

<div align="center">
  <img width="400" height="22" alt="Onigiri divider" src="https://github.com/user-attachments/assets/77958660-41fd-4a43-85df-6c17cda02958" />
</div>

Onigiri est un **module expérimental** qui remplace l’interface standard d’Anki par un tableau de bord moderne, hautement personnalisable et personnalisé, transformant complètement l’apparence d’Anki, une manière de vous motiver à étudier vos cartes tous les jours.

Onigiri (お握り), aussi connu sous le nom d’omusubi (おむすび) ou boule de riz (🍙), est une recette traditionnelle japonaise riche en glucides, essentiels pour fournir de l’énergie, afin que vous puissiez étudier vos cartes Anki ! C’est l’intention d’Onigiri, vous donner la motivation appropriée pour étudier vos cartes avec une nouvelle mise en page magnifique pour Anki (暗記), un glucide supplémentaire pour vous donner ce coup de pouce pour étudier.

### 📝 Philosophie

- **Anki est démocratique** : Anki est un outil utilisé par tout le monde, de tous les coins du monde, chaque utilisateur devrait avoir le droit de l’adapter à ses propres besoins, avec les couleurs et les aspects qu’il souhaite. Onigiri aide Anki à devenir une expérience encore plus démocratique et conviviale.
- **Un bon design peut motiver** : La motivation peut apporter plus de productivité et encourager les étudiants à étudier, à visiter l’application plus souvent et à y être attirés. La recherche a prouvé qu’un design bien structuré et convivial peut, en effet, [cultiver la motivation](https://www.mdpi.com/2414-4088/2/1/6).
- **Des réglages calmes, des options puissantes** : L’expérience de base reste simple. Les contrôles avancés sont accessibles, non écrasants — permettant aux utilisateurs d’évoluer vers la complexité à leur rythme.
- **Cohérence avec flexibilité** : Les utilisateurs peuvent changer l’apparence sans casser les paradigmes fondamentaux d’Anki — cartes, révisions, intervalles — ainsi la mémoire musculaire fonctionne toujours.
&nbsp;

### 🧐 Pourquoi Onigiri ?

Vous vous demandez peut-être « Mais Anki fonctionne déjà bien, pourquoi devrais-je changer ? ».  
Je sais, Anki fonctionne, mais Onigiri aide à rendre son utilisation agréable. En rafraîchissant l’interface avec des réglages calmes, une typographie lisible, et des indications douces, Onigiri réduit les frictions et augmente la motivation – vous incitant à revenir plus souvent à vos cartes, avec plus d’énergie.

###  🚨 Problèmes courants que vous pourriez rencontrer  
Si vous avez des problèmes en utilisant Onigiri, n’hésitez pas à poster un [issue](https://github.com/thepeacemonk/Onigiri/issues), faisons en sorte que ce module soit aussi fluide que possible. Voici quelques bugs potentiels que vous pourriez rencontrer, je travaille à leur résolution :

- J’ai eu, durant le développement, des problèmes concernant le formatage des cartes dans Reviewer en utilisant un fond d’image, cela est dû à l’interaction des fonctions CSS du module et de la carte, si vous remarquez quelque chose, faites-le moi savoir.
- Certains réglages nécessitent de redémarrer Anki, donc si vous avez cliqué sur « Enregistrer » et rien ne se passe, vous avez probablement trouvé un réglage qui demande un redémarrage. Aussi, certains réglages nécessitent juste un rafraîchissement, appuyez simplement sur « D » pour rafraîchir le menu principal.
- Ce module interagit mal avec certains autres modules, tels que Shige’s Leaderboard (qui ne s’affiche pas, car il a une fonction en conflit avec Onigiri) et The KING of Button Add-ons (certaines couleurs, fonds ou alignements des boutons peuvent sembler différents de ce qui est prévu).
- Comme tout module qui gère des fonds animés aux formats .gif et .webp, vous remarquerez qu’Anki utilise un pourcentage élevé de CPU, ne vous inquiétez pas, ce n’est pas un bug, c’est un problème structurel d’Anki et c’est attendu, ces deux formats sont traités par le CPU et comme il y a un rendu constant, cela prend un pourcentage CPU plus élevé.
- Lorsque vous le téléchargez, vos modules externes apparaîtront archivés, allez dans Paramètres -> Menu -> Menu principal et organisez vos « Modules externes archivés ».
- Vous pourriez trouver qu’Onigiri ralentit Anki à cause du Mode Gamification, c’est un symptôme de l’enregistrement des données pendant que vous étudiez, et c’est considéré comme normal, je travaillerai à l’optimisation dans de futures mises à jour.
- Onigiri ne fonctionne pas avec les anciennes versions d’Anki, seulement 25.07.5 et 25.09, veuillez garder votre Anki à jour pour une meilleure expérience.

### 📜 Licence

Ce projet est sous licence `GNU Affero General Public License v3.0 (AGPL-3.0)`. En bref : vous êtes libre d’utiliser, d’étudier et de modifier ce code — mais si vous l’exécutez en tant que service ou distribuez des versions modifiées, vous devez rendre votre code source disponible sous la même licence.

J’ai investi beaucoup de temps dans la conception et la maintenance de ce travail. Merci de respecter la licence et mon effort :
- Ne copiez pas des parties de ce projet dans des produits propriétaires ou commerciaux.
- Si vous vous en inspirez, créditez l’original et gardez vos modifications ouvertes.
- Si vous trouvez de la valeur ici, envisagez de contribuer ou de soutenir le projet.

## Avis

Non affilié à [Onigiri Anki](https://www.onigiri-anki.com/). Aucune approbation n’est exprimée ni implicite.

Onigiri (cet add-on) est un add-on Anki indépendant qui personnalise l’interface de l’application. En revanche, [Onigiri Anki](https://www.onigiri-anki.com/) propose un deck d’étude japonais avec leur propre système. Ce sont des produits distincts et sans aucun lien.

### Crédits et Remerciements
Les projets et ressources suivants ont inspiré la conception et le développement de cet add-on :

- Palettes de couleurs et thèmes : [Catppuccin](https://github.com/catppuccin), [Dracula](https://draculatheme.com/), [Rosé Pine](https://rosepinetheme.com/palette/), [Nord](https://www.nordtheme.com/docs/colors-and-palettes), [Solarized](https://ethanschoonover.com/solarized/), [Antinote themes](https://antinote.io/).
- Inspiration visuelle et thématique : [Mochi Cards](https://mochi.cards/)
- Précédents add-ons par Shige : [Enhance main window](https://ankiweb.net/shared/info/911023479), [Rearrange home addons](https://ankiweb.net/shared/info/1797615099), [Anki Re-design](https://ankiweb.net/shared/info/1959668791) (tous par Shige)
- Conseils fonctionnels et UI : Inspiré par [Review Heatmap](https://ankiweb.net/shared/info/1771074083) (par Glutanamite), [Modern Material Theme](https://ankiweb.net/shared/info/1321246682), et [Coloris](https://github.com/mdbassit/Coloris)

### 🫶 Gratitude

Merci à la communauté **Anki** et [**Ankimon**](https://github.com/h0tp-ftw/ankimon) de m’avoir enseigné les bases du codage et du développement d’add-ons ! Un merci spécial à @Ouranos pour son aide précieuse dans l’identification des bugs.

### 💞 Soutenez mon travail

Je publie régulièrement des mises à jour et nouvelles fonctionnalités. Si mes add-ons ont aidé vos études ou votre flux de travail, pensez à soutenir mon travail. Votre contribution permet de maintenir le projet et de le garder gratuit pour tous. Rejoignez notre [Discord](https://discord.gg/ZU9VZHMk3u)

<a href="https://www.buymeacoffee.com/peacemonk">
<img width="30%" height="auto" alt="Offrez-moi un onigiri" src="https://github.com/user-attachments/assets/2c993906-ccb5-4a75-9235-9b63a8d62252" />
<br>
<br>
</a>

### ⭐ Historique des étoiles GitHub

[![Star History Chart](https://api.star-history.com/svg?repos=thepeacemonk/Onigiri&type=date&logscale&legend=top-left)](https://www.star-history.com/#thepeacemonk/Onigiri&type=date&logscale&legend=top-left)


### 🍙 This is Onigiri

<img width="60%" height="auto" alt="1" src="https://github.com/user-attachments/assets/523a7890-d599-4030-80c5-45bf9626ad17" />
<img width="60%" height="auto" alt="2" src="https://github.com/user-attachments/assets/75fa35cb-e74b-402d-880a-0b98a7ce3ce4" />
<img width="60%" height="auto" alt="3" src="https://github.com/user-attachments/assets/44e0627d-2a57-40b5-9e5a-6b237a848f7c" />
<img width="60%" height="auto" alt="4" src="https://github.com/user-attachments/assets/6bddc6d2-2105-40fd-9b89-df86f39732a3" />
<img width="60%" height="auto" alt="5" src="https://github.com/user-attachments/assets/983121f6-6c63-4f5d-9cf0-3491100ed28d" />
<img width="60%" height="auto" alt="6" src="https://github.com/user-attachments/assets/6a907210-1d64-4d3f-986c-6816641a7080" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-18

---