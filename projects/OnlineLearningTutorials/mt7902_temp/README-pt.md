<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 Driver MT7902 como Subparte do Driver MT7921 (✅ Funcionando)
Chip Mediatek mt7902 wifi 6E Suporte a Bluetooth e WiFi

> [!IMPORTANTE]
> Kernel Linux 7.1 Suporta Oficialmente o chip MT7902 WIFI 6E


## 📁 Clonando o repositório

Clone o repositório para o seu PC local
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Se você não quiser clonar o histórico anterior, então
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Instalação


### 🚀 Script de Guia de Instalação (Recomendado para Sistema Baseado em Ubuntu)
Torne o script executável se ainda não estiver
```
chmod +x ./install_guide.sh
```
Agora execute este script
```
./install_guide.sh
```
Ele solicitará automaticamente a senha quando necessário
* Este script irá pedir para você instalar o firmware, driver bluetooth e wifi um por um
* Testado no Ubuntu com kernel linux 7.0

### 🚀 Correção Automática Fácil (Recomendado para Sistemas Baseados em Arch)
Se você deseja corrigir rapidamente seu WiFi e Bluetooth em qualquer kernel moderno, siga estes passos:

Torne o script executável caso ainda não seja
```
chmod +x ./fix_my_wifi.sh
```

**Execute o script de correção automática** com sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 O que este script faz:
* **Verifica dependências:** Garante que você tenha `gcc`/`clang`, `make`, `bc` e os `kernel-headers` atuais instalados. Caso não tenha, instala com seu gerenciador de pacotes preferido.
* **Compila Drivers:** Compila automaticamente os drivers de WiFi e Bluetooth para a exata versão do seu kernel.
* **Correção Persistente:** Instala um serviço do sistema que garante que seu WiFi permaneça ativo mesmo após reiniciar o computador.
* **Segurança:** Instala módulos em um diretório personalizado (`/lib/modules/mt7902_custom`) para evitar alterar arquivos padrão do sistema.

> [!NOTE]
> Você precisará de uma conexão com a internet (via Ethernet ou compartilhamento USB do seu celular) na primeira vez que executar para baixar as ferramentas de compilação necessárias. (Como compilador, linux-headers, etc)


## ✅ Testado em (Funcionando Verificado)
Esta correção foi verificada e confirmada funcionando em:

* **Marca:** ASUS
* **Modelo:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Versão do Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **SO:** Arch, Ubuntu
* **Gerenciador de Pacotes:** pacman, apt

## Disponível para:
* **SO:** Qualquer sistema operacional que suporte um dos PMs
* **Gerenciadores de pacotes preferidos:** apt, pacman, dnf, zypper, nix-shell
* **Versões do Kernel:** 6.14-7.0.7


## 🔧 Firmwares utilizados
Firmwares estão armazenados na pasta `firmware`.


## 📱 Bluetooth ✅ (Funcionando)
> [!WARNING]
> Se o driver bluetooth entrar em conflito com `gen4-mt7902`, remova o firmware bluetooth para que não interfira com este driver
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Este projeto utiliza o firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Para ativar o bluetooth, acesse o diretório da sua versão atual do kernel. ``
Por exemplo, se você possui o kernel linux-6.16, acesse o diretório `./linux-6.16/drivers/bluetooth` .
Abra o terminal neste diretório e compile com o comando `make`.
Dois módulos do kernel são compilados: `btusb.ko` e `btmtk.ko`.
Para habilitar o bluetooth no seu dispositivo, remova o btusb e btmtk do seu sistema e instale esses dois arquivos, use os comandos
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Agora verifique se o seu bluetooth está funcionando agora.

## 💻 WiFi ✅ (Funcionando)
> [!IMPORTANTE]
> Um repositório funcional com algumas limitações está [aqui](https://github.com/hmtheboy154/gen4-mt7902)

O driver WiFi para o mt7902, recentemente lançado pela mediatek, está dentro da pasta `latest`.

Se você estiver usando Ubuntu, basta ir até a pasta `latest` e executar o seguinte comando no terminal.
```
make
```

Ele irá compilar todos os módulos, comprimi-los e instalá-los (substituir o módulo do kernel original pelo módulo modificado). Se você estiver usando outra distribuição ou não quiser todos os passos e apenas deseja compilar o código, então execute no terminal
```
make module_compile
```
Para comprimir o módulo que você compilou, depois execute no terminal
```
make module_compress
```
Para instalar o módulo compactado no módulo do kernel do sistema, execute no terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---