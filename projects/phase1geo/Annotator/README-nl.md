
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">Assamees</a>
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Download in AppCenter"/>
  </a>
</p>

![<center><b>Hoofdvenster - Licht Thema</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Afbeeldingsannotatie voor Elementary OS")

## Overzicht

Annoteer uw afbeeldingen en laat een afbeelding duizend woorden spreken.

- Laad een afbeelding vanuit het bestandssysteem, het klembord, of maak een screenshot om te annoteren.
- Voeg vormen, stickers, afbeeldingen, tekst, tekeningen en andere callouts toe om details te benadrukken.
- Voeg vergrootglazen toe om details van de afbeelding te versterken.
- Vervagen van delen van de afbeelding om gegevens te verbergen.
- Bijsnijden, formaat wijzigen en randen toevoegen aan afbeeldingen.
- Beheer kleuren, lijndikte en lettertype details.
- Ondersteuning voor zoomen.
- Ondersteuning voor kleurkiezer binnen een geladen afbeelding.
- Onbeperkt ongedaan maken/opnieuw uitvoeren van elke wijziging.
- Sleep PNG-kopieën van de geannoteerde afbeelding.
- Exporteren naar JPEG, PNG, TIFF, BMP, PDF, SVG en WebP bestandsformaten.
- Ondersteuning voor het kopiëren van geannoteerde afbeeldingen naar het klembord.
- Ondersteuning voor printers.

## Installatie

### Debian (vanuit broncode)

U heeft de volgende afhankelijkheden nodig om Annotator te bouwen:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Om Annotator vanuit broncode te installeren, voert u `./app install` uit.

Om Annotator uit te voeren, start je `com.github.phase1geo.annotator`.

### Ubuntu (PPA)

Je kunt de [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) gebruiken die wordt onderhouden door @PandaJim. De PPA ondersteunt Ubuntu 20.04+. Voer de volgende commando's één voor één in

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Als je een Arch Linux-gebruiker bent, is er een
[AUR-pakket](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### Flatpak

Daarnaast kan Annotator geïnstalleerd en uitgevoerd worden via Flatpak.

Om de elementary Flatpak vanuit de bron te bouwen, voer je `./app elementary` uit.

Om de Flathub Flatpak vanuit de bron te bouwen, voer je `./app flathub` uit.

Daarna kun je het uitvoeren via: `./app run-flatpak`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Downloaden op AppCenter"/>
  </a>
</p>

## Dankbetuigingen

Bevat `document-edit-symbolic.svg` en `image-crop-symbolic.svg` van
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
onder de voorwaarden van de GPL v3.0-licentie.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---