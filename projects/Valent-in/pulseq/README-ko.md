# PulseQueue

전자 신디사이저로 전자 음악을 만드는 미니멀리스트 웹 애플리케이션입니다.  
처음에는 스케치 도구로 설계되었지만 완성된 트랙 제작에도 사용할 수 있습니다 :musical_note::notes:

**[:link: 브라우저에서 실행 :link:](https://valent-in.github.io/pulseq)**

- 간단하고 사용하기 쉬움
- 모바일 친화적
- 클라이언트 전용 (서버에서 데이터 처리 없음)

- 다양한 효과가 있는 감쇄 신디사이저
- 하모닉 오실레이터 및 기본 FM
- 다중 레이어 스텝 시퀀서
- 내보낼 수 있는 신스 프리셋
- WAV 오디오 내보내기
- MIDI 내보내기

## 음악 예제 (YouTube)
- [Cosmix - part 1](https://www.youtube.com/watch?v=KkLsClq37w4)
- [Cosmix - part 2](https://www.youtube.com/watch?v=8_aYqIMCa2k)
- [Clean Steps](https://www.youtube.com/watch?v=2IaCb21nIZU)

## 빠른 시작
시작하려면 포함된 노래로 실험할 수 있습니다. 시작 메뉴에서 "Demo" 버튼을 클릭하고 데모 트랙을 선택하세요. 이 메뉴에 다시 접근하려면 페이지를 새로고침하세요.

**프로그램 탭:**  
ARRANGE :cd:  
패턴을 결합하여 완성된 음악 트랙을 만듭니다.

PATTERN :musical_keyboard:  
여기에 음표를 배치합니다. 신디 엔진은 모노포닉(단일 음성)이지만, 패턴 레이어로 추가 음성을 만들 수 있습니다.

SYNTH :control_knobs:  
선택한 악기의 설정 패널입니다. 프리셋은 3점 메뉴에서 사용할 수 있습니다.

LIST :level_slider::level_slider:  
신디사이저 목록과 믹서를 포함합니다.

## 참조 카드
![overview card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-overview.png)
![controls card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-controls.png)
![routing card](https://raw.githubusercontent.com/Valent-in/pulseq/master/refcards/refcard-synth.png)

## 성능 참고사항
- 일부 이펙트는 CPU 사용량이 많습니다 (특히 리버브와 페이저). 모바일 기기에서 사용할 때 이를 고려해야 합니다.  
- 모바일 브라우저에서는 WAV 내보내기 시간이 약 10분으로 제한될 수 있습니다.

---
Web Audio API와 [Tone.js](https://github.com/Tonejs/Tone.js) 사용  
파일 내보내기 소스:  
[bufferToWave](https://github.com/rwgood18/javascript-audio-file-dynamics-compressor),  
[midi-writer](https://github.com/carter-thaxton/midi-file).

이 프로그램은 자유 소프트웨어입니다: GNU 일반 공중 사용 허가서 버전 3의 조건에 따라 복제 및/또는 수정할 수 있습니다.  
이 프로그램은 유용하게 사용되기를 바라지만, 어떠한 보증도 제공하지 않습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---