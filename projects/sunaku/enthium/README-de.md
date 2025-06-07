# Enthium – Engrammer trifft Hands Down Promethium

![Fotografie von Enthium v7 auf meiner Glove80-Tastatur](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg)

Diese Anpassung der [Engrammer]- und [Hands Down Promethium]-Tastaturlayouts verbessert die Leistung letzterer in Tastaturlayout-Analysatoren (siehe unten), indem sie horizontal gespiegelt wird, um die Vertrautheit mit [Arnos Engram 2.0]-Layout (CIEA in der Grundreihe der linken Hand; PF wird mit WV getauscht, um wie Engram zu sein) und dem [Dvorak]-Layout (HTNS in der Grundreihe der rechten Hand) wiederherzustellen und indem die Platzierung der Interpunktion für das Programmieren im Geiste des Engrammer-Layouts optimiert wird.

Bemerkenswert ist, dass die Unterschiede zwischen Engram/mer und Enthium so minimal sind, dass man nach etwa 6 Stunden Übung, verteilt über 2–3 Tage (Freitag beginnen und das Wochenende nutzen), komplett umsteigen kann, um alle Buchstaben im [KeyBr]-Training freizuschalten.

Siehe auch: [mein Blogbeitrag](https://sunaku.github.io/enthium-keyboard-layout.html) über die unerwartete "Reise in den Kaninchenbau", die mich zur Entwicklung dieses Tastaturlayouts geführt hat.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi  
[Arnos Engram 2.0]: https://engram.dev  
[Engrammer]: https://github.com/sunaku/engrammer  
[Dvorak]: https://www.dvzine.org  
[KeyBr]: https://github.com/aradzie/keybr.com#readme  

## Layout

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Darstellung von Enthium v7 auf einer Laptop-Tastatur.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Darstellung von Enthium v7 auf meiner Glove80-Tastatur.](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png)

<!-- vim-markdown-toc GFM -->

