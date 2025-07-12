# 🎯 Guia de Configuração do Projeto

Bem-vindo ao projeto! Este guia irá ajudá-lo a começar rapidamente, instalando as ferramentas necessárias e configurando seu ambiente local.

---

## 🛠️ Pré-requisitos

Certifique-se de que as seguintes ferramentas estejam instaladas em seu sistema:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Versão recomendada do Anchor:** `0.30.1`

---

## ✅ Verificar Versões & Configurar

Verifique se tudo está devidamente instalado e configurado:

```bash
rustc --version             # Verificar versão do Rust
solana --version            # Verificar versão do Solana CLI
anchor --version            # Verificar versão do Anchor

solana config get           # Ver exibição da configuração atual do Solana
solana config set --url devnet  # Definir rede para devnet
```
---

## 🔐 Configuração da Carteira

Gere e gerencie as chaves da sua carteira:

```bash
solana-keygen new -o ./keys/admin.json     # Gerar um novo par de chaves
solana-keygen pubkey ./keys/admin.json     # Obter a chave pública
solana balance ./keys/admin.json           # Verificar o saldo da carteira
solana airdrop 5 SEU_ENDEREÇO_DA_CARTEIRA -u devnet   # Airdrop de 5 SOL para sua carteira
```

---

## 📦 Instalação do Projeto

Clone o projeto e instale as dependências:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Início Rápido

### 🏗️ Compile o Programa

Compile o contrato inteligente Anchor:

```bash
# Compile o programa Anchor usando a ferramenta nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Sincronize todas as chaves públicas do programa
anchor keys sync

# Recompile se o endereço do programa em lib.rs tiver mudado
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Testar na Devnet

Garanta que seu `Anchor.toml` use a Devnet:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Implantar o Programa

```bash
anchor deploy
```

---

## 🧪 Usar o CLI para Interagir com o Programa
Use estes scripts CLI para interagir com seu contrato inteligente localmente.

---

### 🔹 Inicializar o Programa

```bash
yarn script config
```

Inicializa a configuração do contrato.

---

### 🔹 Criar uma Rodada

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Exemplo:
yarn script create -t 60 -d 100000000 -j 100
```

**Parâmetros:**

- `<ROUND_TIME>`: Duração da rodada em segundos (ex.: `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>`: Depósito mínimo em lamports (1 SOL = 1_000_000_000). Deve ser maior que `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>`: Número máximo de participantes. Deve ser menor que `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Entrar em uma Rodada

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Exemplo:
yarn script join -a 100000000 -g 2
```
**Parâmetros:**

- `<DEPOSIT_SOL_AMOUNT>`: Quantia do depósito em lamports (ex.: 0,1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: Índice da rodada a ser ingressada. Começa em `0`. Deve ser menor que `total_round`.

> 🕒 Nota: A contagem regressiva para a rodada começa quando o segundo participante entra.

---

### 🔹 Selecionar Vencedor

```bash
yarn script winner -g <ROUND_NUMBER>

# Exemplo:
yarn script winner -g 2
```

**Nota:** Só chame este comando após o tempo total da rodada ter se esgotado.

---
### 🔹 Reivindicar Ganhos

```bash
yarn script claim -g <ROUND_NUMBER>

# Exemplo:
yarn script claim -g 2
```

**Nota:** Isso deve ser executado pela carteira vencedora após o vencedor ter sido selecionado.

---

## Contato

Para dúvidas ou perguntas sobre desenvolvimento de smart contracts na Solana, implementação de DeFi ou integração com DEX, entre em contato com os mantenedores do projeto.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---