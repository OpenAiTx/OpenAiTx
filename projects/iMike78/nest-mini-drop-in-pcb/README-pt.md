
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

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) é uma substituição drop-in da PCB para o ["Google Nest Mini" (o alto-falante inteligente de segunda geração do Google com porta de carregamento tipo barril)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), mas baseada nos microcontroladores ESP32 e XMOS para rodar firmware de código aberto.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Dica! Se você está procurando uma substituição semelhante de PCB para o "Google Home Mini" (hardware do alto-falante inteligente de primeira geração do Google com porta de carregamento Micro-USB), confira o projeto irmão em https://github.com/iMike78/home-mini-v1-drop-in-pcb

Ambos são projetos de hardware totalmente open-source, que tomam inspiração conceitual do [Onju Voice](https://github.com/justLV/onju-voice), porém com o objetivo de seguir o [padrão de assistentes de voz aberto da Open Home Foundation, tendo como referência o Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) para os desenhos e especificações da PCB.

# Escopo do projeto

O objetivo deste projeto e repositório (similar ao [Onju Voice](https://github.com/justLV/onju-voice), mas sob uma licença de hardware totalmente open-source) é projetar uma PCB (Placa de Circuito Impresso) de substituição direta com esquemáticos de hardware que qualquer um pode fabricar/montar ou encomendar de um fabricante de PCB como uma substituição personalizada para o Google Nest Mini (2ª Geração).

O foco principal é pessoas que desejam converter/reutilizar seus antigos alto-falantes inteligentes Google Nest Mini em hardware open-source para [Controle de Voz do Home Assistant](https://www.home-assistant.io/voice_control/) e/ou saída de alto-falante para [Music Assistant](https://www.music-assistant.io), (o hardware pode provavelmente ser usado também para outras aplicações com outros firmwares, já que é baseado na popular plataforma Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

O design de hardware irá (similar ao [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) integrar um ESP32-S3 SoC para WiFi, BLE, e [detecção de palavra-chave embarcada](https://www.home-assistant.io/voice_control/about_wake_word/) (usando firmware [ESPHome sem código](https://esphome.io/)) + um chip XMOS xCORE XU316 para processamento avançado de áudio (com firmware customizado para limpeza de microfone, aprimorando o reconhecimento de voz utilizando algoritmos locais para Supressão de Ruído, Cancelamento de Eco Acústico, Cancelamento de Interferência e Controle Automático de Ganho).

Em funcionalidade, foi feito para ser majoritariamente compatível em hardware com o [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) design de referência (que foi lançado como hardware open-source pela Open Home Foundation em colaboração com a Nabu Casa). A principal diferença será devido às limitações definidas pelo gabinete e componentes do Google Nest Mini, (ou seja, o hardware do projeto nest-mini-drop-in-pcb estará limitado pelo mesmo tipo de capacidade física de entradas do hardware original da Google).

Dessa forma, o escopo deste projeto/repositório não é desenvolver novos recursos/funções para o firmware ESPHome, então, caso queira isso, deve recorrer ao desenvolvimento do firmware do Home Assistant Voice Preview Edition, assim como ao código principal do ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Pedido de colaboração

Se você tem experiência em design de layout de PCB, (especialmente em roteamento de PCB, preenchimento de terra ou layouts digitais+analógicos sensíveis a ruído), **sua ajuda é muito apreciada**! Sinta-se à vontade para abrir uma nova issue, enviar sugestões/requisições, adicionar opiniões/feedback a issues existentes ou fazer fork deste repositório.

Para mais informações sobre o conceito/ideia, veja e contribua na discussão relacionada neste tópico do fórum da comunidade Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Status atual

- ✅ Esquemático concluído
- ✅ Posicionamento de componentes finalizado
- ✅ Roteamento concluído
- ✅ Preenchimento de terra, estratégia de blindagem e considerações de EMI finalizados
- ⚠️ 1º lote de teste falhou em dois erros - corrigidos
- 🕓 aguardando o 2º lote de teste

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Ferramentas utilizadas

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC para obtenção de footprints

## Especificações conhecidas do hardware

- PCB de 4 camadas
- Chip ESP32-S3R8 (ESP32-S3 para WiFi, BLE e detecção de palavra-chave embarcada)
- XMOS XU316-1024-QF60B-C32 (DSP de áudio XMOS XU316 xCORE)
- Flash SPI dupla
- Barramentos I²S duplos (para permitir interfaces I2S simultâneas, ou seja, saída e entrada de áudio ao mesmo tempo)
- MAX98357 para saída de alto-falante (Amplificador Mono Classe-D I2S)
- 2x microfones MEMS (MSM261DHP)
- LEDs SK6812
- Entrada personalizada USB-C e alimentação de 14V

---

> ⚠️ A gravação via USB-C requer a desconexão da entrada principal de alimentação de 14V. Veja a nota na serigrafia da PCB para detalhes.

## Referências

### Recursos da Home Assistant Voice Preview Edition incluindo arquivos de design da PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome para Home Assistant Voice PE (que também utiliza a mesma combinação ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### MCU IC chip XMOS xCORE DSP (XU316-1024-QF60B-C32)

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

Este projeto está licenciado sob a [Licença de Hardware Aberto CERN Versão 2 - Fortemente Recíproca (CERN-OHL-S v2)]
Qualquer versão modificada deste hardware também deve ser distribuída sob a mesma licença.

☕ Se você quiser apoiar este projeto, sinta-se à vontade para [me pagar um café no Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---