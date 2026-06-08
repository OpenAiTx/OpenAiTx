# Impression

Le plugin Impression ajoute des outils d'impression à votre espace de travail Obsidian. Vous pouvez imprimer la note courante, une sélection de texte ou toutes les notes d’un dossier depuis la palette de commandes, le ruban d’impression ou le menu contextuel. Si vous l’aimez ou le trouvez utile, veuillez envisager de lui donner une [étoile ![GitHub Repo stars](https://img.shields.io/github/stars/marijnbent/obsidian-print?style=social)](https://github.com/marijnbent/obsidian-print) sur GitHub.

https://github.com/user-attachments/assets/5882f08c-19e6-46da-b808-608b95376979

*Enregistrement d’écran du plugin en action.*

## Fonctionnalités

- **Imprimer la note courante** : Lancez l’impression depuis la palette de commandes, le ruban d’imprimante ou en cliquant avec le bouton droit sur une note.
- **Imprimer une sélection** : Imprimez uniquement le texte sélectionné dans l’éditeur actif.
- **Imprimer toutes les notes d’un dossier** : Cliquez avec le bouton droit sur un dossier ou utilisez la palette de commandes pour imprimer toutes les notes markdown de ce dossier.

Vous pouvez aussi ajouter un raccourci pour l’action d’impression pour un accès encore plus rapide.

| | |
|:------:|:-------------------------:|
|![image](https://github.com/user-attachments/assets/8ba2959c-20a2-4cab-8ae7-c2f5f2475217)|![image](https://github.com/user-attachments/assets/ddb54bd0-4b58-410f-9d69-0f6a58b2ddfd)

## Support

Si vous appréciez ce plugin, merci de soutenir mon travail et mon enthousiasme en m’offrant un café
sur [https://www.buymeacoffee.com/marijnbent](https://www.buymeacoffee.com/marijnbent).

<a href="https://www.buymeacoffee.com/marijnbent"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=marijnbent&button_colour=6495ED&font_colour=ffffff&font_family=Lato&outline_colour=000000&coffee_colour=FFDD00"></a>

## Pour commencer

### Installer depuis la boutique de plugins communautaires

1. Ouvrez Obsidian et allez dans **Paramètres** > **Plugins communautaires**.
2. Cliquez sur **Parcourir** et recherchez **Impression**.
3. Cliquez sur **Installer** pour ajouter le plugin à votre configuration Obsidian.
4. Une fois installé, activez le plugin et, si vous le souhaitez, accédez à la page des paramètres.

Si vous imprimez souvent, vous voudrez probablement ajouter un raccourci à une ou plusieurs commandes d’impression. Allez dans **Paramètres** > **Raccourcis clavier**, recherchez `print`, et assignez vos raccourcis préférés.

## Paramètres

- **Imprimer le titre de la note** : Inclure le titre de la note dans l’impression.  
- **Imprimer les propriétés** : Inclure les propriétés/frontmatter de la note en haut de la note imprimée.  
- **Taille de la police et des titres** : Ajuster la taille du texte principal et des titres lorsque **Normaliser le style** est activé.  
- **Combiner les notes du dossier** : Supprimer les sauts de page entre les notes lors de l’impression de toutes les notes d’un dossier.  
- **Traiter les lignes horizontales comme des sauts de page** : Interpréter les séparateurs `---` comme des sauts de page à l’impression.  
- **Mode débogage** : Ouvrir une fenêtre d’inspection distincte avec le HTML et CSS générés pour dépanner les problèmes de style.  
- **Hériter des `cssclasses` de la note** : Appliquer les `cssclasses` Obsidian de la note à la sortie imprimée afin que le CSS d’impression spécifique à la note soit conservé.  
- **Normaliser le style** : Utiliser un style d’impression intégré neutre au lieu de reprendre le style actif du thème Obsidian.  
- **CSS personnalisé** : Dans les paramètres avancés, activer un extrait `print.css` depuis le dossier des extraits CSS d’Obsidian lorsqu’il est disponible.  

![image](https://github.com/user-attachments/assets/2ffed185-cc8f-43d9-8444-7cb9657d61f7)  

## Personnaliser le CSS  

Dans les paramètres, vous pouvez optionnellement masquer le titre, et lorsque **Normaliser le style** est activé, vous pouvez également ajuster la taille de la police pour le texte principal et les titres.  

Pour personnaliser davantage l’apparence de vos notes imprimées, vous pouvez créer un extrait `print.css` dans `.obsidian/snippets` et l’activer depuis les paramètres du plugin une fois qu’Obsidian le détecte. Le corps du document imprimé contient la classe `obsidian-print`. Veillez à envelopper votre CSS dans `@media print` ou à préfixer votre CSS spécifique à l’impression avec `.obsidian-print` afin qu’il ne s’applique qu’au contenu imprimé. Si vous activez **Hériter des `cssclasses` de la note**, les classes Obsidian au niveau de la note seront également disponibles dans la sortie imprimée. Les styles de thème pour les blocs de code et MathJax sont aussi transférés dans le document imprimé si nécessaire, sauf si vous activez **Normaliser le style** pour utiliser le style de secours neutre du plugin à la place. Vous pouvez consulter les styles par défaut [dans ce fichier](/styles.css). Chaque note individuelle contient la classe `obsidian-print-note`.  

Si vous rencontrez des problèmes avec le style, activez le Mode Débogage pour ouvrir une fenêtre d’inspection du document d’impression généré.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---