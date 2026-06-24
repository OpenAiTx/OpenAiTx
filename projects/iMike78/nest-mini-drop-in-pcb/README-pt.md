
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
**Atenção!** Atualmente está em andamento uma campanha de financiamento coletivo para o "MiciMike Home Mini Drop-In PCB" (Google Home Mini de 1ª geração) que está ao vivo no Crowd Supply em fase de pré-venda (apenas pré-visualização do projeto), e se for bem-sucedida haverá uma campanha correspondente para o Nest Mini mais recente (2ª geração). Confira aqui e apoie este projeto indiretamente apoiando-o se puder:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Ambos são projetos de hardware totalmente open-source, inspirados conceitualmente pelo [Onju Voice](https://github.com/justLV/onju-voice), mas com o objetivo de seguir o [padrão de assistentes de voz open-source da Open Home Foundation, tendo a Home Assistant Voice Preview Edition como referência](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para os projetos e especificações de PCB.

# Escopo do projeto

O objetivo deste projeto e repositório (semelhante ao [Onju Voice](https://github.com/justLV/onju-voice), mas sob uma licença de hardware totalmente open-source) é projetar uma placa de circuito impresso (PCB) substituta drop-in com esquemáticos de hardware que qualquer pessoa possa fabricar/montar ou encomendar de um fabricante de PCB como substituição personalizada para o Google Nest Mini (2ª geração).

Este projeto é direcionado principalmente a pessoas que desejam converter/reaproveitar seus antigos alto-falantes inteligentes Google Nest Mini em hardware open-source para [Controle de Voz no Home Assistant](https://www.home-assistant.io/voice_control/) e/ou saída de alto-falante para [Music Assistant](https://www.music-assistant.io), (o hardware, porém, provavelmente pode ser usado com outras aplicações e firmwares, já que é baseado na popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="Primeiro teste de PCB">

O projeto de hardware irá (semelhante ao [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrar um ESP32-S3 SoC para WiFi, BLE e [detecção de palavra-chave embarcada](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware no-code [ESPHome](https://esphome.io/)) + um chip XMOS xCORE XU316 para processamento avançado de áudio (com firmware customizado para limpeza de microfone, aumentando as capacidades de reconhecimento de voz ao usar algoritmos locais para Supressão de Ruído, Cancelamento de Eco Acústico, Cancelamento de Interferência e Controle Automático de Ganho).

Em termos de funcionalidade, ele é projetado para ser compatível principalmente com o hardware de referência [Home Assistant Voice Preview Edition (também chamado de Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (que foi lançado como projeto de hardware open-source pela Open Home Foundation em colaboração com a Nabu Casa). A principal diferença será devido às limitações impostas pela carcaça e componentes do Google Nest Mini, (ou seja, o projeto nest-mini-drop-in-pcb estará limitado pela mesma capacidade física de entradas do hardware original do Google).

Assim, o escopo deste projeto/repositório não é desenvolver novas funções/recursos para o firmware ESPHome; se deseja isso, deve contribuir com o desenvolvimento de firmware da Home Assistant Voice Preview Edition e com o código principal do ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Solicitação de colaboração

Se você tem experiência com projeto de layout de PCB, (e especialmente com roteamento, ground pour ou layouts digitais+analógicos sensíveis a ruído), **sua ajuda é muito apreciada**! Sinta-se à vontade para abrir uma nova issue, enviar sugestões/requisições, adicionar comentários/feedback em issues existentes ou fazer um fork deste repositório.

Para mais informações sobre o conceito/ideia, veja e contribua na discussão relacionada neste tópico do fórum da comunidade Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Status atual

- ✅ Esquemático concluído
- ✅ Colocação de componentes feita
- ✅ Roteamento concluído
- ✅ Ground pour, estratégia de blindagem e considerações de EMI concluídas
- ⛔ Primeiro lote de teste falhou em dois erros - corrigidos

- ⚠️ 2º lote de testes funcionando parcialmente
- ✅ Opção de depuração XTAG4 adicionada para o próximo lote

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Ferramentas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtenção de footprints

## Especificações conhecidas de hardware

- PCB de 4 camadas
- Chip nu ESP32-S3R8 (ESP32-S3 para WiFi, BLE e detecção de palavra-chave integrada)
- XMOS XU316-1024-QF60B-C24 (processamento de áudio DSP xCORE XMOS XU316)
- 16 MB SPI flash (ESP32-S3)
- 4 MB SPI flash (XMOS XU316)
- Barramentos I²S duplos (entrada e saída de áudio simultâneas)
- TAS5805M (TAS5805MPWPR) amplificador estéreo Classe-D com DSP integrado (áudio I2S, controle I2C), configurado para saída mono BTL para alto-falante
- 3x microfones MEMS (MMICT390200012) dispostos em um arco de raio de 34 mm – firmware atual usa 2 microfones, suporte de hardware para matriz de 3 microfones já presente
- 6x LEDs RGB SK6812
- Entrada personalizada USB-C e 14V (Atenção! USB-C e conector barril não podem ser conectados ao mesmo tempo)
- Controlador de toque capacitivo MPR121 (usado para entrada de toque em vez do sensor de toque nativo do ESP32-S3)

---

> ⚠️ Gravação via USB-C requer o desligamento da entrada principal de 14V. Veja a observação na serigrafia da PCB para detalhes.

## Referências

### Recursos do Home Assistant Voice Preview Edition incluindo arquivos de projeto da PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/pt-br/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que também usa a mesma combinação ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) CI MCU

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

☕ Se você quiser apoiar este projeto, fique à vontade para [me pagar um café no Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---