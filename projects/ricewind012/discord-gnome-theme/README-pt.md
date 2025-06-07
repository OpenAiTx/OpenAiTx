# Tema GNOME para Discord

Um tema GNOME para o Discord, seguindo o estilo Adwaita e as Diretrizes de Interface Humana do GNOME (dentro do que o CSS do Discord permite).

## Requisitos

1. Vesktop

   Para ativar a barra de título do Windows.

2. Configurações > Idioma > Escolha "English (US)"

   Isso permite ícones personalizados devido à forma como são identificados no Discord. Você pode [localizar](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) o tema, mas leia a nota sobre localização.

3. Configurações > Plugins > Ative "ThemeAttributes"

   Isso permite ícones na caixa de diálogo de configurações.

4. Configurações > Configurações do Vesktop > Ative "Discord Titlebar"

   Opcional, mas recomendado se você utiliza barras de título.

### Adições opcionais

1. Remover referências ao Nitro: https://github.com/CroissantDuNord/discord-adblock

## Filosofia de tematização

### Diretrizes de Interface Humana

O tema pode não seguir totalmente as HIG devido a limitações do CSS ou design do Discord, ou por escolhas próprias.

### Suporte

Não são suportados:

- Experimentos do Discord

  Não trabalho para o Discord, então não tenho como saber se esses experimentos estão sendo alterados, descontinuados, etc., ou seja, carga de manutenção — mantenho vários outros projetos

- Nitro

  Exceções — qualquer coisa acessível com o plugin FakeNitro.

Você \*pode\* abrir uma issue sobre qualquer um desses itens, mas só será corrigido se for uma correção simples, ou seja, ícone ausente.

## Instalação

### Sem configuração

Copie o seguinte na caixa de texto localizada em Configurações > Temas > Temas Online:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### Incluindo configuração

Coloque [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) em ~/.config/vesktop/themes. Ele ainda será atualizado automaticamente.

## Visualização

![primeiro](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy segundo](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![terceiro](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---