## FanImeTsf

Este é o TSF do [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Aviso: atualmente, suporta apenas aplicativos de 64 bits.

## Como compilar

### Pré-requisitos

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Certifique-se de que o vcpkg e o gsudo estão instalados via **Scoop**.

## Etapas de compilação

### Compilar

Primeiro, clone o repositório,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Depois, prepare o ambiente,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Em seguida, compile,

```powershell
.\scripts\lcompile.ps1
```

### Instalar

Abra o powershell como administrador, certifique-se de que a opção `Enable sudo` do sistema está ativada.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Depois, crie uma pasta em `C:\Program Files\` chamada `FanImeTsf`, e copie o `FanImeTsf.dll` para ela,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Depois, instale,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Desinstalar

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Capturas de Tela

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Roteiro

Atualmente suporta apenas Xiaohe Shuangpin.

### Chinês

- Xiaohe Shuangpin
- Quanpin
- Códigos de ajuda no uso de componentes Hanzi
- Dicionário personalizável
- Motor IME personalizado
- Skins personalizadas
- Alternância entre chinês simplificado e tradicional
- Autocompletar em inglês
- API de IME em nuvem de código aberto
- Alternar a interface da janela de candidatos entre modo vertical e horizontal
- Interruptores de recursos: a maioria dos recursos deve ser livremente alternada ou personalizada pelos usuários

### Suporte ao Japonês

Talvez em outro projeto.

E talvez suporte a outros idiomas.

### Referências

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---