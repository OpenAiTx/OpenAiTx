# Enthium - Engrammer ontmoet Hands Down Promethium

![Foto van Enthium v7 op mijn Glove80-toetsenbord](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg)

Deze aanpassing van de [Engrammer]- en [Hands Down Promethium]-toetsenbordindelingen verbetert de prestaties van laatstgenoemde in toetsenbordindelingsanalysatoren (zie hieronder) door deze horizontaal te spiegelen om de vertrouwdheid met [Arno's Engram 2.0] indeling (CIEA op de thuistoetsenrij van de linkerhand; PF is verwisseld met WV om op Engram te lijken) en de [Dvorak]-indeling (HTNS op de thuistoetsenrij van de rechterhand) te herstellen, en door de plaatsing van leestekens te optimaliseren voor programmeren in de geest van de Engrammer-indeling.

Opvallend is dat de verschillen tussen Engram/mer en Enthium zo minimaal zijn dat men er volledig op kan overstappen met ongeveer 6 uur oefening, verspreid over 2-3 dagen (begin op vrijdag en gebruik het weekend), om alle letters in [KeyBr]-training te ontgrendelen.

Zie ook: [mijn blogpost](https://sunaku.github.io/enthium-keyboard-layout.html) over de onverwachte reis "down the rabbit hole" die mij leidde tot de ontwikkeling van deze toetsenbordindeling.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi  
[Arno's Engram 2.0]:     https://engram.dev  
[Engrammer]:             https://github.com/sunaku/engrammer  
[Dvorak]:                https://www.dvzine.org  
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme  

## Indeling

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Weergave van Enthium v7 op een laptoptoetsenbord.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)  
>![Weergave van Enthium v7 op mijn Glove80-toetsenbord.](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png)

<!-- vim-markdown-toc GFM -->

* [Redenering](#redenering)
  * [Afwijking: PF en WV](#afwijking-pf-en-wv)
  * [Afwijking: B en V](#afwijking-b-en-v)
* [Prestaties](#prestaties)
  * [Cyanophage-analyse](#cyanophage-analyse)
  * [KeySolve-analyse](#keysolve-analyse)
  * [Oxey's analyse](#oxeys-analyse)
  * [Vergelijking](#vergelijking)
* [Installatie](#installatie)
  * [Linux-installatie](#linux-installatie)
  * [MacOS-installatie](#macos-installatie)
    * [Installatie](#installatie-1)
    * [Complexe wijziging](#complexe-wijziging)
    * [Verwijderen](#verwijderen)
* [Licentie](#licentie)

<!-- vim-markdown-toc -->

## Redenering

* Q en Z zijn verdeeld over verschillende handen voor balans en symmetrie.

* B en V bevinden zich op de laterale pinktoetsen van de thuistoetsenrij (CapsLock, Apostrof) om het omhoog reiken te vermijden voor mensen met korte of [verzwakte pinken].

* Apostrof staat apart (op een volledig andere vinger) van YOU en I zodat het getypt kan worden zonder zelfde-vinger bigrammen zoals `you'd` en `I'd`.

* Komma en puntkomma zijn gegroepeerd voor het cyclisch zoeken met f/F/t/T in Vim en spiegelen ook de relatieve volgorde van K en J op de rechterhand.

* Hoewel punt en komma zijn omgedraaid qua hun shift-symbolen `>` en `<`, helpt deze opstelling om laterale stretch-bigrammen te verminderen en ze ook verticaal te stapelen op traditionele rij-gestaggerde toetsenborden.

* Min staat op de wijsvinger (net als komma, punt en puntkomma) voor consistente verantwoordelijkheid van woord-/zinsbegrenzende leestekens en voor gemakkelijke toegang tot de veelgebruikte `_` underscore in programmeren, vooral op rij-gestaggerde toetsenborden waar de plaatsing de natuurlijke strekking van de linkerwijsvinger volgt en zo de inspanning minimaliseert.

* Slash en punt maken het mogelijk om rollende `/.`, `./`, en `../` bestandsysteem-paden te typen.

[verzwakte pinken]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### Afwijking: PF en WV

PF is verwisseld met WV om de volgende ongemakken aan te pakken:

* WN is een trapvormige opgaande zelfde-vinger bigram die ik liever naar beneden zou harken
* DW (2u sprong) is niet zo handig voor Vim als in Engram (waar ze naast elkaar liggen)
* FG (2u sprong) is niet zo handig voor shell achtergrondtaken (`bg`, `fg`) als in Engram
* SW (halve schaar) voelt iets zwakker aan bij het naar binnen krullen dan bij het omhoog reiken (zoals in Engram)
* FF (bijv. "stu*ff*") is een beetje lastig voor de pink om twee keer te tikken op de bovenste rij

Ik wilde eigenlijk niet afwijken van de canonieke Hands Down Promethium-indeling (deze "Enthium" afgeleide zou eigenlijk gewoon een simpele horizontale spiegeling zijn, plus wat herschikte leestekens), dus ben ik met tegenzin naar de toetsenbordindelingsanalysatoren gegaan om te zien hoe erg het zou zijn om PF met WV te verwisselen... en tot mijn grote verrassing had deze wijziging nauwelijks invloed op de prestaties van de indeling:

* Oxey's analyse toonde helemaal geen verandering in de statistieken!
* KeySolve-analyse liet een toename zien van FSB van 0,14% naar 0,37%, maar de andere statistieken verbeterden: FSS daalde van 0,82% naar 0,48%, HSB daalde van 6,05% naar 5,64% en HSS daalde van 5,97% naar 5,50%; de rest bleef identiek.
* Cyanophage-analyse's Total Word Effort steeg van 730,9 naar 735,9, maar alle andere statistieken bleven gelijk!

Ik ben _zo blij_ dat dit experiment is geslaagd, omdat het de indeling voor mij in de praktijk veel comfortabeler maakt en het ook de drempel voor anderen verlaagt om over te stappen van Engrammer naar Enthium. :)

### Afwijking: B en V

B en V zijn uit de bovenste rij naar de laterale thuistoetsenrij gedraaid om het omhoog reiken te vermijden voor mensen met korte of [verzwakte pinken]. Hun toetsen zijn toegewezen aan de minst frequente letters in het Engels: Q en Z.

In de Cyanophage-analyse verlaagt deze wijziging Pinky/Ring Scissors van 0,49% naar 0,35% (een enorme daling!) en Skip Bigrams (2u) van 0,30% naar 0,29%. De andere analysatoren begrijpen de plaatsing van laterale pinktoetsen niet volledig, zoals uitgelegd in de toelichting bovenaan elk analysator-hoofdstuk, maar Oxey's analyse meldt een aanzienlijke vermindering van SFB's van 0,829% naar 0,818%.

## Prestaties

### [Cyanophage-analyse][cNT]

> **OPMERKING:** Deze analysator ondersteunt momenteel alleen het plaatsen van een letter op de linkerduim en niet op de rechterduim, dus deze indeling is horizontaal gespiegeld voor analyse. Spiegelen heeft geen invloed op de resultaten.

![Schermafbeelding](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

Algemene statistieken:
* Total Word Effort: 748,5
* Effort:            432,54

Vingergebruik:
* Same Finger Bigrams: 0,55%
* Skip Bigrams (2u):   0,29%
* Lat Stretch Bigrams: 0,23%
* Pinky/Ring Scissors: 0,34%

Trigram-statistieken:
* alt:             37,45%
* bigram roll in:  29,02%
* bigram roll out: 14,67%
* other:           8,28%
* alt sfs:         5,10%
* redirect:        2,14%
* roll in:         1,71%
* weak redirect:   1,32%
* roll out:        0,31%

### [KeySolve-analyse](https://grassfedreeve.github.io/keysolve-web/)

> **OPMERKING:** Deze analysator ondersteunt momenteel geen plaatsing van letters op laterale thuistoetsenrij pinktoetsen zoals de traditionele CapsLock-toets en de apostrof, dus deze resultaten zijn mogelijk niet accuraat. Bijvoorbeeld, het SFB-percentage hier gaat ervan uit dat R B V allemaal door de duim worden getypt, terwijl ze in werkelijkheid allemaal op verschillende vingers zitten: met R op de rechterduim, B op de linkerpink en V op de rechterpink.

![Schermafbeelding](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Schermafbeelding](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Schermafbeelding](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

Algemene statistieken:

    BIGRAMS     SFB: 0,97%      LSB: 0,44%      HSB: 4,79%      FSB: 0,35%
    SKIPGRAMS   SFS: 6,99%      LSS: 0,92%      HSS: 4,66%      FSS: 0,38%
    TRIGRAMS    ALT: 41,24%     ROL: 40,71%     ONE: 2,47%      RED: 1,66%

Vingergebruik:

    LINKS       LI: 13,91%      LM: 20,17%      LR: 8,70%       LP: 3,05%
    RECHTS      RI: 13,12%      RM: 14,59%      RR: 10,60%      RP: 7,94%
    TOTAAL            LH: 45,83%                      RH: 54,17%

Aangepaste bron voor kopiëren/plakken:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey's analyse](https://oxey.dev/playground/index.html)

> **OPMERKING:** Deze analysator ondersteunt momenteel geen plaatsing van letters op laterale thuistoetsenrij pinktoetsen zoals de traditionele CapsLock-toets en de apostrof, dus deze resultaten zijn mogelijk niet accuraat. Bijvoorbeeld, het SFB-percentage hier gaat ervan uit dat B en V door de linkerdeum worden getypt, terwijl ze in werkelijkheid op verschillende vingers zitten: B door de linkerpink en V door de rechterpink.

![Schermafbeelding](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

Algemene statistieken:
* Sfb:              0,811%
* Dsfb:             6,286%
* Lsb:              0,372%
* Inrolls:          29,442%
* Outrolls:         15,841%
* Total Rolls:      45,283%
* Onehands:         2,348%
* Alternates:       31,877%
* Alternates (sfs): 7,284%
* Total Alternates: 39,161%
* Redirects:        3,864%
* BadRedirects:     1,002%
* Total Redirects:  4,866%
* Other:            8,341%
* Invalid:          0,001%

Vingergebruik:

    vinger 0:   3,63%   vinger 9:       8,60%
    vinger 1:   9,08%   vinger 8:       10,65%
    vinger 2:   19,30%  vinger 7:       14,56%
    vinger 3:   13,28%  vinger 6:       12,33%

    Linkerhand:   45,29% Rechterhand:     46,14%
    Links midden: 1,384% Rechts midden:   1,189%

    Gebruik thuistoetsen: 56,37%

Sfb% per vinger:

    vinger 0:   0,011%  vinger 9:       0,024%
    vinger 1:   0,047%  vinger 8:       0,100%
    vinger 2:   0,122%  vinger 7:       0,051%
    vinger 3:   0,339%  vinger 6:       0,114%

### Vergelijking

> **OPMERKING:** Oxey's analyse ondersteunt momenteel geen plaatsing van letters op laterale thuistoetsenrij pinktoetsen zoals de traditionele CapsLock-toets en de apostrof, dus deze resultaten zijn mogelijk niet accuraat. Bijvoorbeeld, het SFB-percentage hier gaat ervan uit dat B en V door de linkerdeum worden getypt, terwijl ze in werkelijkheid door verschillende vingers worden getypt: B door de linkerpink en V door de rechterpink. Overweeg in plaats daarvan de [resultaten van de Cyanophage-analyse](#cyanophage-analyse), omdat deze rekening houdt met laterale pinktoetsen en één duimlettertoets.

De [toetsenbordindeling-gemeenschap][rKL] raadt gewoonlijk [Pascal Getreuer's gids en vergelijkingstabel][PGt] aan als startpunt voor indelingsverkenning, en je zult zien dat Enthium tot de beste (statistisch gezien) indelingen behoort:

* 0,811% SFB's -- wint 🥈 tweede plaats; alleen Focal is beter
* 0,372% LSB's -- wint 🥇 eerste plaats; verslaat de hele tabel!
* 45,283% rolls -- verslaat Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak, enz.
* 4,866% redirects -- verslaat MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak, enz.
* 2,80% pinky off _exclusief_ lateraal -- verslaat Graphite, Canary, Gallium, MTGAP, enz.
  * `Q` (0,10%) + `'` (0,48%) + `Z` (0,10%) + `F` (2,12%)
* 5,35% pinky off _inclusief_ lateraal -- verslaat Engram, Halmak; de rest is beter
  * `Q` (0,10%) + `'` (0,48%) + `Z` (0,10%) + `F` (2,12%) + `B` (1,49%) + `V` (1,06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/  
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn  

Voor de volledigheid heb ik alle [statistieken voor deze en gerelateerde indelingen](https://raw.githubusercontent.com/sunaku/enthium/main/stats/) in een tabel gezet:

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english  
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english  
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english  
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english  
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english  

| Analysator | Categorie | Statistiek | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | ---------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigrams   | SFB        | 0,811%         | 0,868%            | 1,511%           | 2,779%        | 1,367%            |
| Oxey's     | Bigrams   | DSFB       | 6,286%         | 6,761%            | 7,620%           | 6,979%        | 8,767%            |
| Oxey's     | Bigrams   | LSB        | 0,372%         | 0,404%            | 0,671%           | 1,255%        | 1,975%            |
| Oxey's     | Trigrams  | Inrolls    | 29,442%        | 29,333%           | 28,273%          | 23,820%       | 25,173%           |
| Oxey's     | Trigrams  | Outrolls   | 15,841%        | 14,526%           | 14,050%          | 15,104%       | 20,940%           |
| Oxey's     | Trigrams  | Total Rolls| 45,283%        | 43,858%           | 42,323%          | 38,924%       | 46,113%           |
| Oxey's     | Trigrams  | Onehands   | 2,348%         | 2,189%            | 2,146%           | 0,624%        | 2,484%            |
| Oxey's     | Trigrams  | Alternates | 31,877%        | 33,770%           | 32,483%          | 35,769%       | 22,913%           |
| Oxey's     | Trigrams  | Alt (SFS)  | 7,284%         | 8,205%            | 8,752%           | 8,787%        | 7,461%            |
| Oxey's     | Trigrams  | Totaal alternates | 39,161%  | 41,974%           | 41,235%          | 44,556%       | 30,375%           |
| Oxey's     | Trigrams  | Redirects  | 3,864%         | 2,273%            | 3,103%           | 2,639%        | 9,081%            |
| Oxey's     | Trigrams  | BadRedirects | 1,002%       | 1,236%            | 1,386%           | 0,818%        | 1,498%            |
| Oxey's     | Trigrams  | Total Redirects | 4,866%     | 3,509%            | 4,489%           | 3,458%        | 10,579%           |
| Oxey's     | Trigrams  | Other      | 8,341%         | 8,468%            | 9,806%           | 12,437%       | 9,202%            |
| Oxey's     | Trigrams  | Ongeldig   | 0,001%         | 0,001%            | 0,001%           | 0,001%        | 1,248%            |
| Oxey's     | Gebruik   | Vinger 0   | 3,63%          | 9,56%             | 6,58%            | 8,50%         | 8,12%             |
| Oxey's     | Gebruik   | Vinger 1   | 9,08%          | 10,65%            | 9,21%            | 8,72%         | 8,04%             |
| Oxey's     | Gebruik   | Vinger 2   | 19,30%         | 14,56%            | 19,47%           | 12,99%        | 11,55%            |
| Oxey's     | Gebruik   | Vinger 3   | 13,28%         | 12,33%            | 13,35%           | 14,95%        | 19,19%            |
| Oxey's     | Gebruik   | Vinger 6   | 12,33%         | 13,28%            | 16,04%           | 16,33%        | 18,88%            |
| Oxey's     | Gebruik   | Vinger 7   | 14,56%         | 19,77%            | 14,93%           | 13,73%        | 15,60%            |
| Oxey's     | Gebruik   | Vinger 8   | 10,65%         | 9,01%             | 10,31%           | 13,84%        | 10,11%            |
| Oxey's     | Gebruik   | Vinger 9   | 8,60%          | 4,62%             | 9,90%            | 10,59%        | 7,77%             |
| Oxey's     | Gebruik   | Linkerhand | 45,29%         | 47,10%            | 48,61%           | 45,16%        | 46,89%            |
| Oxey's     | Gebruik   | Rechterhand| 46,14%         | 46,68%            | 51,18%           | 54,49%        | 52,36%            |
| Oxey's     | Gebruik   | Links midden | 1,384%       | 1,189%            | 1,765%           | 9,208%        | 4,592%            |
| Oxey's     | Gebruik   | Rechts midden| 1,189%       | 1,384%            | 1,294%           | 7,257%        | 3,393%            |
| Oxey's     | Gebruik   | Thuistoetsen| 56,37%        | 56,37%            | 56,37%           | 56,70%        | 62,31%            |
| Oxey's     | SFB%      | Vinger 0   | 0,011%         | 0,028%            | 0,012%           | 0,020%        | 0,041%            |
| Oxey's     | SFB%      | Vinger 1   | 0,047%         | 0,100%            | 0,089%           | 0,028%        | 0,047%            |
| Oxey's     | SFB%      | Vinger 2   | 0,122%         | 0,051%            | 0,230%           | 0,253%        | 0,186%            |
| Oxey's     | SFB%      | Vinger 3   | 0,339%         | 0,114%            | 0,591%           | 1,075%        | 0,219%            |
| Oxey's     | SFB%      | Vinger 6   | 0,114%         | 0,339%            | 0,380%           | 0,433%        | 0,388%            |
| Oxey's     | SFB%      | Vinger 7   | 0,051%         | 0,185%            | 0,053%           | 0,494%        | 0,341%            |
| Oxey's     | SFB%      | Vinger 8   | 0,100%         | 0,040%            | 0,098%           | 0,256%        | 0,137%            |
| Oxey's     | SFB%      | Vinger 9   | 0,024%         | 0,011%            | 0,058%           | 0,220%        | 0,007%            |
| KeySolve   | Bigrams   | SFB        | 0,97%          | 0,94%             | 1,56%            | 2,62%         | 1,49%             |
| KeySolve   | Bigrams   | LSB        | 0,44%          | 0,45%             | 0,98%            | 1,17%         | 2,21%             |
| KeySolve   | Bigrams   | HSB        | 4,79%          | 6,04%             | 3,02%            | 6,11%         | 5,93%             |
| KeySolve   | Bigrams   | FSB        | 0,35%          | 0,26%             | 0,30%            | 0,14%         | 0,37%             |
| KeySolve   | Skipgrams | SFS        | 6,99%          | 7,02%             | 7,50%            | 7,00%         | 7,95%             |
| KeySolve   | Skipgrams | LSS        | 0,92%          | 0,93%             | 1,34%            | 4,48%         | 1,75%             |
| KeySolve   | Skipgrams | HSS        | 4,66%          | 6,11%             | 6,91%            | 8,56%         | 6,49%             |
| KeySolve   | Skipgrams | FSS        | 0,38%          | 0,78%             | 0,81%            | 1,22%         | 0,78%             |
| KeySolve   | Trigrams  | ALT        | 41,24%         | 40,37%            | 39,59%           | 41,70%        | 27,58%            |
| KeySolve   | Trigrams  | ROL        | 40,71%         | 40,84%            | 39,35%           | 37,19%        | 42,78%            |
| KeySolve   | Trigrams  | ONE        | 2,47%          | 2,66%             | 2,65%            | 0,43%         | 2,45%             |
| KeySolve   | Trigrams  | RED        | 1,66%          | 1,78%             | 2,65%            | 2,25%         | 6,74%             |
| KeySolve   | Gebruik   | LI         | 13,91%         | 13,91%            | 13,91%           | 14,56%        | 18,82%            |
| KeySolve   | Gebruik   | LM         | 20,17%         | 20,92%            | 20,30%           | 13,96%        | 10,18%            |
| KeySolve   | Gebruik   | LR         | 8,70%          | 8,70%             | 8,83%            | 9,55%         | 7,83%             |
| KeySolve   | Gebruik   | LP         | 3,05%          | 3,64%             | 5,72%            | 8,24%         | 7,63%             |
| KeySolve   | Gebruik   | RI         | 13,12%         | 13,12%            | 16,52%           | 16,90%        | 20,00%            |
| KeySolve   | Gebruik   | RM         | 14,59%         | 14,59%            | 15,03%           | 13,35%        | 16,91%            |
| KeySolve   | Gebruik   | RR         | 10,60%         | 10,60%            | 10,08%           | 13,36%        | 10,46%            |
| KeySolve   | Gebruik   | RP         | 7,94%          | 8,95%             | 9,47%            | 10,08%        | 8,16%             |
| KeySolve   | Totaal    | LH         | 45,83%         | 47,18%            | 48,75%           | 46,31%        | 44,46%            |
| KeySolve   | Totaal    | RH         | 54,17%         | 52,82%            | 51,25%           | 53,69%        | 55,54%            |
| Cyanophage | Samenv.   | Total Word Effort | 748,5      | 732,3             | 899,8            | 1185,5        | 1048,2            |
| Cyanophage | Samenv.   | Effort      | 432,54         | 398,07            | 457,44           | 769,78        | 535,05            |
| Cyanophage | Bigrams   | Same Finger Bigrams | 0,55%    | 0,58%             | 0,99%            | 1,87%         | 0,91%             |
| Cyanophage | Bigrams   | Skip Bigrams (2u) | 0,29%      | 0,36%             | 0,39%            | 0,45%         | 0,41%             |
| Cyanophage | Bigrams   | Lat Stretch Bigrams | 0,23%    | 0,24%             | 0,41%            | 0,80%         | 1,27%             |
| Cyanophage | Bigrams   | Pinky/Ring Scissors | 0,34%    | 0,42%             | 0,71%            | 0,40%         | 0,65%             |
| Cyanophage | Trigrams  | Alt         | 37,45%         | 36,98%            | 35,62%           | 39,08%        | 25,43%            |
| Cyanophage | Trigrams  | Alt SFS     | 5,10%          | 5,27%             | 5,93%            | 5,85%         | 5,47%             |
| Cyanophage | Trigrams  | Roll in     | 1,71%          | 1,37%             | 1,82%            | 0,86%         | 1,50%             |
| Cyanophage | Trigrams  | Roll out    | 0,31%          | 0,11%             | 0,29%            | 0,27%         | 0,98%             |
| Cyanophage | Trigrams  | Bigram roll in | 29,02%      | 29,18%            | 28,14%           | 23,51%        | 25,18%            |
| Cyanophage | Trigrams  | Bigram roll out | 14,67%     | 14,56%            | 14,03%           | 15,14%        | 21,55%            |
| Cyanophage | Trigrams  | Redirect    | 2,14%          | 2,03%             | 3,05%            | 2,57%         | 9,22%             |
| Cyanophage | Trigrams  | Weak redirect | 1,32%        | 1,30%             | 1,40%            | 0,28%         | 1,52%             |
| Cyanophage | Trigrams  | Other       | 8,28%          | 9,20%             | 9,72%            | 12,44%        | 9,17%             |

## Installatie

### Linux-installatie

>*Legenda:* QWERTY=witte; Engram=goud; Enthium=blauw/groen; Eigenaardigheden=roze.  
>![Weergave van deze indeling op een rij-gestaggerd toetsenbord.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

Installeren:

    cd linux/
    sudo make install
    echo Start nu je grafische sessie opnieuw.

Activeren:

    setxkbmap -layout us    -variant enthium         # één indeling; geen wisselen
    setxkbmap -layout us,us -variant enthium,basic   # duale indeling wisselen

Herstellen (bijv. wanneer een systeemwijde XKB-pakketupgrade de installatie terugdraait):

    cd linux/
    sudo make reinstall
    echo Start nu je grafische sessie opnieuw.

Verwijderen:

    cd linux/
    sudo make uninstall
    echo Start nu je grafische sessie opnieuw.

### MacOS-installatie

#### Installatie

Om de indeling op MacOS te gebruiken, moet je [Karabiner-Elements](https://karabiner-elements.pqrs.org/) installeren.

Je kunt het installeren via [Homebrew](https://brew.sh/):

    brew install --cask karabiner-elements

Of download het van de hoofdwebsite van [Karabiner-Elements](https://karabiner-elements.pqrs.org/).

Volg, zodra je het hebt gedownload, gewoon de instructies van de [installatiegids](https://karabiner-elements.pqrs.org/docs/getting-started/installation/).

#### Complexe wijziging

Zodra alles is geïnstalleerd, kun je de [complex modification feature](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) gebruiken om je toetsen te herdefiniëren.

De enthium complex modification is beschikbaar [hier](https://ke-complex-modifications.pqrs.org/?q=enthium).

Om terug te keren naar de basisindeling, kun je eenvoudig de enthium complex modification verwijderen.

#### Verwijderen

* Brew: `brew uninstall --cask karabiner-elements`
* Handmatig: Verwijder de `Karabiner-Elements.app` uit je map Programma's.

## Licentie

Uitgebracht onder dezelfde voorwaarden als de bron van [Arno's Engram 2.0]-toetsenbordindeling:

> MIT Licentie  
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> Hierbij wordt gratis toestemming verleend aan eenieder die een kopie van deze software en de bijbehorende documentatie (de "Software") verkrijgt, om zonder beperking te handelen in de Software, inclusief maar niet beperkt tot het gebruik, kopiëren, wijzigen, samenvoegen, publiceren, distribueren, sublicentiëren en/of verkopen van kopieën van de Software, en om personen aan wie de Software is geleverd toe te staan dit te doen, onder de volgende voorwaarden:
>
> Bovenstaande copyrightvermelding en deze toestemmingsverklaring dienen te worden opgenomen in alle kopieën of substantiële delen van de Software.
>
> DE SOFTWARE WORDT GELEVERD "AS IS", ZONDER ENIGE GARANTIE, UITDRUKKELIJK OF IMPLICIET, INCLUSIEF MAAR NIET BEPERKT TOT DE GARANTIES VAN VERKOOPBAARHEID, GESCHIKTHEID VOOR EEN BEPAALD DOEL EN NIET-INBREUK. IN GEEN GEVAL ZULLEN DE AUTEURS OF COPYRIGHTHOUDERS AANSPRAKELIJK ZIJN VOOR ENIGE CLAIM, SCHADE OF ANDERE AANSPRAKELIJKHEID, HETZIJ IN EEN ACTIE VAN CONTRACT, ONRECHTMATIGE DAAD OF ANDERSZINS, VOORTVLOEIEND UIT, OF IN VERBAND MET DE SOFTWARE OF HET GEBRUIK OF ANDERE HANDELINGEN IN DE SOFTWARE.

---------------------------------------------------------------------------
[Spaar een leven]: https://sunaku.github.io/vegan-for-life.html  
> Waardeer je mijn werk? 👍 [Spaar vandaag een leven] als dank! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> Waarom? Voor 💕 ethiek, het 🌎 milieu en 💪 gezondheid; zie link hierboven. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---