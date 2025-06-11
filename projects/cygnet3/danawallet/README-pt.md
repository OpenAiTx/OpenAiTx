# Dana wallet

Dana é um aplicativo Flutter usado para aceitar doações em bitcoin. Ele utiliza pagamentos silenciosos, um novo protocolo de pagamentos estáticos, para receber doações enquanto preserva a privacidade on-chain.

## Experimente o Dana wallet

**O Dana wallet ainda está em fase experimental. Recomendamos usar a testnet/signet. Se você realmente quiser testar a carteira na mainnet, use apenas fundos que esteja disposto a perder. Não nos responsabilizamos por fundos perdidos.**

Estamos avaliando lançar o Dana wallet nas lojas de aplicativos populares assim que o app estiver mais estável.

Enquanto isso, há duas formas de experimentar o Dana wallet:

- Baixe o APK mais recente do Dana wallet na [página de releases](https://github.com/cygnet3/danawallet/releases)
- Baixe o Dana wallet usando nosso [repositório F-Droid auto-hospedado](https://fdroid.silentpayments.dev/fdroid/repo)

### Baixar usando F-Droid

Recomendamos a opção F-Droid, pois oferece suporte a atualizações automáticas e requer configuração apenas uma vez.

- Abra o F-Droid no seu telefone Android
- Vá em 'Configurações'
- Na seção 'Meus Apps', clique em 'Repositórios'
- Adicione um novo repositório clicando no ícone '+'
- Escaneie o código QR encontrado nesta página: https://fdroid.silentpayments.dev/fdroid/repo

Você adicionou nosso repositório auto-hospedado. Para baixar o app, procure por 'Dana Wallet' na seção de loja do F-Droid (pode ser necessário atualizar a lista de apps primeiro, deslizando para baixo na tela da loja F-Droid).

## Construindo Dana wallet a partir do código fonte

Abaixo estão algumas instruções para construir o Dana wallet a partir do código fonte. Isso é recomendado apenas se você quiser ajudar no desenvolvimento do Dana wallet.

### Construindo para linux (desktop)

Construir para linux não deve requerer esforço extra, simplesmente execute

```
flutter run
```

Isso também pode funcionar em outras plataformas (macOS, Windows), mas não testamos.

### Construindo para android

Construir para um dispositivo android requer algum trabalho preparatório para gerar os binários para essa arquitetura.

Primeiro, você precisa do `cargo-ndk`. Também pode ser necessário adicionar as toolchains desejadas:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Após a instalação, entre no diretório rust e execute `just build-android`.

```
cd rust
just build-android
```

Se você não tiver o `just` instalado, também pode copiar os comandos encontrados no `justfile`.
Isso gera os binários.

Em seguida, conecte seu telefone e habilite o modo de depuração.
Verifique se o telefone está conectado executando

```
flutter devices
```

Finalmente, para construir e instalar o app no seu dispositivo android:

```
flutter run
```

## Doe para o Dana

Você pode doar para o Dana wallet usando nosso endereço:

> ₿donate@danawallet.app

ou pode usar o seguinte endereço de pagamento silencioso:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---