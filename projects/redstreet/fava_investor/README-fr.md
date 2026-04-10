# Fava Investor

Fava Investor vise à être un ensemble complet de rapports, d’analyses et d’outils pour  
les investissements, pour [Beancount](https://beancount.github.io/) et  
[Fava](https://github.com/beancount/fava) (logiciel pour  
[comptabilité en partie double en texte clair](https://plaintextaccounting.org/)). Il est développé comme une  
collection de modules, chaque module offrant un *plugin Fava, une bibliothèque Beancount, et  
une commande shell*.

### Modules actuels :  
- [Visualisation en arbre de la répartition des actifs par classe](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/assetalloc_class#readme)  
- Répartition des actifs par compte  
- [Optimiseur de pertes fiscales](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/tlh#readme)  
- [Analyse du freinage par liquidités](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/cashdrag#readme)  
- [Synthétiseur](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/summarizer#readme)  
- [Minimiseur de plus-values](https://github.com/redstreet/fava_investor/blob/main/fava_investor/modules/minimizegains#readme)  

### Démo  
***Essayez la démo en direct sur  
  [pythonanywhere](http://favainvestor.pythonanywhere.com/example-beancount-file/extension/Investor/)***.  


#### Captures d’écran (datées) :  
![Capture d’écran : TLH](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot.png)  
![Capture d’écran : Répartition des actifs](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot-assetalloc.png)  

### Utilitaires  

Fava Investor est livré avec `ticker-util`, une collection d’utilitaires pour :  
- télécharger des informations depuis Yahoo pour les matières premières (tickers), et annoter vos  
  déclarations de matières premières avec des métadonnées  
- découvrir les relations entre les tickers dans votre fichier Beancount, telles que les tickers équivalents  
  et substantiellement identiques, ainsi que les groupes partenaires pour l’optimisation des pertes fiscales, à partir d’une  
  spécification minimale et incomplète  
- fournir les ISIN et autres informations d’identification des tickers à vos importateurs  

Pour plus d’informations, installez fava_investor via pip, puis consultez :
```
ticker-util --help
ticker-util relate --help
```
## Installation


```bash
pip3 install fava-investor
```

Ou pour installer la version la plus récente directement depuis git :
```bash
pip3 install git+https://github.com/redstreet/fava_investor
```
Voir [#55](https://github.com/redstreet/fava_investor/issues/55) pour l'installation sous MacOS.

Notez que la dernière version de Fava Investor est compatible avec Beancount v2 et v3.

## Exécution de Fava Investor
### Exécution dans Fava :
Ajoutez ceci à votre source beancount, puis lancez fava comme d'habitude :
```
2000-01-01 custom "fava-extension" "fava_investor" "{}"
```

Vous devriez maintenant voir un lien 'Investor' dans la barre latérale de fava. Pour plus d'informations sur la configuration de l'extension, voir le fichier `huge-example.beancount` inclus.

### Exécution en ligne de commande :
L'interface en ligne de commande (CLI) est accessible via la commande `investor`, qui possède des sous-commandes pour chaque module. Par exemple :



```
investor assetalloc-class
investor tlh
investor --help
```

Both the CLI and the utility (`ticker-util`) use [click](https://click.palletsprojects.com/en/8.1.x/).
[Voir ici](https://click.palletsprojects.com/en/8.1.x/shell-completion/#enabling-completion)
pour activer la complétion shell dans zsh, bash ou fish, ce qui est fortement recommandé.

## Problèmes ?
- Surveillez le terminal depuis lequel vous exécutez fava pour détecter les erreurs
  provenant de fava_investor
- Incluez les messages d'erreur que vous voyez ci-dessus lors de l'ouverture de rapports de bugs ou lors de demandes d'aide

## Contribution

Fonctionnalités, corrections et améliorations sont les bienvenues. Rappelez-vous :
- N'hésitez pas à envoyer des pull requests. Veuillez inclure des tests unitaires
- Pour des changements importants ou susceptibles de nécessiter une discussion, veuillez d'abord contacter et discuter
  pour gagner du temps (ouvrir une issue)
- Veuillez fusionner vos commits (raisonnablement)
- Utilisez les [conventional commits](https://www.conventionalcommits.org/en/v1.0.0/) pour les messages de commit

Merci pour votre contribution !

## Projets connexes
- [Fava Dashboards](https://github.com/andreasgerstmayr/fava-dashboards)
- [Fava Portfolio Returns](https://github.com/andreasgerstmayr/fava-portfolio-returns)
- [Beangrow](https://github.com/beancount/beangrow)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---