<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Implementação rápida e modular da Lightning Network para todos os usos, escrita em Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Página do Projeto</a>
  </h4>
</div>

## Crates

Esta é a lista completa de crates suportados atualmente:

| Crate       | Descrição                                        | Versão      |
|:------------|:------------------------------------------------:|------------:|
| lampod-cli  | Interface de linha de comando do Lampo Daemon para executar o daemon | _não relacionado_ |
| lampo-cli   | Interface de linha de comando simples do Lampo para interagir com o daemon | _não relacionado_ |

## Como Instalar

Para instalar todos os requisitos e o binário do Lampo, você precisa
ter o Rust instalado e, em seguida, executar o seguinte comando:

```
make install
```

Depois de ter `lampod-cli` e `lampo-cli` disponíveis, você pode
executar o seguinte comando para iniciar o Lampo em modo signet:

```
➜  ~ lampod-cli --network signet
✓ Carteira Gerada, por favor armazene estas palavras de forma segura
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Guarde as palavras da sua carteira e reutilize-as para restaurar a carteira com `--restore-wallet`.
Se você não armazenar suas palavras em algum lugar, seus fundos serão perdidos na próxima inicialização do Lampo!

Observe que é necessário ter um `lampo.conf` no caminho `~/.lampo/signet`. Execute o
seguinte comando para usar o arquivo de configuração de exemplo:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Depois, você pode consultar o nó com o seguinte comando:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Para rodar testes de integração com core lightning:

Certifique-se de ter compilado o core-lightning no modo desenvolvedor. O guia de instalação pode ser encontrado [aqui](https://docs.corelightning.org/docs/installation).

Os testes de integração podem ser executados com o seguinte comando:

```
make integration
```

## Diretrizes de Contribuição

Por favor, leia nosso [Guia de Contribuição](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Comunidade

Determinados a manter a clareza, escolhemos canais específicos para comunicação:
- Desenvolvedores, juntem-se a nós no [Zulip](https://lampo-dev.zulipchat.com/).
- Membros da comunidade, nossa [comunidade no Twitter](https://twitter.com/i/communities/1736414802849706087) aguarda seus insights.
- Para dúvidas técnicas e solicitações de funcionalidades, participe das discussões no nosso GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---