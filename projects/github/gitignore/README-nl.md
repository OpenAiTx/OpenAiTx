# Een verzameling `.gitignore`-sjablonen

Dit is GitHub’s verzameling van [`.gitignore`][man]-bestandssjablonen.
We gebruiken deze lijst om de `.gitignore`-sjabloonkiezers te vullen die beschikbaar zijn
in de GitHub.com-interface bij het aanmaken van nieuwe repositories en bestanden.

Voor meer informatie over hoe `.gitignore`-bestanden werken, en hoe je ze gebruikt,
zijn de volgende bronnen een goed beginpunt:

- Het [Ignoring Files-hoofdstuk][chapter] van het [Pro Git][progit]-boek.
- Het [Ignoring Files-artikel][help] op de GitHub Help-site.
- De [gitignore(5)][man] handleiding.

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Mappenstructuur

We ondersteunen een verzameling sjablonen, als volgt georganiseerd:

- De hoofdmap bevat sjablonen die veel gebruikt worden, om mensen te helpen snel te starten
  met populaire programmeertalen en technologieën. Deze definiëren een nuttige
  set regels om te beginnen en zorgen ervoor dat je geen onbelangrijke bestanden
  aan je repository toevoegt.
- [`Global`](./Global) bevat sjablonen voor verschillende editors, tools en
  besturingssystemen die in diverse situaties gebruikt kunnen worden. Het wordt aanbevolen
  om deze [toe te voegen aan je globale sjabloon](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  of deze regels samen te voegen met je projectspecifieke sjablonen als je ze permanent wilt gebruiken.
- [`community`](./community) bevat gespecialiseerde sjablonen voor andere populaire
  talen, tools en projecten, die momenteel niet thuishoren bij de algemene sjablonen.
  Deze moeten aan je projectspecifieke sjablonen worden toegevoegd wanneer je besluit
  het framework of de tool te gaan gebruiken.

## Wat maakt een goed sjabloon?

Een sjabloon moet een set regels bevatten die Git-repositories helpt te werken met een
specifieke programmeertaal, framework, tool of omgeving.

Als het niet mogelijk is om een kleine set nuttige regels voor deze situatie samen te stellen,
dan is het sjabloon geen goede aanvulling voor deze verzameling.

Als een sjabloon vooral een lijst is van bestanden die door een bepaalde versie van
software worden geïnstalleerd (bijv. een PHP-framework), kan het geplaatst worden in de map `community`.
Zie [versiegebonden sjablonen](#versioned-templates) voor meer details.

Als je een kleine set regels hebt, of een technologie wilt ondersteunen die niet
wijdverbreid is, en je denkt dat dit toch nuttig zal zijn voor anderen, lees dan het
gedeelte over [gespecialiseerde sjablonen](#specialized-templates) voor meer details.

Voeg details toe bij het openen van een pull request als het sjabloon belangrijk en zichtbaar is. We
accepteren het mogelijk niet direct, maar kunnen het later naar de hoofdmap verplaatsen
op basis van belangstelling.

Begrijp ook dat we niet elke tool die ooit heeft bestaan kunnen opnemen.
Ons doel is om een verzameling van de _meest voorkomende en nuttige_ sjablonen te beheren,
niet om elk mogelijk project te dekken. Als we ervoor kiezen jouw taal, tool of project niet op te nemen,
is dat niet omdat het niet geweldig is.

## Richtlijnen voor bijdragen

We zouden het geweldig vinden als je ons helpt dit project te verbeteren. Om deze verzameling
van hoge kwaliteit te houden, vragen we dat bijdragen voldoen aan de volgende richtlijnen.

- **Voorzie een link naar de homepage van de applicatie of het project**. Tenzij het
  extreem populair is, is er een kans dat de beheerders de taal, het framework, de editor,
  app of het project waarop jouw wijziging van toepassing is niet kennen of gebruiken.

- **Voorzie links naar documentatie** ter ondersteuning van de wijziging die je maakt.
  Huidige, canonieke documentatie waarin de te negeren bestanden worden genoemd is het beste.
  Als documentatie niet beschikbaar is om je wijziging te ondersteunen, doe dan je best
  om uit te leggen waarvoor de te negeren bestanden dienen.

- **Leg uit waarom je een wijziging maakt**. Zelfs als het vanzelfsprekend lijkt, neem
  een of twee zinnen de tijd om uit te leggen waarom jouw wijziging of toevoeging nodig is.
  Het is vooral nuttig om uit te leggen waarom deze wijziging van toepassing is op _iedereen_
  die met de betreffende technologie werkt, en niet alleen voor jou of je team.

- **Denk goed na over de reikwijdte van je wijziging**. Als je wijziging specifiek is voor een
  bepaalde taal of framework, zorg er dan voor dat de wijziging wordt doorgevoerd in het
  sjabloon voor die taal of framework, in plaats van in het sjabloon voor een editor, tool of besturingssysteem.

- **Wijzig per pull request slechts _één sjabloon_**. Dit helpt om pull requests en feedback
  te richten op een specifiek project of technologie.

In het algemeen geldt: hoe meer je kunt doen om ons te helpen de wijziging te begrijpen,
hoe groter de kans dat we je bijdrage snel accepteren.

## Versiegebonden sjablonen

Sommige sjablonen kunnen sterk verschillen per versie, en als je wilt bijdragen
aan deze repository moeten we deze specifieke werkwijze volgen:

- Het sjabloon in de hoofdmap moet de momenteel ondersteunde versie zijn
- Het sjabloon in de hoofdmap mag geen versie in de bestandsnaam hebben (d.w.z.
  "altijd actueel")
- Eerdere versies van sjablonen moeten in `community/` staan
- Eerdere versies van het sjabloon moeten de versie in de bestandsnaam opnemen,
  voor de leesbaarheid

Dit zorgt ervoor dat gebruikers altijd de laatste versie krijgen (omdat ze nemen wat in de hoofdmap staat),
maar helpt beheerders om oudere versies die nog in gebruik zijn te ondersteunen.

## Gespecialiseerde sjablonen

Als je een sjabloon hebt dat je wilt bijdragen, maar het is niet echt algemeen,
overweeg dan om het toe te voegen aan de `community`-map in een submap die het beste past.

De regels in je gespecialiseerde sjabloon moeten specifiek zijn voor het framework of
de tool, en eventuele aanvullende sjablonen moeten worden genoemd in een commentaar
in de header van het sjabloon.

Bijvoorbeeld, dit sjabloon kan staan op `community/DotNet/InforCRM.gitignore`:

```
# gitignore-sjabloon voor InforCRM (voorheen SalesLogix)
# website: https://www.infor.com/product-summary/cx/infor-crm/
#
# Aanbevolen: VisualStudio.gitignore

# Negeer modelbestanden die automatisch worden gegenereerd
ModelIndex.xml
ExportedFiles.xml

# Negeer deploy-bestanden
[Mm]odel/[Dd]eployment

# Forceer het includen van portal SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Workflow voor bijdragen

Zo stellen wij voor dat je een wijziging voorstelt aan dit project:

1. [Fork dit project][fork] naar je eigen account.
2. [Maak een branch aan][branch] voor de wijziging die je wilt maken.
3. Maak je wijzigingen op je fork.
4. [Stuur een pull request][pr] van de branch op je fork naar onze `main` branch.

Het is ook prima om de webinterface te gebruiken om wijzigingen aan te brengen. Dit helpt je
door automatisch het project te forken en je uit te nodigen een pull request te sturen.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Licentie

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---