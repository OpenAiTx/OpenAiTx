
#### Dir

La commande `dir` (les alias incluent `files`, `directory`) vous permet d’analyser des répertoires et des fichiers. Exemple : `gitleaks dir -v chemin_vers_le_répertoire_ou_fichier`.
Si aucune cible n’est spécifiée comme argument positionnel, alors gitleaks analysera le répertoire de travail actuel.

#### Stdin

Vous pouvez également transmettre des données à gitleaks avec la commande `stdin`. Exemple : `cat un_fichier | gitleaks -v stdin`

### Création d'une baseline

Lors de l’analyse de grands dépôts ou de dépôts avec une longue histoire, il peut être pratique d’utiliser une baseline. Lors de l’utilisation d’une baseline,
gitleaks ignorera toutes les découvertes anciennes qui sont présentes dans la baseline. Une baseline peut être n’importe quel rapport gitleaks. Pour créer un rapport gitleaks, exécutez gitleaks avec le paramètre `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Cela enregistrera le rapport dans un fichier nommé gitleaks-report.json
```

Une fois qu’une baseline est créée, elle peut être appliquée lors de l’exécution de la commande detect à nouveau :

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Après avoir exécuté la commande detect avec le paramètre --baseline-path, la sortie du rapport (findings.json) ne contiendra que les nouveaux problèmes.

## Pre-Commit hook

Vous pouvez exécuter Gitleaks en tant que hook pre-commit en copiant le script exemple `pre-commit.py` dans
votre répertoire `.git/hooks/`.

## Chargement de la configuration

L’ordre de priorité est le suivant :

1. Option `--config/-c` :
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Variable d’environnement `GITLEAKS_CONFIG` avec le chemin du fichier :
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Variable d’environnement `GITLEAKS_CONFIG_TOML` avec le contenu du fichier :
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Un fichier `.gitleaks.toml` dans le chemin cible :
      ```bash
      gitleaks git .
      ```

Si aucune des quatre options n’est utilisée, alors gitleaks utilisera la configuration par défaut.

## Configuration

Gitleaks propose un format de configuration à suivre pour écrire vos propres règles de détection de secrets :