* [Begründung](#begründung)
  * [Abweichung: PF und WV](#abweichung-pf-und-wv)
  * [Abweichung: B und V](#abweichung-b-und-v)
* [Leistung](#leistung)
  * [Cyanophage-Analysator](#cyanophage-analysator)
  * [KeySolve-Analysator](#keysolve-analysator)
  * [Oxey's Analysator](#oxeys-analysator)
  * [Vergleich](#vergleich)
* [Installation](#installation)
  * [Linux-Setup](#linux-setup)
  * [MacOS-Setup](#macos-setup)
    * [Installation](#installation-1)
    * [Komplexe Modifikation](#komplexe-modifikation)
    * [Deinstallation](#deinstallation)
* [Lizenz](#lizenz)

<!-- vim-markdown-toc -->

## Begründung

* Q und Z sind zur Ausgewogenheit und Symmetrie auf unterschiedliche Hände verteilt.

* B und V befinden sich auf den seitlichen kleinen Grundreihen-Tasten (CapsLock, Apostroph), um das Hochgreifen für Personen mit kurzen oder [geschwächten kleinen Fingern] zu vermeiden.

* Apostroph ist entfernt (auf einem ganz anderen Finger als YOU und I), sodass er getippt werden kann, ohne gleichfingerige Bigramme wie `you'd` und `I'd` zu verursachen.

* Komma und Semikolon sind gruppiert, um in Vim f/F/t/T-Suchen durchzuwechseln und spiegeln zudem die relative Anordnung von K und J auf der rechten Hand wider.

* Auch wenn Punkt und Komma in Bezug auf ihre Shift-Symbole `>` und `<` vertauscht sind, hilft diese Anordnung, laterale Streck-Bigramme zu reduzieren und stapelt sie zudem auf traditionellen, reihenversetzten Tastaturen vertikal.

* Minus liegt auf dem Zeigefinger (wie Komma, Punkt und Semikolon) für eine konsistente Zuständigkeit für Wort-/Satztrennzeichen und für den leichten Zugriff auf den häufigen Unterstrich `_` beim Programmieren, besonders auf reihenversetzten Tastaturen, wo seine Platzierung der natürlichen Streckrichtung des linken Zeigefingers folgt und so den Aufwand minimiert.

* Slash und Punkt ermöglichen Roll-Bigramme wie `/.`, `./` und `../` für Dateisystempfade.

[geschwächte kleine Finger]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### Abweichung: PF und WV

PF wird mit WV getauscht, um folgende Unannehmlichkeiten zu beheben:

* WN ist ein aufsteigendes Stufengleichfinger-Bigramm, das ich lieber nach unten „harken“ würde
* DW (2u-Sprung) ist für Vim nicht so bequem wie bei Engram (wo sie benachbart sind)
* FG (2u-Sprung) ist für Shell-Hintergrundjobs (`bg`, `fg`) nicht so praktisch wie bei Engram
* SW (halber Scherenanschlag) fühlt sich nach innen gekrümmt etwas schwächer an als das Hochgreifen (wie bei Engram)
* FF (z.B. „stu*ff*“) ist etwas mühsam für den kleinen Finger, zweimal in der oberen Reihe zu tippen

Ich wollte eigentlich nicht vom kanonischen Hands Down Promethium-Layout abweichen (dieses „Enthium“-Derivat sollte ursprünglich nur eine einfache horizontale Spiegelung plus einige umsortierte Satzzeichen sein), also habe ich widerwillig die Tastaturlayout-Analyser ausprobiert, um zu sehen, wie schlimm es wäre, PF mit WV zu tauschen ... und zu meiner völligen Überraschung hat diese Änderung die Leistung des Layouts kaum beeinflusst:

* Oxey's Analysator zeigte überhaupt keine Änderungen in den Statistiken!
* KeySolve-Analysator zeigte einen Anstieg von FSB von 0,14 % auf 0,37 %, aber die anderen Werte verbesserten sich: FSS sank von 0,82 % auf 0,48 %, HSB sank von 6,05 % auf 5,64 % und HSS sank von 5,97 % auf 5,50 %; alles andere blieb gleich.
* Im Cyanophage-Analysator stieg der Gesamtaufwand von 730,9 auf 735,9, aber alle anderen Werte blieben unverändert!

Ich bin _so froh_, dass dieses Experiment funktioniert hat, weil es das Layout für mich deutlich angenehmer macht und es die Hürde für andere, die von Engrammer zu Enthium wechseln wollen, weiter senkt. :)

### Abweichung: B und V

B und V werden von der oberen Reihe auf die seitliche Grundreihe rotiert, um das Hochgreifen für Leute mit kurzen oder [geschwächten kleinen Fingern] zu vermeiden. Ihre Tasten werden den am wenigsten häufigen Buchstaben im Englischen zugewiesen: Q und Z.

Im Cyanophage-Analysator reduziert diese Änderung Pinky/Ring-Scheren von 0,49 % auf 0,35 % (ein massiver Rückgang!) und Skip-Bigramme (2u) von 0,30 % auf 0,29 %. Die anderen Analysatoren erfassen die Platzierung der seitlichen kleinen Tasten nicht vollständig, wie in der Anmerkung zu Beginn jedes Analysator-Abschnitts erläutert, aber Oxey's Analysator meldet eine deutliche Reduzierung der SFBs von 0,829 % auf 0,818 %.

## Leistung

### [Cyanophage-Analysator][cNT]

> **HINWEIS:** Dieser Analysator unterstützt derzeit nur die Platzierung eines Buchstabens auf dem linken Daumen, nicht auf dem rechten, daher wird dieses Layout für die Analyse horizontal gespiegelt. Das Spiegeln beeinflusst die Ergebnisse nicht.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

Gesamtstatistik:
* Gesamt-Aufwand: 748,5
* Aufwand:        432,54

Finger-Nutzung:
* Gleichfinger-Bigramme:    0,55 %
* Sprung-Bigramme (2u):     0,29 %
* Laterale Streck-Bigramme: 0,23 %
* Pinky/Ring-Scheren:       0,34 %

Trigramm-Statistik:
* alt:             37,45 %
* bigram roll in:  29,02 %
* bigram roll out: 14,67 %
* other:           8,28 %
* alt sfs:         5,10 %
* redirect:        2,14 %
* roll in:         1,71 %
* weak redirect:   1,32 %
* roll out:        0,31 %

### [KeySolve-Analysator](https://grassfedreeve.github.io/keysolve-web/)

> **HINWEIS:** Dieser Analysator unterstützt derzeit nicht die Platzierung von Buchstaben auf den seitlichen kleinen Grundreihen-Tasten wie der traditionellen CapsLock-Taste und dem Apostroph, daher sind diese Ergebnisse möglicherweise nicht genau. Beispielsweise geht der SFB-Prozentsatz hier davon aus, dass R B V alle vom Daumen getippt werden, während sie in Wirklichkeit auf verschiedenen Fingern liegen: R auf dem rechten Daumen, B auf dem linken kleinen Finger, V auf dem rechten kleinen Finger.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

Gesamtstatistik:

    BIGRAMS     SFB: 0,97 %     LSB: 0,44 %     HSB: 4,79 %     FSB: 0,35 %
    SKIPGRAMS   SFS: 6,99 %     LSS: 0,92 %     HSS: 4,66 %     FSS: 0,38 %
    TRIGRAMS    ALT: 41,24 %    ROL: 40,71 %    ONE: 2,47 %     RED: 1,66 %

Finger-Nutzung:

    LINKS       LI: 13,91 %     LM: 20,17 %     LR: 8,70 %      LP: 3,05 %
    RECHTS      RI: 13,12 %     RM: 14,59 %     RR: 10,60 %     RP: 7,94 %
    GESAMT               LH: 45,83 %                     RH: 54,17 %

Benutzerdefinierte Vorlage zum Kopieren/Einfügen:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey's Analysator](https://oxey.dev/playground/index.html)

> **HINWEIS:** Dieser Analysator unterstützt derzeit nicht die Platzierung von Buchstaben auf den seitlichen kleinen Grundreihen-Tasten wie der traditionellen CapsLock-Taste und dem Apostroph, daher sind diese Ergebnisse möglicherweise nicht genau. Beispielsweise geht der SFB-Prozentsatz hier davon aus, dass B und V vom linken Daumen getippt werden, während sie in Wirklichkeit auf verschiedenen Fingern liegen: B mit dem linken kleinen Finger, V mit dem rechten kleinen Finger.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

Gesamtstatistik:
* Sfb:              0,811 %
* Dsfb:             6,286 %
* Lsb:              0,372 %
* Inrolls:          29,442 %
* Outrolls:         15,841 %
* Total Rolls:      45,283 %
* Onehands:         2,348 %
* Alternates:       31,877 %
* Alternates (sfs): 7,284 %
* Total Alternates: 39,161 %
* Redirects:        3,864 %
* BadRedirects:     1,002 %
* Total Redirects:  4,866 %
* Other:            8,341 %
* Invalid:          0,001 %

Finger-Nutzung:

    Finger 0:  3,63 %     Finger 9:  8,60 %
    Finger 1:  9,08 %     Finger 8:  10,65 %
    Finger 2: 19,30 %     Finger 7:  14,56 %
    Finger 3: 13,28 %     Finger 6:  12,33 %

    Linke Hand:  45,29 %  Rechte Hand: 46,14 %
    Linkes Mitte: 1,384 % Rechtes Mitte: 1,189 %

    Nutzung der Grundreihen-Tasten: 56,37 %

Sfb% pro Finger:

    Finger 0:  0,011 %    Finger 9:  0,024 %
    Finger 1:  0,047 %    Finger 8:  0,100 %
    Finger 2:  0,122 %    Finger 7:  0,051 %
    Finger 3:  0,339 %    Finger 6:  0,114 %

### Vergleich

> **HINWEIS:** Oxey's Analysator unterstützt derzeit nicht die Platzierung von Buchstaben auf den seitlichen kleinen Grundreihen-Tasten wie der traditionellen CapsLock-Taste und dem Apostroph, daher sind diese Ergebnisse möglicherweise nicht genau. Beispielsweise geht der SFB-Prozentsatz hier davon aus, dass B und V vom linken Daumen getippt werden, während sie in Wirklichkeit auf verschiedenen Fingern liegen: B mit dem linken kleinen Finger, V mit dem rechten kleinen Finger. Betrachten Sie stattdessen die [Ergebnisse des Cyanophage-Analysators](#cyanophage-analysator), da dieser die seitlichen kleinen Tasten und einen Daumen-Buchstaben berücksichtigt.

Die [Keyboard-Layout-Community][rKL] empfiehlt gemeinhin [Pascal Getreuers Leitfaden und Vergleichstabelle][PGt] als Ausgangspunkt für Layout-Explorationen, und Enthium zählt dort (statistisch) zu den besten Layouts:

* 0,811 % SFBs – gewinnt 🥈 zweiten Platz; übertroffen nur von Focal
* 0,372 % LSBs – gewinnt 🥇 ersten Platz; schlägt die ganze Tabelle!
* 45,283 % Rolls – schlägt Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak usw.
* 4,866 % Redirects – schlägt MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak usw.
* 2,80 % Pinky off _ohne_ seitliche – schlägt Graphite, Canary, Gallium, MTGAP usw.
  * `Q` (0,10 %) + `'` (0,48 %) + `Z` (0,10 %) + `F` (2,12 %)
* 5,35 % Pinky off _mit_ seitliche – schlägt Engram, Halmak; übertroffen von den übrigen
  * `Q` (0,10 %) + `'` (0,48 %) + `Z` (0,10 %) + `F` (2,12 %) + `B` (1,49 %) + `V` (1,06 %)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/  
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

Der Vollständigkeit halber habe ich alle [Statistiken für dieses und verwandte Layouts](https://raw.githubusercontent.com/sunaku/enthium/main/stats/) tabellarisch aufgelistet:

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english  
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english  
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english  
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english  
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english  

| Analysator | Kategorie  | Statistik             | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | ---------- | --------------------- | -------------- | ---------------- | --------------- | ------------- | ---------------- |
| Oxey's     | Bigrams    | SFB                   | 0,811 %        | 0,868 %          | 1,511 %         | 2,779 %       | 1,367 %          |
| Oxey's     | Bigrams    | DSFB                  | 6,286 %        | 6,761 %          | 7,620 %         | 6,979 %       | 8,767 %          |
| Oxey's     | Bigrams    | LSB                   | 0,372 %        | 0,404 %          | 0,671 %         | 1,255 %       | 1,975 %          |
| Oxey's     | Trigrams   | Inrolls               | 29,442 %       | 29,333 %         | 28,273 %        | 23,820 %      | 25,173 %         |
| Oxey's     | Trigrams   | Outrolls              | 15,841 %       | 14,526 %         | 14,050 %        | 15,104 %      | 20,940 %         |
| Oxey's     | Trigrams   | Total Rolls           | 45,283 %       | 43,858 %         | 42,323 %        | 38,924 %      | 46,113 %         |
| Oxey's     | Trigrams   | Onehands              | 2,348 %        | 2,189 %          | 2,146 %         | 0,624 %       | 2,484 %          |
| Oxey's     | Trigrams   | Alternates            | 31,877 %       | 33,770 %         | 32,483 %        | 35,769 %      | 22,913 %         |
| Oxey's     | Trigrams   | Alternates (SFS)      | 7,284 %        | 8,205 %          | 8,752 %         | 8,787 %       | 7,461 %          |
| Oxey's     | Trigrams   | Total Alternates      | 39,161 %       | 41,974 %         | 41,235 %        | 44,556 %      | 30,375 %         |
| Oxey's     | Trigrams   | Redirects             | 3,864 %        | 2,273 %          | 3,103 %         | 2,639 %       | 9,081 %          |
| Oxey's     | Trigrams   | BadRedirects          | 1,002 %        | 1,236 %          | 1,386 %         | 0,818 %       | 1,498 %          |
| Oxey's     | Trigrams   | Total Redirects       | 4,866 %        | 3,509 %          | 4,489 %         | 3,458 %       | 10,579 %         |
| Oxey's     | Trigrams   | Other                 | 8,341 %        | 8,468 %          | 9,806 %         | 12,437 %      | 9,202 %          |
| Oxey's     | Trigrams   | Invalid               | 0,001 %        | 0,001 %          | 0,001 %         | 0,001 %       | 1,248 %          |
| Oxey's     | Nutzung    | Finger 0              | 3,63 %         | 9,56 %           | 6,58 %          | 8,50 %        | 8,12 %           |
| Oxey's     | Nutzung    | Finger 1              | 9,08 %         | 10,65 %          | 9,21 %          | 8,72 %        | 8,04 %           |
| Oxey's     | Nutzung    | Finger 2              | 19,30 %        | 14,56 %          | 19,47 %         | 12,99 %       | 11,55 %          |
| Oxey's     | Nutzung    | Finger 3              | 13,28 %        | 12,33 %          | 13,35 %         | 14,95 %       | 19,19 %          |
| Oxey's     | Nutzung    | Finger 6              | 12,33 %        | 13,28 %          | 16,04 %         | 16,33 %       | 18,88 %          |
| Oxey's     | Nutzung    | Finger 7              | 14,56 %        | 19,77 %          | 14,93 %         | 13,73 %       | 15,60 %          |
| Oxey's     | Nutzung    | Finger 8              | 10,65 %        | 9,01 %           | 10,31 %         | 13,84 %       | 10,11 %          |
| Oxey's     | Nutzung    | Finger 9              | 8,60 %         | 4,62 %           | 9,90 %          | 10,59 %       | 7,77 %           |
| Oxey's     | Nutzung    | Linke Hand            | 45,29 %        | 47,10 %          | 48,61 %         | 45,16 %       | 46,89 %          |
| Oxey's     | Nutzung    | Rechte Hand           | 46,14 %        | 46,68 %          | 51,18 %         | 54,49 %       | 52,36 %          |
| Oxey's     | Nutzung    | Linkes Mitte          | 1,384 %        | 1,189 %          | 1,765 %         | 9,208 %       | 4,592 %          |
| Oxey's     | Nutzung    | Rechtes Mitte         | 1,189 %        | 1,384 %          | 1,294 %         | 7,257 %       | 3,393 %          |
| Oxey's     | Nutzung    | Grundreihen           | 56,37 %        | 56,37 %          | 56,37 %         | 56,70 %       | 62,31 %          |
| Oxey's     | SFB %      | Finger 0              | 0,011 %        | 0,028 %          | 0,012 %         | 0,020 %       | 0,041 %          |
| Oxey's     | SFB %      | Finger 1              | 0,047 %        | 0,100 %          | 0,089 %         | 0,028 %       | 0,047 %          |
| Oxey's     | SFB %      | Finger 2              | 0,122 %        | 0,051 %          | 0,230 %         | 0,253 %       | 0,186 %          |
| Oxey's     | SFB %      | Finger 3              | 0,339 %        | 0,114 %          | 0,591 %         | 1,075 %       | 0,219 %          |
| Oxey's     | SFB %      | Finger 6              | 0,114 %        | 0,339 %          | 0,380 %         | 0,433 %       | 0,388 %          |
| Oxey's     | SFB %      | Finger 7              | 0,051 %        | 0,185 %          | 0,053 %         | 0,494 %       | 0,341 %          |
| Oxey's     | SFB %      | Finger 8              | 0,100 %        | 0,040 %          | 0,098 %         | 0,256 %       | 0,137 %          |
| Oxey's     | SFB %      | Finger 9              | 0,024 %        | 0,011 %          | 0,058 %         | 0,220 %       | 0,007 %          |
| KeySolve   | Bigrams    | SFB                   | 0,97 %         | 0,94 %           | 1,56 %          | 2,62 %        | 1,49 %           |
| KeySolve   | Bigrams    | LSB                   | 0,44 %         | 0,45 %           | 0,98 %          | 1,17 %        | 2,21 %           |
| KeySolve   | Bigrams    | HSB                   | 4,79 %         | 6,04 %           | 3,02 %          | 6,11 %        | 5,93 %           |
| KeySolve   | Bigrams    | FSB                   | 0,35 %         | 0,26 %           | 0,30 %          | 0,14 %        | 0,37 %           |
| KeySolve   | Skipgrams  | SFS                   | 6,99 %         | 7,02 %           | 7,50 %          | 7,00 %        | 7,95 %           |
| KeySolve   | Skipgrams  | LSS                   | 0,92 %         | 0,93 %           | 1,34 %          | 4,48 %        | 1,75 %           |
| KeySolve   | Skipgrams  | HSS                   | 4,66 %         | 6,11 %           | 6,91 %          | 8,56 %        | 6,49 %           |
| KeySolve   | Skipgrams  | FSS                   | 0,38 %         | 0,78 %           | 0,81 %          | 1,22 %        | 0,78 %           |
| KeySolve   | Trigrams   | ALT                   | 41,24 %        | 40,37 %          | 39,59 %         | 41,70 %       | 27,58 %          |
| KeySolve   | Trigrams   | ROL                   | 40,71 %        | 40,84 %          | 39,35 %         | 37,19 %       | 42,78 %          |
| KeySolve   | Trigrams   | ONE                   | 2,47 %         | 2,66 %           | 2,65 %          | 0,43 %        | 2,45 %           |
| KeySolve   | Trigrams   | RED                   | 1,66 %         | 1,78 %           | 2,65 %          | 2,25 %        | 6,74 %           |
| KeySolve   | Nutzung    | LI                    | 13,91 %        | 13,91 %          | 13,91 %         | 14,56 %       | 18,82 %          |
| KeySolve   | Nutzung    | LM                    | 20,17 %        | 20,92 %          | 20,30 %         | 13,96 %       | 10,18 %          |
| KeySolve   | Nutzung    | LR                    | 8,70 %         | 8,70 %           | 8,83 %          | 9,55 %        | 7,83 %           |
| KeySolve   | Nutzung    | LP                    | 3,05 %         | 3,64 %           | 5,72 %          | 8,24 %        | 7,63 %           |
| KeySolve   | Nutzung    | RI                    | 13,12 %        | 13,12 %          | 16,52 %         | 16,90 %       | 20,00 %          |
| KeySolve   | Nutzung    | RM                    | 14,59 %        | 14,59 %          | 15,03 %         | 13,35 %       | 16,91 %          |
| KeySolve   | Nutzung    | RR                    | 10,60 %        | 10,60 %          | 10,08 %         | 13,36 %       | 10,46 %          |
| KeySolve   | Nutzung    | RP                    | 7,94 %         | 8,95 %           | 9,47 %          | 10,08 %       | 8,16 %           |
| KeySolve   | Total      | LH                    | 45,83 %        | 47,18 %          | 48,75 %         | 46,31 %       | 44,46 %          |
| KeySolve   | Total      | RH                    | 54,17 %        | 52,82 %          | 51,25 %         | 53,69 %       | 55,54 %          |
| Cyanophage | Zusammenf. | Gesamt-Aufwand        | 748,5          | 732,3            | 899,8           | 1185,5        | 1048,2           |
| Cyanophage | Zusammenf. | Aufwand               | 432,54         | 398,07           | 457,44          | 769,78        | 535,05           |
| Cyanophage | Bigrams    | Gleichfinger-Bigrams  | 0,55 %         | 0,58 %           | 0,99 %          | 1,87 %        | 0,91 %           |
| Cyanophage | Bigrams    | Sprung-Bigrams (2u)   | 0,29 %         | 0,36 %           | 0,39 %          | 0,45 %        | 0,41 %           |
| Cyanophage | Bigrams    | Laterale Streck-Bigr. | 0,23 %         | 0,24 %           | 0,41 %          | 0,80 %        | 1,27 %           |
| Cyanophage | Bigrams    | Pinky/Ring-Scheren    | 0,34 %         | 0,42 %           | 0,71 %          | 0,40 %        | 0,65 %           |
| Cyanophage | Trigrams   | Alt                   | 37,45 %        | 36,98 %          | 35,62 %         | 39,08 %       | 25,43 %          |
| Cyanophage | Trigrams   | Alt SFS               | 5,10 %         | 5,27 %           | 5,93 %          | 5,85 %        | 5,47 %           |
| Cyanophage | Trigrams   | Roll in               | 1,71 %         | 1,37 %           | 1,82 %          | 0,86 %        | 1,50 %           |
| Cyanophage | Trigrams   | Roll out              | 0,31 %         | 0,11 %           | 0,29 %          | 0,27 %        | 0,98 %           |
| Cyanophage | Trigrams   | Bigram roll in        | 29,02 %        | 29,18 %          | 28,14 %         | 23,51 %       | 25,18 %          |
| Cyanophage | Trigrams   | Bigram roll out       | 14,67 %        | 14,56 %          | 14,03 %         | 15,14 %       | 21,55 %          |
| Cyanophage | Trigrams   | Redirect              | 2,14 %         | 2,03 %           | 3,05 %          | 2,57 %        | 9,22 %           |
| Cyanophage | Trigrams   | Weak redirect         | 1,32 %         | 1,30 %           | 1,40 %          | 0,28 %        | 1,52 %           |
| Cyanophage | Trigrams   | Other                 | 8,28 %         | 9,20 %           | 9,72 %          | 12,44 %       | 9,17 %           |

## Installation

### Linux-Setup

>*Legende:* QWERTY=weiß; Engram=gold; Enthium=blau/grün; Besonderheiten=pink.  
>![Darstellung dieses Layouts auf einer reihenversetzten Tastatur.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

Installieren:

    cd linux/
    sudo make install
    echo Starte nun deine grafische Sitzung neu.

Aktivieren:

    setxkbmap -layout us    -variant enthium         # nur ein Layout; kein Wechsel
    setxkbmap -layout us,us -variant enthium,basic   # zwei Layouts zum Umschalten

Reparieren (z.B. nach einem systemweiten XKB-Paket-Upgrade):

    cd linux/
    sudo make reinstall
    echo Starte nun deine grafische Sitzung neu.

Deinstallieren:

    cd linux/
    sudo make uninstall
    echo Starte nun deine grafische Sitzung neu.

### MacOS-Setup

#### Installation

Um das Layout unter MacOS zu verwenden, musst du [Karabiner-Elements](https://karabiner-elements.pqrs.org/) installieren.

Du kannst es über [Homebrew](https://brew.sh/) installieren:

    brew install --cask karabiner-elements

Oder lade es von der offiziellen [Karabiner-Elements-Website](https://karabiner-elements.pqrs.org/) herunter.

Nach dem Download folge einfach der Anleitung im [Installationsleitfaden](https://karabiner-elements.pqrs.org/docs/getting-started/installation/).

#### Komplexe Modifikation

Sobald alles installiert ist, kannst du die [Funktion für komplexe Modifikationen](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) nutzen, um deine Tasten umzubelegen.

Die Enthium-Komplexmodifikation ist [hier](https://ke-complex-modifications.pqrs.org/?q=enthium) verfügbar.

Um zum Standardlayout zurückzukehren, entferne einfach die Enthium-Komplexmodifikation.

#### Deinstallation

* Brew: `brew uninstall --cask karabiner-elements`
* Manuell: Entferne die `Karabiner-Elements.app` aus deinem Programme-Ordner.

## Lizenz

Veröffentlicht unter denselben Bedingungen wie die Quellen des [Arnos Engram 2.0]-Tastaturlayouts:

> MIT-Lizenz
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> Hiermit wird jeder Person, die eine Kopie dieser Software und der zugehörigen Dokumentationsdateien (die "Software") erhält, unentgeltlich die Erlaubnis erteilt, uneingeschränkt mit der Software zu verfahren, einschließlich und ohne Ausnahme des Rechts, sie zu benutzen, zu kopieren, zu verändern, zusammenzuführen, zu veröffentlichen, zu verbreiten, unterzulizenzieren und/oder zu verkaufen, sowie Personen, denen die Software bereitgestellt wird, dies zu erlauben, unter den folgenden Bedingungen:
>
> Der obige Urheberrechtshinweis und dieser Erlaubnishinweis sind in allen Kopien oder wesentlichen Teilen der Software beizulegen.
>
> DIE SOFTWARE WIRD OHNE JEDE AUSDRÜCKLICHE ODER IMPLIZIERTE GARANTIE BEREITGESTELLT, EINSCHLIESSLICH DER GARANTIEN DER MARKTGÄNGIGKEIT, DER TAUGLICHKEIT FÜR EINEN BESTIMMTEN ZWECK UND DER NICHTVERLETZUNG. IN KEINEM FALL SIND DIE AUTOREN ODER COPYRIGHTINHABER FÜR ANSPRÜCHE, SCHÄDEN ODER SONSTIGE HAFTUNGEN VERANTWORTLICH, OB IN EINER VERTRAGS-, DELIKT- ODER ANDEREN KLAGE, DIE AUS ODER IM ZUSAMMENHANG MIT DER SOFTWARE ODER DER BENUTZUNG ODER SONSTIGEN GESCHÄFTEN MIT DER SOFTWARE ENTSTEHEN.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html  
> Gefällt dir meine Arbeit? 👍 Bitte [rette ein Leben] als Dank! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> Warum? Für 💕 Ethik, die 🌎 Umwelt und 💪 Gesundheit; siehe Link oben. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---