
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Dumps do PIC16/Xyclops do Xbox original e bancos de dados do IDA com alguma engenharia reversa realizada.

![Imagem do PIC16LC63A de um Xbox original](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Gravação do Xyclops (XycloMod)
Veja [o diretório Xyclops e o README](/Xyclops)

# Dumps
O arquivo .bin para cada dump de PIC tem os bytes invertidos para carregamento correto no IDA. Portanto, a primeira palavra da memória PIC é byte_0 + byte_1 << 8.

Os bancos de dados .idb do IDA possuem informações sobre variáveis e algumas observações no bloco de notas do banco de dados.

Veja esta página da wiki para uma análise das versões SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Dumpado de um Xbox DVT3. Mesma palavra de configuração que o P01. Também possui o ID do dispositivo gravado na área de configuração como 0000 0000 000B 002A, diferente dos PICs de produção.

Está completamente ausente o boot challenge.

## D01
Dumpado de um Xbox XDK BETA 2. Idêntico ao P01, exceto pela ausência do boot challenge. A função para calcular a resposta esperada ao boot challenge ainda está lá, mas nunca é chamada.

## DXF
Dumpado de um kit de depuração XDK D2. Muito semelhante ao D01, mas com lógica de bandeja, superaquecimento e boot ligeiramente diferentes. Boot challenge ausente da mesma forma que no D01.

## D2E
Dumpado de um kit de desenvolvimento Tuscany (v1.6). O chip Xyclops está marcado como X01202-001, e está ausente a linha A-A02 ou A-B01 que as unidades de varejo possuem.

O código serial de depuração em FC00 corresponde ao dump de varejo P2L. Existe um padrão estranho de dados de 0x4000 a 0xFBFF.

## P01
Dumpado de um Xbox v1.0. A palavra de configuração é 0x86:
- CP1:CP0 = 0 (Proteção de Código habilitada para toda a memória)
- BODEN = 0 (Reset por queda de tensão desabilitado)
- ~PWRTE = 0 (Timer de Inicialização habilitado)
- WDTE = 1 (Watchdog Timer habilitado)
- FOSC1:FOSC0 = 2 (Oscilador HS)

Um valor de configuração de 0x3FB6 é adequado para clones de SMC para que não tenham proteção de código habilitada.

## P11
Dumpado de um Xbox v1.3. Mesma palavra de configuração que o P01.

Há algumas pequenas alterações no P11 em relação ao P01, incluindo um comando SMBus extra (gravar 0x22), diferentes prioridades de LED e temporizações mais relaxadas para inicialização.

Verifiquei dumps embaralhados do v1.3 contra o v1.4 e eles coincidem. Isso significa que é altamente provável que tenham o mesmo programa.

## P2L
Extraído de um Xbox v1.6. Revisão Xyclops A-A02. Contém código Intel 8051, mas possui muitos registradores de função especial cuja função é desconhecida.

A serial de depuração é alimentada pelo código em FC00. Parece um depurador rudimentar que pode pausar a execução, despejar dados e escrever em registradores/RAM.

# Dumping do Xyclops

O chip Xyclops possui 3 pinos para 'depuração': TXD (pino 64), RXD (pino 63) e DEBUG (pino 29). Coloque o pino DEBUG em nível alto para habilitar a porta serial nos pinos TX e RX. A serial opera a 9600 baud.

O protocolo é baseado em comandos de 4 bytes que normalmente estão no formato `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

O comando 0x14 despeja 64 bytes de dados da BIOS por vez e o 0x15 despeja 64 bytes de dados do programa SMC por vez. Um dump do Xyclops, P2L.bin, está incluído no repositório. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) também está incluído para você fazer o dump da sua própria máquina.

# Metodologia de dumping do PIC
Relato completo em https://wiki.recessim.com/view/PIC_Burnout

O PIC tem a proteção de código habilitada, então todos os dados são lidos como 0000. Usei um truque para obter dados embaralhados de saída, descobri o algoritmo de embaralhamento usando um chip sacrificial, e depois usei um tipo de exploit para modificar os dados da ROM e corrigir alguns bits para valores conhecidos. Assim, posso extrair as informações necessárias dos múltiplos dumps embaralhados para reconstruir os dados originais.

# PICProgrammer
PICProgrammer é um dos vários projetos Arduino para o RP2040 que utilizei em minha pesquisa. Ele fornece uma interface simples de linha de comando para executar operações ICSP (programação serial em circuito) no PIC. Isso é preferido em relação ao uso de um programador dedicado como o PICkit devido à sua flexibilidade e à possibilidade de fazer coisas que o fabricante não pretendia.

Você deve ter um bom entendimento de eletrônica e programação antes de usar isso, e analisar cuidadosamente o que cada comando faz antes de executá-los.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---