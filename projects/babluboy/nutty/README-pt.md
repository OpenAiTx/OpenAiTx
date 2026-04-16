
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Uma Utilidade de Rede

Autor: Siddhartha Das

Um aplicativo simples feito para o elementary OS para fornecer informações essenciais sobre aspectos relacionados à rede. As informações são apresentadas nas seguintes abas.<br>
1. Minhas Informações: Fornece informações básicas e detalhadas sobre a placa de rede do dispositivo<br>
2. Uso: Fornece dados de uso da rede em duas visualizações - uso histórico e uso atual<br>
3. Velocidade: Verifique as velocidades de Upload e Download e obtenha tempos de rota para um host<br>
4. Portas: Fornece informações sobre portas ativas e aplicações que as utilizam no dispositivo local<br>
5. Dispositivos: Monitora, alerta e fornece informações sobre outros dispositivos conectados à rede<br>

Consulte o site do Nutty para detalhes sobre funcionalidades, atalhos, guias de instalação para Ubuntu e outras distros suportadas, etc.:<br>
https://babluboy.github.io/nutty/

## Compilação, Testes e Instalação a partir do Código-Fonte

Você precisará das seguintes dependências para compilar:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

E destas dependências para executar:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Às vezes o vnstat não é iniciado após a instalação, use o comando do sistema init apropriado para iniciar o daemon vnstat, por exemplo, `sudo systemctl enable vnstat`

Execute `meson build` para configurar o ambiente de compilação e execute `ninja test` para compilar

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
Para instalar, use `sudo ninja install`, depois execute com `com.github.babluboy.nutty`


```
sudo ninja install
com.github.babluboy.nutty
```
Para desinstalar, vá até o diretório de build e execute

```
sudo ninja uninstall
```

### Instalação a partir do pacote Deb

Para instalar o Nutty a partir do pacote `.deb`, certifique-se de que todas as dependências de execução acima do Nutty estejam instaladas (não é necessário instalar as dependências de compilação). Em seguida, execute o comando abaixo
```bash
sudo dpkg -i <deb-package-name>.deb
```

E para desinstalar o Nutty instalado via pacote `.deb`, execute
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Se você quiser criar diretamente o pacote `.deb` do Nutty por conta própria, instale as dependências de compilação acima e então execute

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---