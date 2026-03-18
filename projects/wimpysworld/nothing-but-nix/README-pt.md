
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

# Nada além de Nix

**Transforme seu runner do GitHub Actions em uma potência [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ ao eliminar impiedosamente o excesso pré-instalado.**

Os runners do GitHub Actions vêm com um espaço em disco escasso para o Nix – apenas ~20GB.
*Nada além de Nix* **elimina brutalmente** softwares desnecessários, oferecendo **65GB a 130GB** para sua loja Nix! 💪

## Uso 🔧

Adicione esta ação **antes** de instalar o Nix em seu fluxo de trabalho:

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

- Suporta apenas runners oficiais do **Ubuntu** para GitHub Actions
- Deve ser executado **antes** do Nix ser instalado
- **Runners macOS/Darwin**: Esta ação será ignorada graciosamente com um aviso se executada em macOS. Os runners macOS já oferecem espaço suficiente para o Nix e não requerem esta ação
- **Runners Windows**: Esta ação será ignorada graciosamente com um aviso se executada em Windows. Os runners Windows possuem layouts e restrições de sistema de arquivos diferentes

## O Problema: Criando Espaço para o Nix Prosperar 🌱

Os runners padrão do GitHub Actions estão cheios de *"bloatware"* que você nunca usará em um fluxo de trabalho Nix:

- 🌍 Navegadores web. Vários deles. Tem que ter todos!
- 🐳 Imagens Docker consumindo gigabytes de espaço valioso em disco
- 💻 Runtimes de linguagens desnecessários (.NET, Ruby, PHP, Java...)
- 📦 Gerenciadores de pacotes acumulando poeira digital
- 📚 Documentação que ninguém jamais lerá

Esse excesso deixa apenas ~20GB para seu repositório Nix - mal o suficiente para builds Nix sérios! 😞

## A Solução: Só o Nix ️❄️

**Só o Nix** adota uma abordagem radical nos runners do GitHub Actions e recupera espaço no disco de forma impiedosa usando um ataque em duas fases:

1. **Corte Inicial:** Cria instantaneamente um grande volume `/nix` (~65GB) reivindicando espaço livre de `/mnt`
2. **Devastação em Segundo Plano:** Enquanto seu fluxo de trabalho continua, eliminamos sem piedade softwares desnecessários para expandir seu volume `/nix` até ~130GB
   - Navegadores web? Não ⛔
   - Imagens Docker? Foram 🗑️
   - Runtimes de linguagens? Obliterados 💥
   - Gerenciadores de pacotes? Aniquilados 💣
   - Documentação? Vaporizada ️👻

A limpeza do sistema de arquivos é feita pelo `rmz` (do projeto [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - uma alternativa de alta performance ao `rm` que torna a liberação de espaço incrivelmente rápida! ⚡
   - Supera o `rm` padrão em uma ordem de magnitude
   - Deleções processadas em paralelo para máxima eficiência
   - **Recupera espaço em disco em segundos, não minutos!** ️⏱️

O resultado final? Um runner do GitHub Actions com **65GB a 130GB** de espaço pronto para o Nix! 😁

### Crescimento Dinâmico do Volume

Ao contrário de outras soluções, o **Nothing but Nix** expande seu volume `/nix` dinamicamente:

1. **Criação Inicial do Volume (1-10 segundos):** (*dependendo do Protocolo Hatchet*)
   - Cria um dispositivo de loop a partir do espaço livre em `/mnt`
   - Configura um sistema de arquivos BTRFS em RAID0
   - Monta com compressão e otimização de desempenho
   - Disponibiliza um `/nix` de 65GB imediatamente, mesmo antes do início da limpeza

2. **Expansão em Segundo Plano (30-180 segundos):** (*dependendo do Protocolo Hatchet*)
   - Executa operações de limpeza
   - Monitora o espaço recém-liberado conforme o excesso é eliminado
   - Adiciona dinamicamente um disco de expansão ao volume `/nix`
   - Rebalanceia o sistema de arquivos para incorporar o novo espaço

O volume `/nix` **cresce automaticamente durante a execução do fluxo de trabalho** 🎩🪄

### Escolha Sua Arma: O Protocolo Hatchet 🪓

Controle o nível de aniquilação 💥 com o parâmetro `hatchet-protocol`:

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

Quando `nix-permission-edict` está definido como `true`, a ação executará `sudo chown -R "$(id --user)":"$(id --group)" /nix` após montar `/nix`.

### Configurar o Nix para usar /nix/build

Esta ação cria `/nix/build` para que as compilações de derivações do Nix utilizem o espaço recuperado. Adicione `build-dir` à sua configuração do Nix:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Ou com DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
Isso instrui o Nix a realizar compilações no grande volume BTRFS ao invés do diretório temporário padrão do sistema.

## Solução de Problemas 🔍

### "No space left on device" durante grandes compilações

Se sua compilação ficar sem espaço mesmo usando apenas Nix, provavelmente é porque a purga em segundo plano não foi concluída antes que sua compilação consumisse o espaço disponível. Isso afeta comumente:

- Testes de VM do NixOS que montam grandes imagens de disco
- Compilações com muitas dependências que não estão em cache
- Toolchains Rust e outras grandes compilações

**Solução:** Use `witness-carnage: true` para forçar a purga síncrona. Isso garante que todo o espaço seja recuperado *antes* do início da sua compilação:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Isso adiciona de 30 a 180 segundos à configuração do seu fluxo de trabalho, mas garante que o máximo de espaço esteja disponível quando sua construção começar.

Agora vá construir algo incrível com todo esse espaço glorioso do Nix store! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---