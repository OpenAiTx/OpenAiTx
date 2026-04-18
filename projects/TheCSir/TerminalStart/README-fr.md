

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/extension/icon128.png" width="72" alt="Icône TerminalStart">
</p>

<h1 align="center">TerminalStart</h1>

<p align="center">
  Tableau de bord de nouvel onglet modulaire, inspiré du rétro, conçu pour la concentration et la rapidité.
</p>

<p align="center">
  <a href="https://thecsir.github.io/TerminalStart/">Démo en ligne</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/mainPage.png" width="900" alt="Aperçu TerminalStart">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/settingsPage.png" width="900" alt="Paramètres TerminalStart">
</p>

---


## Installer dans Edge / Chrome

1. Ouvrez `edge://extensions` (ou `chrome://extensions`)
2. Activez le **Mode développeur**
3. Cliquez sur **Charger l’extension non empaquetée**
4. Sélectionnez le dossier `extension`


## Intégration Todoist

Synchronisez votre widget todo avec Todoist en utilisant un jeton API personnel.

1. Allez dans **Paramètres > Avancé > Widget Todo**
2. Activez **Synchronisation avec Todoist**  
3. Collez votre jeton API (Paramètres > Intégrations > Développeur sur [todoist.com](https://todoist.com))  
4. Accordez l'autorisation d'hôte lorsque cela est demandé  

**Dates d'échéance** &mdash; ajoutez des dates en langage naturel lors de la création des tâches :  

| Entrée | Tâche | Échéance |  
|---|---|---|  
| `rencontrer john demain à 14h` | rencontrer john | demain à 14h |  
| `acheter des courses lundi prochain` | acheter des courses | lundi prochain |  
| `appeler maman tous les vendredis` | appeler maman | tous les vendredis |  
| `soumettre rapport 15 janv` | soumettre rapport | 15 janv |  

Le NLP de Todoist gère l'analyse. Le mode local prend toujours en charge la syntaxe horaire seule (ex. `standup 9h`).  

## Compilation  

### Exigences  

* Node.js v16+  
* Python 3  

### Étapes  

1. Installer les dépendances :

```
npm install
```

2. Construction :

```
npm run build
```

Le script de construction synchronise automatiquement les ressources dans le dossier `extension/`.

3. Emballer :

```
python scripts/package_addon.py
```

Sortie : `terminal-start-v1.0.0.zip`

### Tests

```
npx playwright test
```

Exécute des tests e2e contre l’extension en utilisant Chromium.

## Notes

- Survolez la section en haut à droite pour les paramètres.
- Les jetons API sont stockés localement dans votre navigateur et ne sont jamais envoyés ailleurs que vers l’API Todoist.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---