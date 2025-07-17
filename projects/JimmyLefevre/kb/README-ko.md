<translate-content># kb

[C/C++용 단일 헤더](https://github.com/nothings/stb/blob/master/docs/stb_howto.txt) 관대 라이선스 라이브러리들입니다.

## 라이브러리

- [kb\_text\_shape.h](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./kb_text_shape.h): 유니코드 텍스트 분할 및 OpenType 셰이핑

## kb_text_shape.h

![stb_truetype로 아랍어 셰이핑 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/arabic.png)
![stb_truetype로 힌디어 셰이핑 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/hindi.png)
![stb_truetype로 크메르어 셰이핑 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/khmer.png)
![stb_truetype로 미얀마어 셰이핑 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/myanmar.png)
![stb_truetype로 군잘라 곤디어 셰이핑 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/gunjala_gondi.png)
![스몰캡스 폰트 기능 토글 예제](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/smallcaps.png)

[kb\_text\_shape.h](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./kb_text_shape.h)는 ICU와 유사한 텍스트 분할(즉, 방향, 줄, 단어, 그래픔 단위로 유니코드 텍스트를 나눔)을 제공합니다. 또한 Harfbuzz와 유사한 OpenType 폰트용 텍스트 셰이핑을 제공하여 복잡한 스크립트 레이아웃과 리가처 처리 등이 가능합니다.

이 라이브러리는 **래스터화**를 처리하지 않습니다. **단락 레이아웃**을 처리하지 않습니다. 단일의 무한히 긴 한 줄에서 어떤 글리프를 어디에 표시할지 아는 데만 도움을 줍니다!

(텍스트 처리의 다양한 단계에 대한 설명은 https://www.newroadoldway.com/text1.html 을 참조하세요.)
</translate-content>
```c
static kbts_font GlobalFont;

void RenderGlyph(kbts_glyph *Glyph, int X, int Y); // Yours to implement

void ShapeText(kbts_cursor *Cursor, uint32_t *Codepoints, size_t CodepointCount, kbts_direction MainDirection, kbts_direction Direction, kbts_script Script)
{
  kbts_glyph *Glyphs = (kbts_glyph *)malloc(sizeof(kbts_glyph) * CodepointCount);

  for(size_t CodepointIndex = 0; CodepointIndex < CodepointCount; ++CodepointIndex)
  {
    Glyphs[CodepointIndex] = kbts_CodepointToGlyph(&GlobalFont, Codepoints[CodepointIndex]);
  }

  kbts_shape_state *State = kbts_CreateShapeState(&GlobalFont);
  kbts_shape_config Config = kbts_ShapeConfig(&GlobalFont, Script, KBTS_LANGUAGE_DONT_KNOW);

  uint32_t GlyphCount = CodepointCount;
  uint32_t GlyphCapacity = GlyphCount;
  while(kbts_Shape(State, &Config, MainDirection, Direction, Glyphs, &GlyphCount, GlyphCapacity))
  {
    Glyphs = (kbts_glyph *)realloc(sizeof(kbts_glyph) * State->RequiredGlyphCapacity);
    GlyphCapacity = State->RequiredGlyphCapacity;
  }

  for(size_t GlyphIndex = 0; GlyphIndex < GlyphCount; ++GlyphIndex)
  {
    kbts_glyph *Glyph = &Glyphs[GlyphIndex];

    int X, Y;
    kbts_PositionGlyph(Cursor, Glyph, &X, &Y);

    RenderGlyph(Glyph, X, Y);
  }

  free(Glyphs);
}

void SegmentText(uint32_t *Codepoints, size_t CodepointCount)
{
  kbts_cursor Cursor = {0};
  kbts_direction Direction = KBTS_DIRECTION_NONE;
  kbts_script Script = KBTS_SCRIPT_DONT_KNOW;
  size_t RunStart = 0;
  kbts_break_state BreakState;
  kbts_BeginBreak(&BreakState, KBTS_DIRECTION_NONE, KBTS_JAPANESE_LINE_BREAK_STYLE_NORMAL);
  for(size_t CodepointIndex = 0; CodepointIndex < CodepointCount; ++CodepointIndex)
  {
    kbts_BreakAddCodepoint(&BreakState, Codepoints[CodepointIndex], 1, (CodepointIndex + 1) == CodepointCount);
    kbts_break Break;
    while(kbts_Break(&BreakState, &Break))
    {
      if((Break.Position > RunStart) && (Break.Flags & (KBTS_BREAK_FLAG_DIRECTION | KBTS_BREAK_FLAG_SCRIPT | KBTS_BREAK_FLAG_LINE_HARD)))
      {
        size_t RunLength = Break.Position - RunStart;
        ShapeText(&Cursor, Codepoints + RunStart, RunLength, BreakState.MainDirection, Direction, Script);
        RunStart = Break.Position;
      }

      if(Break.Flags & KBTS_BREAK_FLAG_DIRECTION)
      {
        Direction = Break.Direction;
        if(!Cursor.Direction) Cursor = kbts_Cursor(BreakState.MainDirection);
      }
      if(Break.Flags & KBTS_BREAK_FLAG_SCRIPT)
      {
        Script = Break.Script;
      }
    }
  }
}
```
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---