# Plugin de Chronologie Obsidian

Fournit une barre latérale avec une vue calendrier de vos notes.

![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/demo.gif)

Le calendrier permet de naviguer et de sélectionner une plage journalière, hebdomadaire, mensuelle ou personnalisée de notes. Les plages journalières et hebdomadaires sont affichées dans une chronologie, mais vous pouvez forcer l'affichage des notes dans une simple liste en activant le paramètre `Afficher la liste simple`.
Dans la visualisation en chronologie, vous pouvez grouper les notes créées ou modifiées dans la même plage horaire en activant `Grouper les notes dans la même plage horaire`.

Cliquez sur le nom du mois pour voir une liste de toutes les notes de ce mois.

Pour sélectionner une plage de dates à afficher : sélectionnez une date puis faites un clic Maj sur l'autre date de la plage.

Les notes dans la chronologie seront affichées avec un marquage coloré indiquant si elles ont été **créées** ou **modifiées** à ce moment-là.


![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/example.png)


Cliquer sur le nom de la note l’ouvrira. Ctrl-(ou Commande-) cliquer sur le nom de la note l’ouvrira dans un nouveau volet.

Dans le calendrier, vous pouvez sélectionner les jours individuels ou le numéro de la semaine (à gauche).

Le fond des cases des jours donne une indication sur le nombre de notes créées ou modifiées ce jour-là. L’échelle dépend aussi du nombre moyen de notes quotidiennes défini dans les paramètres.

# Problèmes avec Obsidian Sync
Si vous utilisez Obsidian Sync, vous avez peut-être remarqué que les fichiers synchronisés ont un horodatage de création correspondant au moment où ils ont été synchronisés sur les autres machines.
Dans la version 1.1.9, quelques paramètres ont été ajoutés pour contourner ce problème en lisant (optionnellement) dans les métadonnées du fichier la date réelle de création de la note.
Il n’est pas obligatoire que chaque note ait une date de création/modification dans les métadonnées, si elle est absente, le plugin utilisera la date de création ou de modification du fichier.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---