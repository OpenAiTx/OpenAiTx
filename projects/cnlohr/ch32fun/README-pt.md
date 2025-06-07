# ch32fun

Um ambiente de desenvolvimento open source (ferramentas, headers, exemplos) para o [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (e muitos outros chips da família CH32V) com gcc-riscv64, que pode ser usado no Windows (Nativo), Linux e/ou WSL. O CH32V003 é um componente de 10 centavos com um núcleo RISC-V EC que roda a 48MHz, possui 16kB de flash, 2kB de RAM e vários periféricos. Também está disponível nos pacotes SOP-8, QFN-20 e SOIC. Você pode obter o datasheet [aqui](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

O objetivo deste projeto é desenvolver as ferramentas e ambiente para uso eficiente do CH32V003. Evite HALs complicados e libere o potencial do hardware! O EVT existente é massivo, e o ambiente de desenvolvimento é pesado. Este projeto evita especificamente o HAL e permite que você use apenas o [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). Em contraste, o blinky ocupa apenas 500 bytes com o ch32fun, inicializa mais rápido e é significativamente mais simples no geral.

ch32fun contém:
1. Exemplos usando ch32fun, mas não tantos quanto usando o HAL. A maioria é centrada no ch32v003, mas muitos deles são compatíveis com outros processadores.
2. "minichlink" que utiliza o WCH CH-Link com libusb, para uso multiplataforma.
   * Um programador STM32F042, o [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Um programador ESP32S2, o [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * O programador oficial WCH Link-E.
   * Uma interface baseada em Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Suporta depuração no estilo gdbserver para uso com o Visual Studio.
   * Suporta printf por fio único. (A cerca de 400kBaud)
3. Uma cópia extra do libgcc para que você possa usar cadeias de build risc-v incomuns, localizada em `misc/libgcc.a`.
4. Uma pasta chamada "ch32fun" contendo um único arquivo fonte e um header auto-contido para compilar apps para o ch32v003.
5. Em alguns sistemas, habilidade de usar "printf" de volta através
6. Um bootloader de demonstração.

## Suporte à família

Atualmente, há suporte experimental para ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 e ch32v307. O GDB é mais testado no 003, mas funciona, em grau limitado, nos outros processadores.

## Primeiros Passos

Para instruções de instalação/configuração, veja a [página wiki aqui](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Recursos!

### Um debug "printf" rápido pela interface de programação.

E por rápido, quero dizer muito rápido. Tipicamente cerca de 36kBytes/s.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Você pode simplesmente testar o projeto debugprintf, ou chamar SetupDebugPrintf(); e usar printf() à vontade.

### Suporte à depuração!

Via gdbserver embutido no minichlink! Funciona com `gdb-multiarch` assim como no Visual Studio Code

## Compilando e Gravando

```
cd examples/blink
make
```

text = código, data = constantes e valores de inicialização, bss = valores não inicializados.  
dec é a soma dos 3 e reflete o número de bytes na flash que serão ocupados pelo programa.

O .bin gerado é usado pelo minichlink e o arquivo .hex é compatível com a ferramenta oficial de gravação WCH.

## VSCode +/- PlatformIO

Nota: O PlatformIO é geralmente usado para CI neste repositório. Embora o PlatformIO possa ser usado para codificar e depurar um projeto ch32fun dentro do VSCode, você também pode fazer isso completamente sem o PlatformIO: Para isso, veja o [projeto modelo](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Este projeto pode ser compilado, enviado e depurado com o VSCode e a extensão PlatformIO. Simplesmente clone e abra este projeto no VSCode e tenha a extensão PlatformIO instalada. Use o [seletor de ambiente de projeto](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) para selecionar um exemplo específico, como "blink".

Para criar um novo projeto de firmware PlatformIO baseado em ch32fun, basta usar o assistente "Novo Projeto" do [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) e definir "Framework" para "ch32v003fun". Existem [vários exemplos](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

O comando equivalente no [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) seria
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Se quiser adicionar seu código diretamente ao projeto ch32fun, por favor expanda os ambientes disponíveis no `platformio.ini` conforme [as instruções](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Por favor, note também que ao abrir este projeto dentro do PlatformIO, você pode usar o [seletor de ambiente de projeto](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) na barra de tarefas inferior do VSCode para selecionar uma pasta de exemplo específica. Caso contrário, "Build" irá, por padrão, compilar **todos** os exemplos.

Veja [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) para mais detalhes e instalação da plataforma.

## clangd

Se o servidor de linguagem C/C++ clangd não conseguir encontrar `ch32fun.h`, o exemplo precisará ser limpo com `make clean` e compilado uma vez com `bear -- make build`, que irá gerar um `compile_commands.json`, que o clangd usa para encontrar os caminhos de inclusão especificados nos makefiles.  
`make clangd` faz isso em um passo.
`build_all_clangd.sh` em `build scripts` faz isso para todos os exemplos.

## Referência Rápida
 * **OBRIGATÓRIO** para programação/depuração: `SWIO` está em `PD1`. Não reutilize PD1 para múltiplas funções.
 * **OPCIONAL** `NRST` está em `PD7`. Não é necessário, por padrão é GPIO em algumas configurações.
 * **OPCIONAL** UART `TX` está em: `PD5`. Recomendamos usar SWIO para debug com `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Mais exemplos / projetos?

Outras ferramentas de terceiros estão adicionando vários exemplos, etc. Veja os seguintes repositórios para bibliotecas extras, etc.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Suporte

Você pode abrir um ticket no github ou entrar no meu Discord no canal #ch32fun. Atualmente os convites são privados, então apenas me marque @cnlohr para um link de convite. Meu PM está aberto.

### Notas de rodapé/links

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Manual de Depuração
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Manual do Processador
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Manual de Referência Técnica
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Datasheet
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Detalhes para a ISA compactada deste chip.
 * O CH32V003 possui extensões xv, você pode usar esta versão personalizada do rvcodec.js para trabalhar com seus opcodes: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---