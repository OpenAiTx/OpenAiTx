
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# MiciMike substituição drop-in da PCB para Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) é uma substituição drop-in da placa PCB para o ["Google Nest Mini" (a segunda geração do alto-falante inteligente da Google com conector de carregamento tipo barril)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), mas baseada em microcontroladores ESP32 e XMOS para execução de firmware de código aberto.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Dica! Se você está procurando uma substituição drop-in semelhante da PCB para o "Google Home Mini" (primeira geração do alto-falante inteligente da Google com porta de carregamento Micro-USB), confira o projeto irmão em https://github.com/iMike78/home-mini-v1-drop-in-pcb

Ambos são projetos totalmente de hardware open-source, inspirando-se em alguns conceitos do [Onju Voice](https://github.com/justLV/onju-voice), mas buscando seguir o [padrão de assistentes de voz abertos da Open Home Foundation com o Home Assistant Voice Preview Edition como referência](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para desenhos e especificações de PCB.

# Escopo do projeto

O objetivo deste projeto e repositório (semelhante ao [Onju Voice](https://github.com/justLV/onju-voice), mas sob uma licença totalmente open-source de hardware) é projetar uma PCB (Placa de Circuito Impresso) de substituição direta com esquemáticos de hardware que qualquer pessoa pode fabricar/montar ou encomendar de um fabricante de PCB como uma substituição personalizada para o Google Nest Mini (2ª geração).

O foco principal são pessoas que desejam converter/reutilizar seus antigos alto-falantes inteligentes Google Nest Mini em hardware open-source para [Controle de Voz do Home Assistant](https://www.home-assistant.io/voice_control/) e/ou saída de alto-falante para [Music Assistant](https://www.music-assistant.io), (o hardware, no entanto, pode provavelmente ser usado com outros aplicativos também com outros firmwares, pois é baseado na popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

O projeto de hardware irá (similar ao [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrar um ESP32-S3 SoC para WiFi, BLE e [detecção de palavra-chave embarcada](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware sem código [ESPHome](https://esphome.io/)) + um chip XMOS xCORE XU316 para processamento avançado de áudio (com firmware personalizado para limpeza de microfone, melhorando capacidades de reconhecimento de voz ao utilizar algoritmos locais para Supressão de Ruído, Cancelamento de Eco Acústico, Cancelamento de Interferência e Controle Automático de Ganho).

Em termos de funcionalidade, foi feito para ser principalmente compatível em hardware com o [Home Assistant Voice Preview Edition (também conhecido como Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) design de referência (que foi lançado como hardware open-source pela Open Home Foundation em colaboração com a Nabu Casa). A principal diferença será devido às restrições definidas pelo gabinete e componentes do Google Nest Mini, (ou seja, o projeto nest-mini-drop-in-pcb terá limitações pelos mesmos tipos de entradas de capacidade física do hardware original do Google).

Assim, o escopo deste projeto/repositório não é desenvolver novos recursos/funções para o firmware ESPHome; caso deseje isso, deve buscar o desenvolvimento de firmware do Home Assistant Voice Preview Edition e também o código principal do ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Pedido de colaboração

Se você possui experiência com layout de PCB, (especialmente com roteamento, preenchimento de terra ou layouts digitais+analógicos sensíveis a ruído), **sua ajuda é muito apreciada**! Sinta-se livre para abrir uma nova issue, enviar sugestões/solicitações, adicionar comentários/feedback em issues existentes ou fazer fork deste repositório.

Para mais informações sobre o conceito/ideia, veja e contribua na discussão relacionada também neste tópico do fórum da comunidade Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Status atual

- ✅ Esquemático concluído
- ✅ Posicionamento de componentes feito
- ✅ Roteamento feito
- ✅ Preenchimento de terra, estratégia de blindagem e considerações de EMI feitos
- ⚠️ 1º lote de teste falhou em dois erros - corrigido
- 🕓 aguardando o 2º lote de teste

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Ferramentas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtenção de footprints

## Especificações conhecidas do hardware

- PCB de 4 camadas
- Chip nu ESP32-S3R8 (ESP32-S3 para Wi-Fi, BLE e detecção de palavra-chave embarcada)
- XMOS XU316-1024-QF60B-C24 (processamento de áudio DSP xCORE XMOS XU316)
- Flash SPI dupla (pois ESP32 e XMOS possuem seus próprios flashes SPI)
- Barramentos I²S duplos (para permitir interfaces I2S ao mesmo tempo, ou seja, saída e entrada de áudio simultâneas)
- MAX98357 para saída de alto-falante (Amplificador de Áudio Mono Classe-D I2S)
- 2x microfones MEMS (duplo MMICT390200012 com espaçamento entre microfones de 68 mm)
- 6x LEDs RGB SK6812
- Entrada personalizada USB-C e 14V (Atenção! USB-C e conector barril não podem ser conectados ao mesmo tempo)

---

> ⚠️ Gravação via USB-C requer o desligamento da entrada principal de energia de 14V. Veja a observação na serigrafia da PCB para mais detalhes.

## Referências

### Recursos da Home Assistant Voice Preview Edition incluindo arquivos de design de PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que também utiliza a mesma combinação ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Chip IC MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS do projeto ESPHome para o hardware Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Licença

Este projeto está licenciado sob a [Licença CERN Open Hardware Versão 2 - Fortemente Recíproca (CERN-OHL-S v2)]
Qualquer versão modificada deste hardware também deve ser distribuída sob a mesma licença.

☕ Se você quiser apoiar este projeto, sinta-se à vontade para [me pagar um café no Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---