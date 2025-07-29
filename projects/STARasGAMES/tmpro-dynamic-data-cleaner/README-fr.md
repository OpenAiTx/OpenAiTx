## À propos
Les assets de polices dynamiques TextMeshPro ont une habitude très ennuyeuse de sauvegarder leurs données binaires générées dynamiquement dans le
même fichier texte que leurs données de configuration. Cela cause d'énormes problèmes pour le contrôle de version.

Le script de ce package résout le problème ci-dessus. Il s'exécute chaque fois que des assets dans le projet sont sur le point d'être sauvegardés. Si l’un de
ces assets est un asset de police dynamique TMP, ses données générées dynamiquement seront effacées avant d’être
sauvegardées, ce qui empêche ces données de polluer le contrôle de version.

Crédits à @cxode qui a trouvé cette solution brillante :<br>
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

Ma contribution est d’avoir transformé le script en un package compatible upm pouvant être facilement installé.<br>
Quelques améliorations de performance et vérifications supplémentaires ont été ajoutées pour des cas limites.<br>
De plus, j’ai créé un test pour vérifier rapidement si le script fonctionne correctement dans votre projet/version Unity.<br>

## Installation
Installez via l’URL git :
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

Ou en ajoutant une nouvelle entrée dans votre **`manifest.json`**.
```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
Pour rendre le test d'intégration visible dans la fenêtre TestRunner, vous devez ajouter l'attribut `"testables"`, mais cela est optionnel.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---