# telescope-tabs
네오빔에서 탭을 빠르게 탐색하세요 ✈️

<p align="center">
	<img src="https://github.com/LukasPietzschmann/telescope-tabs/assets/49213919/e749d458-4ffd-4af2-aba9-86d0e3fb4862" width="300px" />
</p>

## 중요한 참고사항
telescope를 사용하고 싶지 않다면, telescope 대신 `vim.ui.select`를 사용하는 버전도 있습니다. [`vim_ui_select`](https://github.com/LukasPietzschmann/telescope-tabs/tree/vim_ui_select) 브랜치를 확인해 보세요 :)

## 사용법
네오빔의 명령줄에서 피커를 실행할 수 있습니다
```
:Telescope telescope-tabs list_tabs
```
또는 lua를 사용하여 플러그인의 경로에서 직접 실행하기

```viml
:lua require('telescope-tabs').list_tabs()
```

피커 내의 어떤 항목에서든 `C-d` (삽입 모드) 또는 `D` (일반 모드)를 눌러 탭(또는 해당 탭 내 모든 창)을 닫을 수 있습니다. 키 바인딩을 변경하려면 [설정](https://github.com/LukasPietzschmann/telescope-tabs#configure)을 참조하세요.
<p align="center">
	<img src="https://user-images.githubusercontent.com/49213919/216813167-45ca1908-b15f-4904-a441-6420d82dcb16.png" width="550"  />
</p>

하지만 `telescope-tabs`는 피커만 제공하지 않습니다! 또한 호출할 수 있습니다
```viml
:lua require('telescope-tabs').go_to_previous()
```
마지막으로 열었던 탭으로 즉시 전환합니다.  
이 기능은 이 확장 프로그램을 사용하여 탭을 전환할 때뿐만 아니라 Neovim의 기본 탭 이동 방법을 사용할 때도 작동합니다.  

이 플러그인은 이미 존재하는 `g<Tab>` 단축키를 개선하여 "마지막으로 표시된 탭 스택"을 추적합니다. 따라서 가장 최근에 방문한 탭을 닫으면 `g<Tab>`는 실패하지만, telescope-tabs는 두 번째로 마지막 탭을 기쁘게 표시합니다.  

이 기능을 정기적으로 사용하려면 단축키에 바인딩하는 것을 권장합니다 :^)  


## 설치  
선호하는 Neovim 패키지 관리자를 사용하여 설치하세요.  

lazy.nvim 예시:
```lua
{
	'LukasPietzschmann/telescope-tabs',
	config = function()
		require('telescope').load_extension 'telescope-tabs'
		require('telescope-tabs').setup {
			-- Your custom config :^)
		}
	end,
	dependencies = { 'nvim-telescope/telescope.nvim' },
}
```

packer.nvim 예제:
```lua
use {
	'LukasPietzschmann/telescope-tabs',
	requires = { 'nvim-telescope/telescope.nvim' },
	config = function()
		require'telescope-tabs'.setup{
			-- Your custom config :^)
		}
	end
}
```
## 구성하기
다양한 구성은 [configs 위키](https://github.com/LukasPietzschmann/telescope-tabs/wiki/Configs#configs)에서 확인할 수 있습니다. 자유롭게 자신만의 구성을 추가하세요!

자신만의 구성을 만들고 싶다면, 조정할 수 있는 설정은 다음과 같습니다:

### entry_formatter
탭이 선택기에서 어떻게 표시되는지를 변경합니다. 기본적으로 다음 함수가 사용됩니다:
```lua
entry_formatter = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	local entry_string = table.concat(file_names, ', ')
	return string.format('%d: %s%s', tab_id, entry_string, is_current and ' <' or '')
end,
```
이 동작을 변경하려면, 단지 자신의 함수를 할당하세요.

### entry_ordinal
이것은 탭이 일치하는 쿼리를 변경합니다. 기본적으로 다음 함수가 사용됩니다:
```lua
entry_ordinal = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	return table.concat(file_names, ' ')
end,
```

### show_preview
이것은 미리보기가 표시되는지 여부를 제어합니다. 기본값은 `true`입니다:
```lua
show_preview = true,
```

### close_tab_shortcut
이 단축키들은 선택한 탭을 피커에서 바로 닫을 수 있게 해줍니다. 기본값은...
```lua
close_tab_shortcut_i = '<C-d>', -- if you're in insert mode
close_tab_shortcut_n = 'D',     -- if you're in normal mode
```
참고로, 이 값들은 파싱되거나 검사되지 않으므로 키 바인딩의 일반 형식을 따라야 합니다.

## 문서
자세한 내용은 [telescope-tabs.txt](https://github.com/LukasPietzschmann/telescope-tabs/blob/master/doc/telescope-tabs.txt)를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---