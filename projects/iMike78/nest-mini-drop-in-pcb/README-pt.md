
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

**Atenção!** A próxima campanha de crowdfunding para o "MiciMike Home Mini Drop-In PCB" (1ª geração do Google Home Mini) já está listada na fase de pré-lançamento do Crowd Supply (apenas pré-visualização do projeto), e se for bem-sucedida, haverá uma campanha correspondente para o Nest Mini. Confira aqui:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ambos são projetos de hardware totalmente open-source, inspirados conceitualmente no [Onju Voice](https://github.com/justLV/onju-voice), mas com o objetivo de seguir o [padrão de assistentes de voz abertos da Open Home Foundation com referência na Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para designs e especificações de PCB.

# Escopo do projeto

O objetivo deste projeto e repositório (semelhante ao [Onju Voice](https://github.com/justLV/onju-voice), mas sob uma licença de hardware totalmente open-source) é projetar uma PCB (Placa de Circuito Impresso) substituta com esquemáticos de hardware que qualquer pessoa possa fabricar ou encomendar de um fabricante de PCB como uma substituição personalizada para o Google Nest Mini (2ª Geração).

O público-alvo são pessoas interessadas em converter/reaproveitar seus antigos alto-falantes inteligentes Google Nest Mini em hardware open-source para [Controle de Voz do Home Assistant](https://www.home-assistant.io/voice_control/) e/ou saída de áudio para [Music Assistant](https://www.music-assistant.io), (o hardware provavelmente também pode ser usado com outras aplicações e firmwares, já que é baseado na popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

O design de hardware integrará (de forma semelhante à [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) um SoC ESP32-S3 para WiFi, BLE e [detecção de palavra de ativação onboard](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome sem código](https://esphome.io/)) + um chip XMOS xCORE XU316 para processamento avançado de áudio (com firmware personalizado para limpeza do microfone, melhorando o reconhecimento de voz com algoritmos locais para Supressão de Ruído, Cancelamento de Eco Acústico, Cancelamento de Interferência e Controle Automático de Ganho).

Em termos de funcionalidade, é feito para ser compatível principalmente com o hardware de referência [Home Assistant Voice Preview Edition (também conhecido como Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que foi lançado como design de hardware open-source pela Open Home Foundation em colaboração com Nabu Casa). A principal diferença será devido às limitações definidas pelo gabinete e componentes do Google Nest Mini, (ou seja, o projeto nest-mini-drop-in-pcb terá o hardware limitado pela mesma capacidade física de entradas do hardware original da Google).

Assim, o escopo deste projeto/repositório não é desenvolver novas funções/recursos para o firmware ESPHome; caso queira isso, deve contribuir com o desenvolvimento do firmware da Home Assistant Voice Preview Edition e com o código principal do ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Pedido de colaboração

Se você tem experiência com layout de PCB, (especialmente com roteamento, preenchimento de terra ou layouts digitais+analógicos sensíveis ao ruído), **sua ajuda é muito apreciada**! Sinta-se à vontade para abrir uma nova issue, enviar sugestões/requisições e dar feedback em issues existentes, ou fazer um fork deste repositório.

Para mais informações sobre o conceito/ideia, veja e contribua também na discussão relacionada neste tópico do fórum da comunidade Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Status atual

- ✅ Esquemático concluído
- ✅ Posicionamento de componentes feito
- ✅ Roteamento feito
- ✅ Preenchimento de terra, estratégia de blindagem e considerações de EMI concluídas
- ⚠️ Primeiro lote de testes falhou em dois erros - corrigidos
- 🕓 aguardando o 2º lote de testes

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Ferramentas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtenção de footprints

## Especificações conhecidas do hardware

- PCB de 4 camadas
- Chip nu ESP32-S3R8 (ESP32-S3 para WiFi, BLE e detecção de palavra-chave embarcada)
- XMOS XU316-1024-QF60B-C24 (Processador de áudio DSP XMOS XU316 xCORE)
- Flash SPI dupla (ESP32 e XMOS possuem suas próprias memórias SPI flash)
- Barramentos I²S duplos (para permitir interfaces I2S ao mesmo tempo, ou seja, saída e entrada de áudio simultâneas)
- TAS5805M (TAS5805MPWPR) para saída do alto-falante (Amplificador de Áudio Mono Classe D I2S com configuração DSP via I2C)
- 2x microfones MEMS (duplo MMICT390200012 com espaçamento de 68mm entre microfones)
- 6x LEDs RGB SK6812
- USB-C personalizado e entrada de alimentação 14V (Atenção! USB-C e conector DC não podem ser conectados ao mesmo tempo)

---

> ⚠️ Gravação via USB-C requer desconectar a alimentação principal de 14V. Veja a observação na serigrafia da PCB para detalhes.

## Referências

### Recursos da Home Assistant Voice Preview Edition incluindo arquivos de design da PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que também usa a mesma combinação ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Chip MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

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

Este projeto está licenciado sob a [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Qualquer versão modificada deste hardware também deve ser distribuída sob a mesma licença.

☕ Se quiser apoiar este projeto, fique à vontade para [me pagar um café no Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---