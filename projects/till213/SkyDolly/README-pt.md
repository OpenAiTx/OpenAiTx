
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pré-Lançamento](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licença: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Compiladores Suportados](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Testes Unitários](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - A Ovelha Negra para Suas Gravações de Voo.

## Sobre
Sky Dolly conecta-se a uma instância em execução do Flight Simulator 2020 e grava várias variáveis de simulação, para reprodução.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

A conexão é feita via SimConnect, uma API padrão introduzida com o Flight Simulator X para conectar-se ao simulador de voo.

Consulte também o [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Funcionalidades
- Gravar / Pausar / Reproduzir
- Voos em formação (múltiplas aeronaves, reprodução durante gravação, "voar com formação", offset de tempo)
- Taxa de amostragem de gravação configurável: fixa ou variável ("automático")
- Velocidade de reprodução ajustável ("câmera lenta", "timelapse"), repetição de reprodução
- Posição, velocidade e variáveis básicas de controle de voo (ailerons, leme, flaps, trem de pouso, ...) são gravadas
- Arquitetura de plugins com vários plugins de importação/exportação (CSV, GPX, IGC, KML)
- Módulo de localização com mais de 100 locais padrão e funcionalidade de importação/exportação
- Persistência baseada em banco de dados (SQLite) ("diário de bordo")

Assista ao trailer (preview) de lançamento no [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Gravador de Voo & Replay para Flight Simulator 2020 (Trailer Cinematográfico)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Gravador de Voo & Replay para Flight Simulator 2020 (Trailer Cinematográfico)")

Para mais vídeos criados com o Sky Dolly, consulte também o [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Novas funcionalidades e futuras estão no [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Uso Básico

- Inicie um voo
- Clique em "Gravar" (tecla R)
- Você pode pausar a gravação (tecla P)
- Pare a gravação (tecla R) e clique em "Reproduzir" (barra de espaço)
- Ajuste a velocidade da reprodução e procure a posição de reprodução, também durante a reprodução
- Voos gravados são automaticamente salvos no "diário de bordo"
- Selecione um voo no diário de bordo e pressione "Carregar" (ou dê um duplo clique na linha) para carregar o voo salvo

### Gravação & Reprodução em Formação

#### Gravação

- Mude para o módulo "Formação" (tecla F2)
- Clique em "Gravar" (tecla R)
- Cada aeronave gravada é adicionada ao voo atual
- Enquanto as aeronaves existentes são reproduzidas durante a gravação com taxa de amostragem "auto", você ainda pode alterar a taxa de amostragem da gravação

#### Posição

- A última aeronave gravada se torna a "aeronave do usuário" (sendo seguida pela câmera no simulador de voo)
- Selecione uma posição relativa à atual "aeronave do usuário" antes de gravar

#### Reprodução

- Basta clicar em "Reproduzir", "Pausar" e navegar na linha do tempo, assim como em um voo de aeronave única
- Altere a "aeronave do usuário" (também durante a reprodução) para "pular de cockpit em cockpit"
- Tome o controle da "aeronave do usuário" selecionando as opções "Assumir controle" ou "Voar com Formação"

#### Gerenciando Formações

- Você pode excluir aeronaves individuais de um voo ("formação")
- Deve haver pelo menos uma aeronave por voo, portanto, a última aeronave não pode ser excluída
- Adicione um deslocamento de tempo à aeronave selecionada ("sincronização de voo em formação multiplayer")
- Para iniciar um novo voo de aeronave única, volte ao módulo "Diário de Bordo" (tecla F1) e clique em "Gravar" (tecla R)

Por que você não experimenta com um dos ["Tell Tours" guiados](https://github.com/till213/Tell-Tours)? :)

## Download

Vá para [Releases](https://github.com/till213/SkyDolly/releases) e baixe a versão mais recente.

Última (pré-)versão: **Sky Dolly 0.19.2**

Calcule e compare seu checksum com os [SHA-256 publicados](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), para verificar a integridade da sua cópia baixada.

## Compilação

Consulte a documentação [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Projetos Relacionados

- https://github.com/nguyenquyhy/Flight-Recorder - Um aplicativo de gravação e reprodução de voos baseado em .Net
- https://github.com/saltysimulations/saltyreplay/ - Uma gravação e reprodução com interface web para o usuário
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Grava o voo e gera "replays" no formato Google Earth (KML)
- https://github.com/Elephant42/FS_Tool - Uma ferramenta simples que permite definir a localização da aeronave e a taxa de simulação
- https://github.com/pyviator/msfs-geoshot - Tira screenshots e automaticamente “geotagueia” eles
- https://github.com/ijl20/msfs_logger_replay - Gravador IGC e reprodução (para FSX)
- https://joinfs.net/ - Permite sincronizar voos multiplayer entre diferentes simuladores de voo (MSFS, Prepar3D/FSX, XPlane). Também oferece gravador de voo com gravação de voo em formação ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote para o A32NX da FlyByWire: controla funções do cockpit do FBW A320, usando FSUIPC7
- https://flightloganalyzer.com/ - O FlightLog Analyzer analisa o logbook do MSFS e exporta CSV compatível com Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - O FSAutoSave armazena automaticamente (ou sob demanda) planos de voo
- https://github.com/mracko/MSFS-Landing-Inspector - Analisa o desempenho dos seus pousos
- [Pontos de Interesse (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Pontos de Interesse, Aeroportos e cidades 3D no Microsoft Flight Simulator.

## Outros Recursos Úteis

- https://obsproject.com/ - Aplicativo de captura/transmissão de tela
- https://sqlitebrowser.org/ - Navegue pelos arquivos de banco de dados do logbook do Sky Dolly (*.sdlog), execute suas próprias consultas SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---