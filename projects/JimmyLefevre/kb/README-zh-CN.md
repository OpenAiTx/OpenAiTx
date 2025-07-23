# kb

[单文件头](https://github.com/nothings/stb/blob/master/docs/stb_howto.txt)的 C/C++ 许可友好库。

## 库

- [kb\_text\_shape.h](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./kb_text_shape.h)：Unicode 文本分割与 OpenType 形状处理

## kb_text_shape.h

![使用 stb_truetype 的阿拉伯语形状示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/arabic.png)
![使用 stb_truetype 的印地语形状示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/hindi.png)
![使用 stb_truetype 的高棉语形状示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/khmer.png)
![使用 stb_truetype 的缅甸语形状示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/myanmar.png)
![使用 stb_truetype 的 Gunjala Gondi 形状示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/gunjala_gondi.png)
![切换小型大写字母字体特性的示例](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./images/smallcaps.png)

[kb\_text\_shape.h](https://raw.githubusercontent.com/JimmyLefevre/kb/main/./kb_text_shape.h) 提供类似 ICU 的文本分割（即按方向、行、单词和字素分割 Unicode 文本）。它还提供类似 Harfbuzz 的 OpenType 字体文本形状处理，意味着它能够处理复杂的书写系统布局和连字等功能。

它**不**处理光栅化。它**不**处理段落布局。它只会帮助你知道在单行无限长的线上显示哪些字形！

（参见 https://www.newroadoldway.com/text1.html 了解文本处理不同步骤的说明。）

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




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---