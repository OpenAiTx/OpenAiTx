# kanjiapi.dev : une API JSON moderne pour les Kanji

Plus de 13 000 kanji disponibles sur [https://kanjiapi.dev](https://kanjiapi.dev)

## Liens
- Documentation de l’API : https://kanjiapi.dev/#!/documentation
- Aide pour comprendre pourquoi tel kanji figure dans telle liste : https://onlyskin.dev/official-kanji-list-diffs/

## Offrez-moi un café

https://buymeacoffee.com/onlyskin

## Exemples

### Kanji `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

#### Liste de tous les kanji pris en charge

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### Liste des kanji joyo

`$ curl https://kanjiapi.dev/v1/kanji/joyo` (aussi `/jouyou`)

Les kanji JOYO sont des kanji d'usage général définis par le gouvernement japonais. La
base de données Unihan classe quatre kanji supplémentaires comme kanji Joyo, portant le total
à 2140 points de code. Cela est dû au fait que quatre des kanji Joyo sont absents dans
le codage JIS X 0208, donc un kanji différent qui *est* présent dans JIS X 0208 était
historiquement utilisé. Par conséquent, dans la base de données Unihan, à la fois les quatre kanji officiels
et les quatre kanji compatibles JIS X 0208 sont marqués comme kanji Joyo. Ceci
est reflété dans la liste `/joyo` fournie par kanjiapi.dev.

Les caractères concernés sont :
| kanji Joyo officiel | compatible historique JIS X 0208 |
| --- | --- |
|𠮟 U+20B9F |叱 U+53F1|
|塡 U+5861  |填 U+586B|
|剝 U+525D  |剥 U+5265|
|頰 U+9830  |頬 U+982C|

#### Liste des kanji jinmeiyo

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo` (aussi `/jinmeiyou`)

Notez que 82 kanji dans la liste Jinmeiyo ont des points de code dans le bloc de
compatibilité CJK Unicode. Par conséquent, ils seront parfois traités comme « le
même kanji » qu’un autre caractère. Ceci est spécifié par Unicode dans la base de données Unihan.

`kanjiapi.dev` fournit des points d'accès `/kanji/{character}` pour ces points de code
de compatibilité CJK, mais ajoute un champ spécial pour faciliter
l'accès à la version unifiée du caractère. De plus, ces
caractères de compatibilité ont généralement peu ou pas de mots listés dans leur fichier
équivalent `/words/{character}`, et des informations beaucoup plus limitées dans les
champs du point d'accès `/kanji/{character}`. Cela reflète les données présentes

dans le fichier `KANJIDIC`.

Par exemple, le caractère Jinmeiyo 海 (U+FA45) est considéré par Unicode comme étant
le même que le caractère Joyo 海 (U+6d77). La version Jinmeiyo est donc
présente dans le bloc de compatibilité CJK.

C’est un problème car toute couche logicielle (par exemple le cache du navigateur, l’encodage URL)
peut effectuer une normalisation Unicode, ce qui convertirait le caractère Jinmeiyo
en un caractère différent. Si vous vous attendez à voir un caractère Jinmeiyo,
mais que vous voyez un caractère Joyo, c’est probablement la raison.

Si nécessaire, la propriété CSS `font-variant-east-asian: traditional;` peut être
utilisée pour indiquer au navigateur d’afficher le caractère équivalent unifié de manière
traditionnelle, ce qui devrait faire qu’un point de code Joyo s’affiche comme
son équivalent Jinmeiyo.

#### Liste des kanji Heisig

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

Liste des caractères ayant un mot-clé Heisig assigné. Notez qu’il y a quatre
kanji supplémentaires dans la liste Heisig étiquetés avec « [alt] » après le mot-clé normal.
Ce sont les quatre variantes officielles joyo des kanji JIS X 0208 manquants (la
série de livres Heisig a attribué ces mots-clés aux caractères compatibles JIS,
mais une personne les recherchant pouvait venir soit de la version compatible JIS
soit de la version officielle). Voir la section `Liste des kanji joyo` ci-dessus.

#### Liste des kanji d’un certain niveau

`$ curl https://kanjiapi.dev/v1/kanji/grade-1` (niveaux scolaires 1-6, avec le niveau 8 indiquant les classes restantes du lycée)

### Lecture `/v1/reading/{reading}`
```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### Mots `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```
## Développement :

### Exigences :

Suppose que `python 3`, `make` et `node` sont disponibles.

### Configuration :

Installer les bibliothèques python en utilisant requirements.txt

Installer les dépendances node avec `yarn` ou `npm install`.

Enregistrer et extraire le fichier dictionnaire kanji `kanjidic2.xml` depuis [EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project) à la racine du projet.

Enregistrer et extraire le fichier dictionnaire jmdict `JMdict` depuis [EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project) à la racine du projet.

Enregistrer et extraire le fichier Unihan_OtherMappings.txt depuis Unihan.zip de [Unicode](https://www.unicode.org/versions/components-15.0.0.html) à la racine du projet.

Enregistrer et extraire le fichier Unihan_IRGSources.txt depuis Unihan.zip de [Unicode](https://www.unicode.org/versions/components-15.0.0.html) à la racine du projet.

S’assurer que le système dispose de la police `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc`
(disponible pour la génération de favicon).

### Compilation :

Exécuter `make` pour construire le site et les points d’API en tant qu’assets statiques.

Exécuter `python -m pytest tests` pour lancer les tests.

Remarque : pour récupérer les données de la version locale de l’API depuis la version locale du site, vous pouvez définir la racine de votre serveur de fichiers sur out/site (par exemple avec `serveit` : `serveit -s out/site make`). Un lien symbolique vers `out/v1` est présent dans `out/site` pour permettre cela.

Remarque : les fichiers de points d’accès pour les caractères dans le bloc Unicode CJK Compatibility sont écrits dans un répertoire séparé car certains systèmes de fichiers les normalisent avec les équivalents non-compatibles. Cela signifie que quelques points d’accès `/kanji/{character}` et `/words/{character}` n’apparaissent pas sous le chemin normal dans l’API pendant le développement local.








### Déploiement (Nécessite des identifiants de compte Google Cloud) :

#### Versionnage

La version de l'API pour le déploiement est codée en dur dans `api_data.py` et le `makefile`.


#### Téléversement dans le bucket

Après la construction, pour synchroniser les assets construits vers le bucket du site, exécutez :

NB : il est conseillé d'exécuter toutes ces commandes avec `rsync -n` pour un test à sec d'abord

Pour synchroniser le répertoire du site construit (`out/site`) avec la racine du bucket, mais non récursivement :
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

Pour synchroniser les dossiers du répertoire api construit (`out/{version}`) avec le répertoire `/{version}` dans le bucket récursivement sur la base des hachages de fichiers :
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### Configuration de la politique CORS :

La politique CORS est stockée dans `cors.json`, elle peut être mise à jour en modifiant ce fichier et en exécutant `gsutil cors set cors.json gs://kanjiapi.dev`

### Journalisation :

Les fichiers journaux sont générés par le bucket de stockage cloud pour l'API, il y a une
fonction cloud qui est déclenchée chaque fois qu'un fichier journal d'utilisation est écrit. La
fonction cloud lit les fichiers journaux pour agréger des informations utiles qui sont
affichées sur la [page des logs](https://kanjiapi.dev/#!/logs)

La fonction cloud se trouve dans le répertoire `popularity-contest`.

Pour la déployer, exécutez `gcloud functions deploy popularity-contest --gen2
--region=us-west1 --runtime=python310 --source popularity-contest --entry-point
handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` depuis le

racine du projet. (nécessite des identifiants)

Pour exécuter la fonction cloud localement, placez-vous dans le répertoire `popularity-contest`,
créez et/ou activez un environnement virtuel basé sur le fichier `requirements.txt`
dans ce sous-répertoire, puis lancez `python main.py`. Cela est utile pour
(re)traiter manuellement certains fichiers journaux sans déployer ni déclencher la fonction cloud.
(nécessite des identifiants)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---