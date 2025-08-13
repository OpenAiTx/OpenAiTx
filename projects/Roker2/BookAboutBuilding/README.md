<p align="center">
  <img src="https://raw.githubusercontent.com/Roker2/BookAboutBuilding/master/website/public/icon.png" width="128"/>
  <p align="center"><b>BookAboutBuilding</b></p>
</p>

<p align="center">
<img src="https://img.shields.io/badge/Android-3DDC84?style=for-the-badge&logo=android&logoColor=white"/><br>
<img src="https://img.shields.io/badge/lineageos-167C80?style=for-the-badge&logo=lineageos&logoColor=white"/>
<img src="https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black"/><br>
<img src="https://img.shields.io/badge/Arch%20Linux-1793D1?logo=arch-linux&logoColor=fff&style=for-the-badge"/>
<img src="https://img.shields.io/badge/Debian-D70A53?style=for-the-badge&logo=debian&logoColor=white"/>
</p>

## Введение

Книга представляет собой исчерпывающее руководство по сборке операционной системы Android из исходного кода на Linux и разбору ее работы на низком уровне. Написанная в доступном и понятном стиле, она предоставляет читателям уникальную возможность углубиться во внутреннюю механику Android и получить полное представление о том, как функционирует эта популярная мобильная платформа.

# ❓ Я хочу что-то добавить/исправить, как мне это правильно сделать?

* Если вы контрибьютер данного репозитория, сделайте отдельную ветку с названием, которое подходит для ваших изменений, внесите изменения в нее и сделайте мерж реквест. 
* Если же вы не контрибьютер, для вас процедура такая же, только мерж реквест вы делаете из своего форка или другим способом.

# 🌎 I want translate, how I can do it?
Read [`TRANSLATIONS.md`](https://raw.githubusercontent.com/Roker2/BookAboutBuilding/master/TRANSLATIONS.md) and make a translation according to those instructions and send us a Pull Request. We will check your translation and if it is correct, we will accept it

# 🔨 Сборка

Для генерации книжки, мы используем [VitePress](https://vitepress.dev/).
1. <b>🦀 Установка</b>

	```
	npm add -D vitepress
	npm i -D vitepress-plugin-tabs
	```
2. <b>🚀 Запуск</b>
	Чтобы посмотреть на результат, выполните эту команду. Утилита запустит локальный Web-сервер на localhost на 5173 порту.
	```
	npm run docs:dev
	```
