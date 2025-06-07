# GroceryApp Starter

Template simplificado de aplicativo de compras para uma experiência de compra direta. 🛒✨

Sinta-se à vontade para dar uma estrela ⭐ ao repositório se achar útil.

## Design

**Clique na imagem abaixo para visualizar o design no Figma:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨Requisitos

1. **Ambiente de Desenvolvimento:**
   - Qualquer IDE com Flutter SDK instalado (ex.: VSCode, Android Studio, IntelliJ, etc.)

2. **Base de Conhecimento:**
   - Conhecimento básico a intermediário em Dart e Flutter
   - Entendimento da arquitetura MVVM
   - Familiaridade com manipulação de APIs
   - Noções básicas de gerenciamento de estado usando GetX

## Teste
* Você pode baixar a versão pré-lançada para dispositivos Android aqui [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## Configuração
* Comece configurando o endpoint do seu produto, credenciais e parâmetros em `lib\constants\AppConstants`.
* **Alternativamente**, utilize o endpoint gratuito fornecido abaixo (válido na data de compartilhamento) para testes bem-sucedidos.
```dart
class AppConstants {
  // Substitua "YOUR_API_PREFIX" pela URL base da sua própria API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //SE_EXISTIR

  // Para teste, use a URL base da API gratuita da versão lançada
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Nome completo do proprietário do projeto.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Aviso
* Para usar seus próprios endpoints de API, personalize as camadas lógicas seguindo as diretrizes da arquitetura MVVM com base na documentação da sua API.
* Certas imagens na versão pré-lançada foram removidas devido a restrições de direitos autorais.

## Contribuindo

Por favor, faça um fork deste repositório e contribua de volta usando
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Qualquer contribuição, grande ou pequena, com grandes funcionalidades ou correções de bugs, são bem-vindas e apreciadas,
mas serão cuidadosamente revisadas.

## Primeiros Passos
Este projeto é um ponto de partida para um aplicativo Flutter.

Alguns recursos para ajudá-lo caso este seja seu primeiro projeto Flutter:

- [Lab: Escreva seu primeiro app Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Exemplos úteis de Flutter](https://flutter.io/docs/cookbook)

## Contador de Visitantes

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---