
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Calendário Familiar Inteligente DIY para Casa (Clone do Skylight)

![Calendário Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introdução

Minha esposa tem sido recentemente bombardeada nas redes sociais com anúncios de calendários inteligentes para casa (Skylight, Cozyla, Hearth) e estava pronta para gastar mais de US$ 300 em um. Antes de dar o sinal verde, pedi uma chance para pesquisar sobre eles.
Percebi que a maioria oferecia funcionalidades semelhantes, mas diferiam significativamente no preço. Mais importante ainda, não vi nenhum recurso excepcional que eu não pudesse implementar no **Home Assistant**.

**O Objetivo:** Um calendário touchscreen aprovado pelo WAF (Fator de Aceitação da Esposa), amigável para bancada, que se integra profundamente à nossa casa inteligente sem taxas mensais.

## 💡 Por que fazer você mesmo?

Optar pela rota DIY com Home Assistant trouxe vários benefícios em relação à compra de um display Skylight/Hearth:

* **Sem taxas mensais:** Evita assinaturas para recursos "premium".
* **Integração perfeita:** Interage com nossas luzes, tarefas (Grocy) e sensores de presença.
* **Hardware antigo:** Reaproveitei um Mini PC e um monitor padrão.
* **Privacidade:** Sem dependência de fornecedor ou risco da empresa encerrar operações.

## 🛠 Seleção de Hardware

Atualmente, este projeto foi feito para exibir o painel em qualquer tela HD (1920x1080).

No meu caso, a exigência era que ele "parecesse" com um Skylight, fosse touchscreen, ficasse na bancada e pudesse ser movido para diferentes locais. Por isso, escolhi o hardware descrito abaixo.
No entanto, seu caso pode ser diferente e você precisará ajustá-lo conforme necessário, por exemplo, se quiser exibir em um tablet ou outro dispositivo.

O hardware que usei originalmente foi escolhido com base no que mencionei acima, além da esperança de poder estender funcionalidades usando a webcam, alto-falante e microfone. Atualmente, provavelmente montaria diferente, já que ainda não tive tempo de implementar essas ideias adicionais de hardware.

* **Monitor:** [HP Engage Touchscreen de 15 polegadas](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Escolhi este ao invés de monitores portáteis genéricos porque inclui **alto-falante, webcam e microfone** integrados, permitindo controle por voz ou chamadas de vídeo no futuro.
* **Computador:** Um Mini PC antigo (NUC/Tiny PC) rodando Windows/Linux em modo Kiosk, ou um Raspberry Pi 4.~~

## ✨ Funcionalidades

* **Visões de família e individuais:** Ative ou desative os calendários de membros específicos da família.
* **Sincronização bidirecional:** Edite eventos na tela ou em nossos celulares (Google Calendar).
* **Popup "Adicionar Evento":** Uma interface personalizada para adicionar eventos a calendários específicos diretamente da tela.
* **Clima e Data:** Cabeçalho bonito e de fácil visualização.
* **Responsivo:** Ajusta automaticamente a quantidade de dias exibidos conforme a largura da tela (Mobile vs Desktop).

---

## ⚙️ Guia de Instalação

*Nota: Esta configuração utiliza um **Pacote YAML** para criar automaticamente todos os auxiliares, scripts e variáveis necessários para você. Não é necessário criá-los manualmente.*



### 1. Pré-requisitos (HACS)

Você deve ter o [HACS](https://hacs.xyz/) instalado. Por favor, instale as seguintes integrações de **Frontend**:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Necessário para os popups funcionarem)
* `layout-card` (Necessário para a visualização de Seções)
* `button-card` (Necessário para o popup de adicionar evento)

*Nota: Em Configurações → Dispositivos & Serviços, certifique-se de que o Browser Mod apareça como uma Integração (bloco) e não apenas no HACS.
Se não estiver lá, clique em Adicionar Integração → Browser Mod e finalize o fluxo, depois reinicie o HA.
A instalação via HACS apenas baixa os arquivos; você deve adicionar a integração para que o HA registre suas ações/entidades.

### 2. O Backend (O Cérebro)

1. Abra seu arquivo `configuration.yaml` no Home Assistant.
2. Certifique-se de que esta linha está adicionada sob `homeassistant:` para habilitar pacotes:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Crie uma pasta chamada `packages` no seu diretório de configuração do HA (caso ainda não exista).
4. Baixe [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) deste repositório.
5. Procure pela string [ #<--- UPDATE THIS ENTITY] e atualize o ID da entidade do calendário para coincidir com o seu ambiente. Veja a seção 3 para mais detalhes.
6. Coloque o arquivo dentro da sua pasta `packages/`.
7. **Reinicie o Home Assistant**.

### 3. Os Calendários

Você pode usar **Calendários do Google** ou **Calendários Locais**.

#### Opção A: Reutilizar Nomes de Calendário (Mais Fácil)


1. Vá em **Configurações > Dispositivos e Serviços**.
2. Adicione a integração **Calendário Local**.
3. Crie calendários com exatamente estes nomes: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Se você usar esses nomes, o código funciona imediatamente!*

#### Opção B: Calendário Personalizado

1. Vá em **Configurações > Dispositivos e Serviços**.
2. Adicione a integração **Calendário Local** ou **Google Calendar**.
3. Navegue até **Configuração > Integrações > Calendário Local** ou **Google Calendar** e selecione "Adicionar Entrada"
4. Para cada entrada criada, obtenha o ID da entidade para atualizar o arquivo dashboard.yaml.
5. Abra o `dashboard.yaml`.
6. Procure por `# <--- UPDATE THIS ENTITY`.
7. Atualize o ID da entidade de acordo com o seu ambiente


#### Configurando Feriados

Desde as atualizações do Home Assistant, os feriados agora são adicionados via interface:

1. Vá em **Configurações > Dispositivos e Serviços > Adicionar Integração > Holiday**.
2. Selecione seu país.
3. Verifique o ID da entidade (ex.: `calendar.holidays`). Se for diferente do padrão, atualize-o no YAML do dashboard.

### 4. O Dashboard (A Aparência)


1. Vá para **Configurações > Painel de Controle**
2. Clique em **Adicionar Painel de Controle** (Selecione a opção "Novo Painel de Controle do Zero" e certifique-se de selecionar "Adicionar à barra lateral").
3. No menu à esquerda, selecione o painel recém-criado e clique no ícone de lápis para editá-lo.
5. Selecione o ícone de 3 pontos e escolha "Editor de configuração bruta".
6. Copie e cole o código de [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### Passo 5: O Tema (Opcional)

Para obter o visual da fonte específica (Ovo):

1. Certifique-se de que seu `configuration.yaml` tenha esta linha em `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Crie uma pasta chamada `themes` no seu diretório de configuração.
3. Baixe [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) e coloque-o nessa pasta.
4. Use o Editor de Arquivos e faça o upload do calbackgrd.png para a pasta /www/, que é traduzida internamente como /local no painel.
5. Reinicie o Home Assistant.
6. Vá até o seu Perfil (Ícone de Usuário no canto inferior esquerdo) e altere o **Tema** para `Skylight`.
NOTA: O tema não é abrangente, então tenha isso em mente

---

## 📐 Como Funciona (Por Trás dos Bastidores)

### Lógica de Filtro

O `week-planner-card` não suporta nativamente ocultar calendários específicos dinamicamente. Para resolver isso, utilizei **Input Texts** atuando como filtros Regex.

* Quando você clica no botão de uma pessoa, ele alterna o filtro entre `.*` (Mostrar tudo) e `^$` (Não mostrar nada).
* O `config-template-card` injeta essas variáveis no cartão de calendário dinamicamente.

### Script de Criação de Evento

O popup "Adicionar Evento" utiliza um único script que gerencia a lógica para múltiplas pessoas e tipos de eventos (Dia Inteiro vs Com Horário).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## NOTAS

Minha postagem original foi apenas para dar uma visão geral de alto nível de como fazer isso e permitir que as pessoas ajustem o código para funcionar em seus cenários específicos.

Em particular, fiz isso porque cada display e necessidade são diferentes. Não posso desenvolver para todos os tamanhos potenciais de displays, dashboards, etc. Então, foi feito para funcionar no display que mencionei ou em qualquer outro (1920x1080), mas deve ser editável para outros.

Falando sobre display, originalmente sugeri aquele porque estava em promoção no Woot e era uma forma muito econômica de obter um display touchscreen na época. Isso pode não ser o caso agora, então use qualquer display que funcione para você. Tablet, touchscreen, celular, o que preferir. O principal que você precisará editar é o dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---