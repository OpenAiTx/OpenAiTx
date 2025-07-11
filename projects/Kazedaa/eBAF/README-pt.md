# eBAF - Firewall de Anúncios Baseado em eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Você Não Baixaria um Anúncio"
### Mas Você Bloquearia Um!
 
O Spotify construiu um império baseado em uma fórmula simples: monetizar sua atenção, pagar mal os artistas e vender de volta o seu próprio tempo como um recurso premium.
No mundo deles, sua experiência de escuta não é sua. É um mercado cuidadosamente curado — seus ouvidos são o produto, sua paciência é a moeda.

Eles gostam de chamar isso de um nível "gratuito".
Mas sejamos honestos: não é gratuito se você está pagando com seu tempo.

Enquanto isso, os artistas que você ama — as pessoas cujo trabalho mantém a plataforma viva — muitas vezes ganham apenas frações de centavos por reprodução. O Spotify lucra bastante, os anunciantes recebem sua exposição e os criadores? Eles ficam com as migalhas.

Isso não é apenas sobre pular alguns anúncios irritantes.
É sobre recusar-se a participar de um sistema que lucra com a exploração, distração e a mercantilização da sua atenção.

#### O que é isso?
Um pequeno e elegante ato de resistência digital: um bloqueador de anúncios limpo e de código aberto para Spotify que elimina o ruído — literalmente.

Sem mods duvidosos, sem clientes crackeados, sem malwares disfarçados de liberdade. Apenas um objetivo: deixar a música tocar sem ser refém dos anúncios.

O Spotify não é gratuito — você paga com a sua paciência.

Eles te bombardeiam com os mesmos anúncios irritantes, repetidamente, até você desistir e assinar. Não porque você ama o Premium. Mas porque você foi desgastado. Isso não é freemium — isso é guerra psicológica com uma playlist.

Enquanto isso, os artistas? Continuam mal pagos.
Os anúncios? Mais altos. Mais frequentes. Às vezes, literalmente mais altos.
Você? Só tentando curtir.

Eles lucram com a sua paciência e com o subpagamento dos criadores, tudo isso fingindo que é o único caminho sustentável. Spoiler: não é. Eles tinham escolha — mas escolheram a margem de lucro ao invés das pessoas.

O Spotify quer que você acredite que esse é o preço do acesso.
Nós acreditamos que isso é mentira.

Não somos piratas. Não somos criminosos. Somos apenas pessoas que acham que está tudo bem em traçar um limite.

Este projeto não é sobre pular alguns anúncios. É sobre rejeitar um sistema que diz que seu silêncio pode ser vendido, sua experiência pode ser interrompida, e seu valor só começa quando você abre a carteira.

Bloquear anúncios não é roubo.<br>
Roubar seu tempo é.<br>
Não estamos aqui para piratear. Estamos aqui para sair fora.<br>
<br>
**Você não baixaria um anúncio. Mas você bloquearia um.**
## Como o eBAF funciona?

O eBAF (eBPF Ad Firewall) aproveita o poder do eBPF (Extended Berkeley Packet Filter) para bloquear anúncios indesejados no nível do kernel. Aqui está uma visão geral de alto nível de sua funcionalidade:

## Como o eBAF funciona?

O eBAF (eBPF Ad Firewall) utiliza o eBPF (Extended Berkeley Packet Filter) para bloquear anúncios de forma eficiente no nível do kernel. Veja uma visão geral simplificada:

1. **Filtragem de Pacotes**:
   - Inspeciona os pacotes de rede recebidos e bloqueia aqueles que correspondem a uma lista negra de endereços IP usando o XDP (eXpress Data Path).

2. **Atualizações Dinâmicas**:
   - Resolve nomes de domínio em endereços IP e atualiza a lista negra dinamicamente para manter a eficácia contra servidores de anúncios em constante mudança.

3. **Painel Web**:
   - Fornece estatísticas em tempo real e monitoramento por meio de uma interface amigável ao usuário.

4. **Alto Desempenho**:
   - Opera diretamente no nível da interface de rede, ignorando a pilha de rede do kernel para processamento mais rápido e uso mínimo de recursos.

O eBAF combina eficiência, transparência e facilidade de uso para oferecer uma solução poderosa de bloqueio de anúncios.
## Instalação Simples (Recomendada)
Certifique-se de ter o git e o curl instalados
```bash
git --version
curl --version
```
### Instalar
#### Ativar integração com Spotify (Recomendado)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Desativar explicitamente
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash
```

### Desinstalar
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Instalação para Desenvolvimento
Execute os seguintes comandos para instalar as dependências necessárias:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Corrigindo o erro asm/types.h ao executar código eBPF
Verifique o link atual
`ls -l /usr/include/asm`
Encontre o link correto
`find /usr/include -name "types.h" | grep asm`
Corrija o link simbólico
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Compilando o Projeto

Para compilar o eBPF Adblocker, siga estes passos:

1. Clone o repositório:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Compile o projeto:
   ```bash
   make
   ```

3. (Opcional) Instalar no sistema inteiro:
   ```bash
   sudo make install
   ```

4. Outras opções de instalação (help desk)
    ```bash
    make help
    ````
5. Desinstalar
    ```bash
    make uninstall
    ````
## Uso

### Executando o Adblocker
    Usa spotify-stable.txt como lista negra padrão.
    Uso: ebaf [OPÇÕES] [INTERFACE...]
    OPÇÕES:
    -a, --all               Executa em todas as interfaces ativas
    -d, --default           Executa apenas na interface padrão (com acesso à internet)
    -i, --interface IFACE   Especifica uma interface para usar
    -D, --dash              Inicia o painel web (http://localhost:8080)
    -q, --quiet             Suprime a saída (modo silencioso)
    -h, --help              Mostra esta mensagem de ajuda


### Configurando a Lista Negra
Edite as listas para adicionar ou remover domínios. Cada domínio deve estar em uma linha separada. Comentários começam com `#`.

## Agradecimentos

Um agradecimento especial a ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

por fornecer uma lista de bloqueio do Spotify
## ⭐️ Apoie o Projeto

Se você acha o eBAF útil, considere adicionar uma estrela ao repositório no GitHub! Seu apoio ajuda a aumentar a visibilidade e incentiva o desenvolvimento contínuo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---