# Desensamblado de Juegos NES

Cada código fuente es igual al ROM original, compilable y editable.

Todos fueron hechos con mis scripts de [BZK 6502 Disassembler](https://github.com/cyneprepou4uk/BZK-6502-Disassembler).

Puedes contactarme en el tema de [RHDN](https://www.romhacking.net/forum/index.php?topic=32220.0).



## Cómo construir un desensamblado

### Windows

No se requieren requisitos especiales. Solo ejecuta `assemble.bat` y espera a que termine.

### Cualquier otro SO

Intenta usar `sh assemble.sh` en la terminal. Todos los créditos van para [gb-2312](https://github.com/gb-2312).

No elimines ni edites las carpetas `_scripts` y `_install_packages`, a menos que sepas cómo funcionan.



## Resaltado de sintaxis

Usa `syntax_6502.xml` para resaltar código en [Notepad++](https://notepad-plus-plus.org/).

Ve a Lenguaje -> Lenguaje definido por el usuario -> Define tu lenguaje -> Importar.



## Cómo editar un desensamblado

Los comentarios importantes están marcados con el texto `bzk`. Comienza eliminando basura para liberar espacio.

Y no te preocupes por cosas como `C - - - - - 0x00009C 00:C08C: A9 00     LDA #$00`.

El script `preparations.lua` se encargará de eso antes de la compilación. Solo escribe nuevo código como de costumbre, así: `LDA #$00`.

Puedes eliminar este texto manualmente con la expresión regular `.\s.\s.\s.\s.\s.\s0x0........:....:\s..\s..\s..\s\s` si es necesario.



## Lista de juegos (GoodNES) + CRC32

### Desensamblado
* Adventure Island (U) [!] `B78C09A2`
* Battle City (J) [!] `F599A07E`
* Bugs Bunny Crazy Castle, The (U) [!] `DB0C3656`
* Castlevania III - Dracula's Curse (U) [!] `7CC9C669`
* Contra Force (U) [!] `83D69922`
* Danny Sullivan's Indy Heat (U) [!] `311B5A58`
* Double Dragon II - The Revenge (J) `8CF69E4B`
* Dr. Mario (JU) (PRG0) [!] `B1F7E3E9`
* Excitebike (JU) [!] `2BB33C69`
* Felix the Cat (U) [!] `0639E88E`
* Ice Climber (J) [!] `80C41616`
* Kunio-kun no Nekketsu Soccer League (J) [!] `61C27F7B`
* Legend of Zelda, The (U) (PRG0) [!] `D7AE93DF`
* Little Mermaid, The (U) [!] `08EB97DB`
* Mappy (J) [!] `3F0E8E0A`
* Nuts & Milk (J) [!] `11879FE8`
* Pac-Man (J) (V1.1) [!] `D747B639`
* RoboCop 3 (U) [!] `FBBB58A6`
* Solstice - The Quest for the Staff of Demnos (U) [!] `1D60732E`
* Son Son (J) [!] `F7C8F42D`
* Street Fighter III (9 Fighter) (Unl) `22CDD2F6`
* Super C (U) [!] `1AC846F0`
* Tecmo World Cup Soccer (J) [!] `19F24980`
* Tennis (JU) [!] `5F457C00`
* Yie Ar Kung-Fu (J) (V1.4) [!] `0D526208`



### En progreso
* Battletoads & Double Dragon - The Ultimate Team (U) [!] `53B02F3D`
* Captain America and The Avengers (U) [!].nes `7254D53D`
* Galaga - Demons of Death (U) [!] `E36D5991`
* Ninja Gaiden III - The Ancient Ship of Doom (U) [!] `BABD39FA`
* R.C. Pro-Am II (U) [!] `03DB5562`
* River City Ransom (U) [!] `C3508F7E`
* Super Mario Bros. (W) [!] `3337EC46`
* Urban Champion (W) [!] `0770CDAA`



### Planificación
* Balloon Fight (J) [!] `A0DABE0A`
* Bubble Bobble (U) [!] `D3A91B41`
* Ghosts 'N Goblins (U) [!] `87ED54AA`
* Kid Icarus (UE) [!] `0B30E036`
* Kinnikuman - Muscle Tag Match (J) (PRG0) [!] `C296C8CE`
* Mighty Final Fight (U) [!] `15EB0BEE`
* Mitsume ga Tooru (J) [!] `E27EC1EC`
* Popeye (JU) (PRG0) [!] `DE1D762F`
* Tetris (Tengen) [!] `88F071C3`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---