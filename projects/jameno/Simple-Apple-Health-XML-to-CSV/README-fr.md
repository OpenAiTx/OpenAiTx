# Conversion simple du fichier XML Apple Health en CSV

Un script simple pour convertir le fichier export.xml d'Apple Health en un csv facile à utiliser.



## Comment exécuter

### 1. Vérifiez que Python 3 et Pandas sont installés sur votre machine ou environnement

`python --version` doit retourner _Python 3.x.x_ où x est un nombre quelconque.

Si vous avez Python 2.x.x, veuillez passer à Python 3 ici : https://www.python.org/downloads/ (ou spécifiez la version Python de votre environnement)

`python3 -c "import pandas"` ne doit rien afficher dans la ligne de commande

Si vous obtenez une erreur _**ModuleNotFoundError: No module named 'pandas'**_, installez pandas et réessayez :

`pip3 install pandas`


### 2. Exportez vos données Apple Health

| Accueil Santé | ➡️ | Exporter les données |
|--|--|--|
|<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/health_home.jpg" width=300>||<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/export_data_button.jpg" width = 300 >|

Vos données seront préparées, puis vous pourrez transférer le fichier export.zip sur votre machine.

### 3. Décompressez le fichier, qui devrait contenir :

   * apple_health_export
     * export.xml (C’est le fichier contenant vos données que vous souhaitez convertir)
     
     * export_cda.xml
     
       

### 4. Placez le fichier "apple_health_xml_convert.py" de ce dépôt dans le dossier avec les fichiers et lancez le script

`python3 apple_health_xml_convert.py`



L'export sera écrit avec le format :

* **apple_health_export_YYYY-MM-DD.csv**

  

Dans Excel, la sortie devrait ressembler à ceci :

<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/example_output.jpg">

Remarque : Ce script supprime les préfixes des données Apple Health : `HKQuantityTypeIdentifier`, `HKCategoryTypeIdentifier`, et `HKCharacteristicTypeIdentifier` pour une meilleure lisibilité. N'hésitez pas à commenter ces lignes dans le code avec un `#` si vous souhaitez les conserver dans la sortie CSV.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---