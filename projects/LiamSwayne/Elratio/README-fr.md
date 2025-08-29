# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~Mise à jour finale.~~ [Mise à jour finale inversée.](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

Un langage de programmation basé sur Python qui combine la performance de Ruby avec la lisibilité de Perl.

> « La solution à l'assembleur »

Pour écrire votre propre programme Elratio, téléchargez [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) et écrivez votre programme dans l’espace indiqué.

# Fonctionnalités
Elratio offre de nombreux avantages par rapport à tous les autres langages !

## Nouvel espace blanc audacieux
Aucun langage moderne n’indique qu’une ligne vide est vide. Elratio prend l’espace blanc dans une toute nouvelle direction audacieuse avec le mot-clé `empty`.
###### Python/Java/R/C/Go/JavaScript :
<pre>

</pre>
###### Elratio :
```python
empty;
```
Elratio ne permet pas les lignes vides. Chaque ligne vide doit contenir le mot-clé `empty`.

## Fin de ligne claire et fin de programme
Beaucoup de langages de programmation modernes sont devenus à la mode et ont popularisé une syntaxe peu inspirée pour les fins de ligne. Elratio, en revanche, utilise le symbole clairement défini `;` pour définir les fins de ligne (sauf les lignes se terminant par `:`).

###### Python :
<pre>
if True:
    pass
</pre>

###### Elratio :
```python
    if True:
pass;
```

De plus, chaque programme doit se terminer par le mot-clé `end`. Une fois de plus, Elratio écrase la concurrence.
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:
```python
end;
```

## Indentation inversée
Les lignes exécutées dans main devaient être abaissées d'un cran, nous avons donc introduit un système d'indentation inversée.

```python
        while True:
    if True:
1000;
```
Vous ne devrez plus jamais vous soucier d’indenter une ligne sans remettre en question les lignes incroyables qui l’entourent.

## Le pouvoir même de la création
Elratio vous permet de jouer à Dieu avec le mot-clé `create`. Débloquez des possibilités numériques illimitées en créant des nombres.
<pre>
SystemOutPrint(7);
>>> Erreur à la ligne 1 : SystemOutPrint(7);
>>> Est-ce une blague ? Le chiffre "7" n’a pas encore été créé. Utilisez d’abord "create 7".
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```

Mais avant de créer des nombres, vous devez créer `create`.
```python
create create;
```

De nombreuses langues manquent d'un indicateur clair de création de classe, mais encore une fois, c'est un coup de circuit après l'autre pour Elratio.
```python
    create class book:
pass;
```

## Commentaires révolutionnaires
Le symbole `#` est depuis longtemps utilisé pour indiquer que certaines lignes sont des commentaires et ne doivent pas être exécutées. Lors de la conception d'Elratio, nous avons reconstruit les commentaires de zéro et avons créé le mot-clé `comment`.
```python
comment rewrite this segment;
```
C'est aussi simple que `comment`, barre d'espace, votre commentaire, et un point-virgule.

## Redéfinir `def`
Bien que `def` puisse être pratique sur le vif, il peut entraîner un code spaghetti, nous l'avons donc remplacé par `definition`.
```python
    definition doNothing:
pass;
```

## Syntaxe d'impression améliorée
Python utilise la syntaxe peu claire `print()` pour imprimer. Elratio utilise `systemOutPrint()` pour plus de clarté.
<pre>
print(10);
>>> Je suis un compilateur de principe. Je n'accepte pas print(). Utilisez plutôt systemOutPrint().
</pre>
```python
systemOutPrint(10);
>>> 10
```
Vous pouvez remercier Java pour avoir inspiré ce changement.

## Retour personnalisé du compilateur
Elratio utilise une technologie de chaîne de nouvelle génération pour fournir à l'utilisateur des messages d'erreur uniques et descriptifs.
<pre>
>>> Programme vide. Ne m'envoie pas cette merde la prochaine fois, idiot !
</pre>
<pre>
>>> Erreur à la ligne 31 : vide
>>> Les instructions qui ne se terminent pas par un deux-points doivent se terminer par ASCII (2^6)-5.
</pre>
<pre>
>>> Gaffe à la ligne 42 : print(44);
>>> Es-tu stupide ? Le chiffre "4" n'a pas encore été créé. Utilise "create 4" d'abord.
</pre>

# Exemples
Vous pouvez trouver des programmes exemples dans le dossier [examples](examples). Voici un exemple de programme d'affichage de l'heure écrit en Elratio :
```python
        comment imports;
        import time;
        comment create number;
        create create;
        create 1;
        empty;
        definition print_formatted_time(current_time, format_string):
    formatted_time = time.strftime(format_string, current_time);
    systemOutPrint("Formatted time:", formatted_time);
    empty;
        definition main():
    systemOutPrint("Welcome to the Simple Time Printer!");
    systemOutPrint("Select an option:");
    create 2;
    systemOutPrint("1. Print current time in default format");
    systemOutPrint("2. Print current time in custom format");
    choice = input("Enter your choice: ");
    empty;
    comment get the current time;
    current_time = time.localtime();
    empty;
    if choice == 1:
comment print the time with formatting;
print_formatted_time(current_time, "%Y-%m-%d %H:%M:%S");
    elif choice == 2:
custom_format = input("Enter your custom format (e.g., %Y/%m/%d %I:%M %p): ");
print_formatted_time(current_time, custom_format);
    else:
systemOutPrint("Invalid choice.");
    empty;
        if __name__ == "__main__":
    main();
        end;
>>> Welcome to the Simple Time Printer!
>>> Select an option:
>>> 1. Print current time in default format
>>> 2. Print current time in custom format
>>> Enter your choice: 1
>>> ('Formatted time:', '2023-08-26 00:34:10')
```
Pour rappel, vous pouvez commencer à coder en Elratio **dès maintenant** en téléchargeant [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) et en écrivant votre programme !


# Support des packages
Elratio supporte tous les packages Python existants ! Les packages n'ont pas besoin d'être modifiés pour être importés dans Elratio.

# Sponsors ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# Licence
Elratio est sous licence GPL 3.0, ce qui signifie que tout programme Elratio doit être open source. Avoir un programme Elratio sur votre ordinateur sans un miroir librement accessible en ligne est une violation de cette licence. Ne nous obligez pas à recourir à la violence.

<!--
Vous êtes toujours là ? C'est fini. Rentrez chez vous.
-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---