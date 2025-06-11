# RSS-Master

Aangepaste filtering en selectie van RSS-bronnen, met AI-samenvattingen, overzicht en scoring. Prestatiegeoptimaliseerde versie, ondersteunt asynchrone verwerking en parallelle AI-samenvattingen.

### Voorwoord

Begin september begon ik Inoreader + RSSHub te gebruiken om RSS-feeds waarin ik geïnteresseerd ben te verzamelen en te abonneren, in combinatie met Reeder om te lezen. Ik probeerde volledige controle te krijgen over mijn dagelijkse informatiestromen. Na een maand nam het aantal RSS-bronnen gestaag toe en ook het aantal ongelezen berichten groeide, wat me veel leesstress bezorgde. Ik vroeg me af of er een manier was om aangepaste filterregels toe te passen, bij voorkeur met AI-ondersteuning om het lezen te vergemakkelijken en mijn leesbelasting te verminderen.

Inoreader heeft ingebouwde filters, maar alleen daarvoor betalen leek niet erg rendabel; NewsBlur heeft de "Intelligence Trainer" voor slimme classificatie, maar mijn korte test gaf weinig merkbare feedback en liet op korte termijn weinig intelligentie zien; Feedly heeft zowel filters als AI-functionaliteit, wat goed leek aan mijn behoeften te voldoen. Terwijl ik twijfelde of ik van Inoreader naar Feedly als betalende gebruiker moest overstappen, kwam ik deze twee projecten tegen:

- [Laat ChatGPT ons helpen Hacker News samen te vatten](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT gebruiksgids](http://yinan.me/rss-gpt-manual-zh.html)

De algemene aanpak van deze twee projecten is het uitvoeren van een script via GitAction, het ophalen van informatie, daarna vertalen en samenvatten met Open AI's API, vervolgens renderen in een sjabloon en uitrollen op GitHub Pages. De methode in RSS-GPT voldoet beter aan mijn wensen: het script haalt periodiek de RSS XML-bestanden op, verwerkt ze en publiceert de XML op GitHub Pages, waarna je simpelweg deze XML-link in je reader kunt abonneren.

Ik heb een sterke behoefte aan multi-device synchronisatie via Inoreader. Voor nieuwe RSS-bronnen die in de config-bestanden worden toegevoegd, moet Inoreader snel worden geïnformeerd om te synchroniseren. Daarom heb ik het idee van [RSS-GPT](https://github.com/yinan-c/) uitgebreid tot RSS-Master.

### Kenmerken

- **Ondersteunt parallelle verwerking**: gebruikt asynchrone en threadpools om RSS-bronnen en AI-samenvattingen parallel te verwerken, wat de snelheid sterk verbetert  
- **Verbeterd cachemechanisme**: stabieler cachesysteem om dataverlies te voorkomen en prestaties bij herhaalde toegang te verhogen  
- **Betere foutafhandeling**: volledige foutafhandeling en logregistratie bij alle bewerkingen, wat de stabiliteit verhoogt  
- **Geoptimaliseerde HTML-inhoudsextractie**: slimme extractie van artikelinhoud, negeert irrelevante informatie en verbetert de AI-samenvatting  
- **Ondersteuning voor de nieuwste OpenAI API**: volledig compatibel met de nieuwste versie van de OpenAI API  
- **Gedetailleerde statistieken**: levert na verwerking runtime, succespercentages en kostenstatistieken  
- **Ondersteuning voor opmaak van opml-bestanden**: en conversie tussen opml en config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`  
- **Ondersteuning voor aangepaste filterregels**: ondersteunt twee typen filters: include en exclude, met twee toepassingsgebieden: title en article  
- **Aanpasbaar AI-model**: via omgevingsvariabelen kan een ander OpenAI-model worden ingesteld  
- **Aanpasbare basis-URL**: configureerbare basis-URL voor RSS-bestanden, handig voor deployment in verschillende omgevingen  
- **Interactieve testnotebook**: Jupyter-notebook ter beschikking voor het testen van alle functies  

### Omgevingsvariabeleconfiguratie

Het project ondersteunt configuratie via een `.env` bestand met de volgende parameters:

```
# Verplichte parameters
OPENAI_API_KEY=your_openai_api_key_here

# Optionele parameters
RSS_BASE_URL=https://raw.githubusercontent.com/TD21forever/RSS-Master/main/rss-feeds/  # RSS basis URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI model
LOG_LEVEL=INFO                               # Logniveau
PARALLEL_WORKERS=5                           # Aantal parallelle workers
```

Je kunt het bestand `.env.example` kopiëren en hernoemen naar `.env`, en vervolgens de waarden aanpassen.

### Prestatieverbeteringen

Deze versie biedt ten opzichte van de originele versie de volgende prestatieverbeteringen:

1. **Parallelle verwerking van RSS-bronnen**: gebruikt `asyncio` om meerdere RSS-feeds gelijktijdig te verwerken  
2. **Parallelle AI-samenvattingen**: gebruikt threadpools om AI-samenvattingen van meerdere artikelen gelijktijdig te verwerken  
3. **Tekstverwerking geoptimaliseerd**: verbeterde HTML-inhoudsextractie voor intelligenter ophalen van hoofdinhoud  
4. **Veilige bestandsverwerking**: gebruikt veilige schrijfmethodes om dataverlies bij crash te voorkomen  
5. **Geoptimaliseerd geheugengebruik**: verbeterde datastructuren en verwerkingsstroom om geheugenverbruik te verminderen  

### Gebruik

1. Clone het project lokaal  
2. Installeer afhankelijkheden: `pip install -r requirements.txt`  
3. Maak een `.env` bestand aan en stel je OpenAI API sleutel in: `OPENAI_API_KEY=je_sleutel`  
4. Pas `resource/config.yml` aan met je eigen RSS-bronnen  
5. Voer uit met `python main.py` om te starten met verwerken  

### Testen en debuggen

Het project bevat een interactieve testnotebook `test.ipynb` om functies te testen:

1. Ophalen en parseren van RSS-bronnen  
2. Filterfunctionaliteit  
3. AI-samenvattingen  
4. Cachemechanisme  
5. Aangepaste basis-URL  
6. Prestatie testen  

Gebruik:

```bash
# Installeer Jupyter
pip install jupyter

# Start notebook
jupyter notebook test.ipynb
```

### Voorbeeld aangepaste filterregels

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Gebruiksscreenshots

- AI-samenvatting en overzicht functionaliteit

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Aangepaste filtering: filtert de "什么值得买" goede deals sectie, alleen recente gewenste producten worden aanbevolen, zoals frisdrank

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---