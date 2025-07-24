
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Transforme seu runner do GitHub Actions em uma potência [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ eliminando implacavelmente softwares pré-instalados desnecessários.**

Os runners do GitHub Actions vêm com pouco espaço em disco para o Nix – apenas cerca de ~20GB.
*Nothing but Nix* **remove brutalmente** softwares desnecessários, fornecendo **65GB a 130GB** para sua Nix store! 💪

## Uso 🔧

Adicione esta action **antes** de instalar o Nix em seu workflow:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Requisitos ️✔️

- Suporta apenas runners oficiais do **Ubuntu** do GitHub Actions
- Deve ser executado **antes** que o Nix seja instalado

## O Problema: Abrindo Espaço para o Nix Prosperar 🌱

Os runners padrão do GitHub Actions estão cheios de *"bloatware"* que você nunca usará em um fluxo de trabalho Nix:

- 🌍 Navegadores web. Muitos deles. Tem que ter todos!
- 🐳 Imagens Docker consumindo gigabytes de espaço precioso em disco
- 💻 Runtimes de linguagens desnecessários (.NET, Ruby, PHP, Java...)
- 📦 Gerenciadores de pacotes juntando poeira digital
- 📚 Documentação que ninguém jamais lerá

Esse excesso deixa apenas ~20GB para seu repositório Nix - mal o suficiente para builds Nix sérios! 😞

## A Solução: Só Nix ️❄️

**Só Nix** adota uma abordagem radical nos runners do GitHub Actions e recupera espaço em disco de forma impiedosa usando um ataque em duas fases:

1. **Corte Inicial:** Cria instantaneamente um grande volume `/nix` (~65GB) reivindicando espaço livre de `/mnt`
2. **Ataque em Segundo Plano:** Enquanto seu fluxo de trabalho continua, eliminamos implacavelmente softwares desnecessários para expandir seu volume `/nix` para até ~130GB
   - Navegadores web? Não ⛔
   - Imagens Docker? Fora 🗑️
   - Runtimes de linguagem? Obliterados 💥
   - Gerenciadores de pacotes? Aniquilados 💣
   - Documentação? Vaporizada ️👻

A limpeza do sistema de arquivos é feita pelo `rmz` (do projeto [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - uma alternativa de alto desempenho ao `rm` que torna a recuperação de espaço extremamente rápida! ⚡
   - Supera o `rm` padrão em uma ordem de magnitude
   - Processa deleções em paralelo para máxima eficiência
   - **Recupera espaço em disco em segundos, não minutos!** ️⏱️

O resultado final? Um runner do GitHub Actions com **65GB a 130GB** de espaço pronto para Nix! 😁

### Crescimento Dinâmico do Volume

Diferente de outras soluções, o **Só Nix** aumenta seu volume `/nix` de forma dinâmica:

1. **Criação Inicial do Volume (1-10 segundos):** (*dependendo do Hatchet Protocol*)
   - Cria um dispositivo de loop a partir do espaço livre em `/mnt`
   - Configura um sistema de arquivos BTRFS em RAID0
   - Monta com compressão e ajuste de desempenho
   - Fornece 65GB em `/nix` imediatamente, mesmo antes do início da limpeza

2. **Expansão em Segundo Plano (30-180 segundos):** (*dependendo do Hatchet Protocol*)
   - Executa operações de limpeza
   - Monitora por espaço recém-liberado à medida que o excesso é eliminado
   - Adiciona dinamicamente um disco de expansão ao volume `/nix`
   - Rebalanceia o sistema de arquivos para incorporar o novo espaço

O volume `/nix` **cresce automaticamente durante a execução do workflow** 🎩🪄

### Escolha sua Arma: O Hatchet Protocol 🪓

Controle o nível de aniquilação 💥 com a entrada `hatchet-protocol`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Comparação de Protocolos ⚖️

| Protocolo | `/nix` | Descrição                                         | Purge apt  | Purge docker | Purge snap | Sistemas de arquivos eliminados     |
|-----------|--------|---------------------------------------------------|------------|--------------|------------|-------------------------------------|
| Holster   | ~65GB  | Mantenha o machado embainhado, use espaço do `/mnt` | Não        | Não          | Não        | Nenhum                              |
| Carve     | ~85GB  | Crie e combine espaço livre de `/` e `/mnt`       | Não        | Não          | Não        | Nenhum                              |
| Cleave    | ~115GB | Faça cortes poderosos e decisivos em pacotes grandes | Mínimo     | Sim          | Sim        | `/opt` e `/usr/local`               |
| Rampage   | ~130GB | Eliminação implacável e brutal de todo o excesso  | Agressivo  | Sim          | Sim        | Muahahaha! 🔥🌎                     |

Escolha com sabedoria:
- **Holster** quando você precisa que as ferramentas do runner permaneçam totalmente funcionais
- **Carve** para preservar as ferramentas do runner funcionais mas usar todo o espaço livre para o Nix
- **Cleave** (*padrão*) para um bom equilíbrio entre espaço e funcionalidade
- **Rampage** quando você precisa do máximo de espaço para Nix e não se importa com o que quebrar `#nix-is-life`

### Testemunhe a Carnificina 🩸

Por padrão, o processo de limpeza é executado silenciosamente em segundo plano enquanto seu fluxo de trabalho continua. Mas se quiser assistir ao massacre em tempo real:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Personalize Refúgios Seguros 🛡️

Controle quanto espaço reservar do avanço do Nix store com tamanhos personalizados de refúgio seguro:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Esses refúgios seguros definem quanto espaço (em MB) será misericordiosamente poupado durante a liberação de espaço:
- O `root-safe-haven` padrão é 2048MB (2GB)
- O `mnt-safe-haven` padrão é 1024MB (1GB)

Aumente esses valores se precisar de mais espaço livre em seus sistemas de arquivos ou diminua-os para não mostrar misericórdia! 😈

### Conceder Propriedade de Usuário ao /nix (Édito de Permissão do Nix) 🧑‍⚖️

Alguns instaladores ou configurações do Nix esperam que o diretório `/nix` seja gravável pelo usuário atual. Por padrão, o `/nix` pertence ao root. Se você precisar de propriedade de usuário (por exemplo, para certos scripts de instalação do Nix que não usam `sudo` para todas as operações dentro de `/nix`), você pode ativar o `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
Quando `nix-permission-edict` está definido como `true`, a ação executará `sudo chown -R "$(id --user)":"$(id --group)" /nix` após montar o `/nix`.

Agora vá e construa algo incrível com todo esse glorioso espaço da Nix store! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---