```toml
# Titre du fichier de configuration gitleaks.
title = "Configuration Gitleaks personnalisée"

# Vous avez essentiellement deux options pour votre configuration personnalisée :
#
# 1. définir votre propre configuration, les règles par défaut ne s’appliquent pas
#
#    utilisez par exemple la configuration par défaut comme point de départ :
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. étendre une configuration, les règles sont remplacées ou étendues
#
#    Lorsque vous étendez une configuration, les règles étendues ont la priorité sur les
#    règles par défaut. C’est-à-dire que s’il y a des règles dupliquées dans la configuration étendue
#    et la configuration par défaut, les règles ou attributs étendus les remplaceront.
#    Autre chose à savoir avec l’extension des configurations : vous pouvez chaîner
#    plusieurs fichiers de configuration jusqu’à une profondeur de 2. Les tableaux allowlist sont
#    ajoutés et peuvent contenir des doublons.

# useDefault et path ne peuvent PAS être utilisés en même temps. Choisissez-en un.
[extend]
# useDefault étendra la configuration gitleaks par défaut intégrée dans le binaire
# la dernière version est disponible à :
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# ou vous pouvez fournir un chemin vers une configuration à étendre.
# Le chemin est relatif à l’endroit où gitleaks a été invoqué,
# et non à l’emplacement de la configuration de base.
# path = "common_config.toml"
# Si vous ne souhaitez pas hériter de certaines règles, vous pouvez les spécifier ici.
disabledRules = [ "generic-api-key"]

# Un tableau de tables contenant les informations définissant les instructions
# sur la façon de détecter les secrets
[[rules]]
# Identifiant unique pour cette règle
id = "awesome-rule-1"

# Courte description lisible de la règle.
description = "règle géniale 1"

# Expression régulière Golang utilisée pour détecter les secrets. Notez que le moteur regex de Golang
# ne prend pas en charge les lookaheads.
regex = '''une-regex-au-style-go-pour-cette-règle'''

# Int utilisé pour extraire le secret de la correspondance regex et utilisé comme le groupe dont
# l’entropie sera vérifiée si `entropy` est défini.
secretGroup = 3

# Float représentant l’entropie minimale de Shannon qu’un groupe regex doit avoir pour être considéré comme un secret.
entropy = 3.5

# Expression régulière Golang utilisée pour correspondre aux chemins. Peut être utilisée comme une règle autonome ou en conjonction
# avec une entrée `regex` valide.
path = '''une-regex-de-chemin-de-fichier'''

# Les mots-clés sont utilisés pour le filtrage avant l’analyse regex. Les règles contenant des
# mots-clés effectueront une vérification rapide de comparaison de chaînes pour s’assurer que le(s)
# mot(s)-clé(s) sont présents dans le contenu analysé. Idéalement, ces valeurs doivent
# faire partie de l’identifiant ou être des chaînes uniques spécifiques à la regex de la règle
# (introduit dans v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Tableau de chaînes utilisé pour les métadonnées et à des fins de reporting.
tags = ["tag","another tag"]

    # ⚠️ Dans la v8.21.0 `[rules.allowlist]` a été remplacé par `[[rules.allowlists]]`.
    # Ce changement est rétrocompatible : les instances de `[rules.allowlist]` fonctionnent toujours.
    #
    # Vous pouvez définir plusieurs allowlists pour une règle afin de réduire les faux positifs.
    # Une découverte sera ignorée si _UN_ `[[rules.allowlists]]` correspond.
    [[rules.allowlists]]
    description = "ignorer le commit A"
    # Lorsque plusieurs critères sont définis, la condition par défaut est « OR ».
    # ex : cela peut correspondre sur |commits| OU |paths| OU |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # note : stopwords cible le secret extrait, pas l’ensemble de la correspondance regex
    # comme « regexes ». (stopwords introduit en 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # La condition "AND" peut être utilisée pour s’assurer que tous les critères correspondent.
    # ex : cela correspond si |regexes| ET |paths| sont satisfaits.
    condition = "AND"
    # note : |regexes| vérifie par défaut le _Secret_ dans la découverte.
    # Les valeurs acceptées pour |regexTarget| sont "secret" (par défaut), "match" et "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Vous pouvez étendre une règle particulière à partir de la configuration par défaut, ex : gitlab-pat
# si vous avez défini un préfixe de jeton personnalisé sur votre instance GitLab
[[rules]]
id = "gitlab-pat"
# tous les autres attributs de la règle par défaut sont hérités

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ Dans la v8.25.0 `[allowlist]` a été remplacé par `[[allowlists]]`.
#
# Les allowlists globales ont un ordre de priorité plus élevé que les allowlists spécifiques à une règle.
# Si un commit listé dans le champ `commits` ci-dessous est rencontré, alors ce commit sera ignoré et aucun
# secret ne sera détecté pour ce commit. La même logique s’applique pour les regexes et les chemins.
[[allowlists]]
description = "liste d’exclusion globale"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# note : (global) regexTarget vérifie par défaut le _Secret_ dans la découverte.
# Les valeurs acceptées pour regexTarget sont "match" et "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# note : stopwords cible le secret extrait, pas l’ensemble de la correspondance regex
# comme « regexes ». (stopwords introduit en 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ Dans la version v8.25.0, `[[allowlists]]` possède un nouveau champ appelé |targetRules|.
#
# Les listes d'autorisation communes peuvent être définies une seule fois et assignées à plusieurs règles à l'aide de |targetRules|.
# Cela ne s'appliquera qu'aux règles spécifiées, pas globalement.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Nos ressources de test déclenchent des faux positifs dans quelques règles."
paths = ['''tests/expected/._\.json$''']
```

Consultez la [configuration par défaut de gitleaks](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) pour des exemples ou suivez les [directives de contribution](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) si vous souhaitez contribuer à la configuration par défaut. De plus, vous pouvez lire [cet article de blog gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) qui couvre des configurations avancées.

### Configuration supplémentaire

#### gitleaks:allow

