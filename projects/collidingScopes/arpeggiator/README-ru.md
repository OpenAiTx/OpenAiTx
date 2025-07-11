# Арпеджиатор с управлением жестами рук

Арпеджиатор, драм-машина и визуализатор, реагирующий на аудио, с управлением с помощью рук. Поднимите руки, чтобы поднять настроение!

Интерактивное веб-приложение, созданное с использованием threejs, компьютерного зрения mediapipe, rosebud AI и tone.js.

- Рука №1 управляет арпеджио (поднимите руку — повысится высота тона, сожмите пальцы — изменится громкость)
- Рука №2 управляет ударными (поднимайте разные пальцы, чтобы изменить рисунок)

[Видео](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [Демо онлайн](https://collidingscopes.github.io/arpeggiator/) | [Больше кода и туториалов](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## Требования

- Современный веб-браузер с поддержкой WebGL
- Доступ к камере для отслеживания рук

## Технологии

- **MediaPipe** для отслеживания рук и распознавания жестов
- **Three.js** для визуализации, реагирующей на аудио
- **Tone.js** для синтеза звуков
- **HTML5 Canvas** для визуальной обратной связи
- **JavaScript** для взаимодействия в реальном времени
## Настройка для разработки

```bash
# Клонируйте этот репозиторий
git clone https://github.com/collidingScopes/arpeggiator

# Перейдите в директорию проекта
cd arpeggiator

# Запустите сервер любым удобным способом (пример с использованием Python)
python -m http.server
```

Затем перейдите по адресу `http://localhost:8000` в вашем браузере.

## Лицензия

MIT License

## Благодарности
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## Связанные проекты

Я выпустил несколько проектов по компьютерному зрению (с кодом и уроками) здесь:
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

Вы можете приобрести пожизненный доступ и получить все файлы проектов и обучающие материалы. Я регулярно добавляю новый контент 🪬

Вам также могут понравиться некоторые из моих других проектов с открытым исходным кодом:

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) — управляйте 3D-моделями с помощью голоса и жестов рук
- [Учебник по отслеживанию рук в Threejs](https://collidingScopes.github.io/threejs-handtracking-101) — базовая настройка отслеживания рук с помощью threejs и компьютерного зрения MediaPipe
- [Particular Drift](https://collidingScopes.github.io/particular-drift) — превращайте фотографии в анимации из движущихся частиц
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) — преобразуйте видео в пиксель-арт в стиле ASCII
## Контакты

- Instagram: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- Twitter/X: [@measure_plan](https://x.com/measure_plan)
- Электронная почта: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## Пожертвования

Если этот инструмент оказался для вас полезным, вы можете угостить меня кофе.

Меня зовут Алан, и я люблю создавать программное обеспечение с открытым исходным кодом для компьютерного зрения, игр и многого другого. Это будет очень кстати во время ночных сессий программирования!

[![Купите мне кофе](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---