Si vous commettez intentionnellement un secret de test que gitleaks va détecter, vous pouvez ajouter un commentaire `gitleaks:allow` sur cette ligne afin d'indiquer à gitleaks d'ignorer ce secret. Exemple :

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Vous pouvez ignorer certains résultats en créant un fichier `.gitleaksignore` à la racine de votre dépôt. Dans la version v8.10.0, Gitleaks a ajouté une valeur `Fingerprint` au rapport Gitleaks. Chaque fuite, ou détection, possède une empreinte digitale qui identifie de manière unique un secret. Ajoutez cette empreinte au fichier `.gitleaksignore` pour ignorer ce secret spécifique. Consultez le fichier [.gitleaksignore](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) de Gitleaks pour un exemple. Remarque : cette fonctionnalité est expérimentale et susceptible d'évoluer à l'avenir.

#### Décodage

Parfois, les secrets sont encodés d'une manière qui les rend difficiles à trouver uniquement avec des regex. Vous pouvez maintenant demander à gitleaks de trouver et décoder automatiquement le texte encodé. L'option `--max-decode-depth` active cette fonctionnalité (la valeur par défaut « 0 » signifie que la fonctionnalité est désactivée par défaut).

Le décodage récursif est pris en charge puisque le texte décodé peut aussi contenir du texte encodé. L'option `--max-decode-depth` définit la limite de récursion. La récursion s'arrête lorsqu'il n'y a plus de nouveaux segments de texte encodé à décoder, donc définir une profondeur maximale très élevée ne signifie pas qu'il fera autant de passages. Il n'en fera que le nombre nécessaire pour décoder le texte. Globalement, le décodage n'augmente que minimalement le temps d'analyse.

Les résultats pour le texte encodé diffèrent des résultats normaux de la manière suivante :

- La localisation indique les bornes du texte encodé
  - Si la règle correspond à l'extérieur du texte encodé, les bornes sont ajustées pour inclure cela aussi
- La correspondance (match) et le secret contiennent la valeur décodée
- Deux tags sont ajoutés : `decoded:<encoding>` et `decode-depth:<depth>`

Encodages actuellement pris en charge :

- **percent** - Toute valeur encodée en pourcentage ASCII imprimable
- **hex** - Toute valeur hexadécimale ASCII imprimable d'au moins 32 caractères
- **base64** - Toute valeur base64 ASCII imprimable d'au moins 16 caractères

#### Analyse d'archives

Parfois, des secrets sont emballés dans des fichiers d'archive comme des fichiers zip ou tarballs, les rendant difficiles à découvrir. Vous pouvez désormais demander à gitleaks d'extraire et d'analyser automatiquement le contenu des archives. L'option `--max-archive-depth` active cette fonctionnalité pour les types d'analyse `dir` et `git`. La valeur par défaut « 0 » signifie que cette fonctionnalité est désactivée par défaut.

L'analyse récursive est prise en charge puisque les archives peuvent aussi contenir d'autres archives. L'option `--max-archive-depth` définit la limite de récursion. La récursion s'arrête lorsqu'il n'y a plus de nouvelles archives à extraire, donc définir une profondeur maximale très élevée permet simplement d'aller aussi loin que nécessaire.

Les résultats pour les secrets trouvés dans une archive incluent le chemin d'accès au fichier à l'intérieur de l'archive. Les chemins internes sont séparés par `!`.

Exemple de résultat (abrégé pour la lisibilité) :

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Cela signifie qu'un secret a été détecté à la ligne 4 de `files/.env.prod.`, qui se trouve dans `archives/files.tar` qui est lui-même dans `testdata/archives/nested.tar.gz`.

Formats actuellement pris en charge :

Les formats de [compression](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
et d'[archive](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
pris en charge par le package [archives](https://github.com/mholt/archives) de mholt sont pris en charge.

#### Rapports

Gitleaks prend en charge plusieurs formats de rapport intégrés : [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), et [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Si aucun de ces formats ne vous convient, vous pouvez créer votre propre format de rapport avec un fichier [Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) et l'option `--report-template`. Le template peut utiliser les [fonctionnalités étendues de la bibliothèque de templates `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Par exemple, le template suivant fournit une sortie JSON personnalisée :
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Utilisation :
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsors

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Codes de sortie

Vous pouvez toujours définir le code de sortie lorsque des fuites sont détectées avec l’option --exit-code. Codes de sortie par défaut ci-dessous :

```
0 - aucune fuite présente
1 - fuites ou erreur détectées
126 - option inconnue
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---