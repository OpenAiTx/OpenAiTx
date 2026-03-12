
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Seraph1ne&project=LOLAutomationTools&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Introduction
**LOLAutomationTools** is a **League of Legends** feature extension tool; it is designed to help players perform simple client operations in situations where they can't use both hands or need to step away for a moment, saving a small amount of time; the software does not overly interfere with the player's understanding or gameplay, so some features still require manual configuration in advance (such as rune setups for champions). Too much restriction can make people numb and take away the enjoyment of the game itself. Play positively and happily, and help build a harmonious environment.

# Features
- Select Champion
  - Pre-select Champion
- Ban Champion
  - Ignore Team Selection
  - Group disable mode
- Random hero
- Ban hero anti-dodge
- Accept match
  - Delayed match acceptance
- Create match
- Find match
  - Match timeout detection
- Swap function
  - Random mode swap hero
    - Or only passively accept hero swap from other players
    - Reject swaps of non-selected heroes
  - Draft mode swap positions
    - Or passively accept position swaps from other players
    - Reject swaps of non-preselected positions
  - Draft mode swap floors
    - Or only passively accept floor swaps from other players
    - Reject swaps of non-set floors
- Skip commendation page
- Skip unlock page
- Chat reply control
  - Reply to friend messages when away
  - Reply to match invitations when away
    - Refuse match invitations when away
- Additional window
  - Fun mode hero balance BUFF display
  - Auto apply runes
  - Rune correction
  - Independent hero configuration
- Auto close match
- Auto reconnect to match
- Auto claim pass rewards (including TFT)
- Friend request handling
  - Batch delete friends
- Personalized career
  - Career background
  - Summoner icon
  - Client status
  - Status signature
  - Card rank
  - Hero achievement points
  - Clear equipped medals
- Function key blocking
- Match record inquiry
  - Match record sending
  - In-game party detection
  - Player match spectating
  - Post-match player reporting
- In-game quick chat
- Blacklist
- Hotkey settings
- Theme settings
  - Dark/Light theme
  - Adaptive theme
  - Custom theme
  - Background image settings
  - Font customization
- Extended features
  - Auto card selection (Card Master)


## Hero Selection
Before using **Hero Selection** and **Hero Ban**, editing operations are required on the configuration page (button next to the toggle).

Heroes added in the lane settings only take effect in modes with *pre-selection slots* (such as *Ranked* and *Ultimate Blitz*), random only works in *Random Hero* modes (such as *ARAM*, *Ultimate Chaos*, and the ban configuration page does not include random configuration), while general applies to all other modes (not including the previously listed modes, for specification purposes). When auto-selecting heroes, selection will follow the **Hero Selection** configuration items in order from top to bottom.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/6aa4f1ad-28db-4bd5-a917-df4197024f5f" />

## Preselect Heroes
The execution logic for this feature is basically the same as **Hero Selection**, with the difference that **Preselect Heroes** only takes effect in modes with ban phases, such as *Ranked* and some entertainment modes requiring hero bans.

## Hero Ban
The **Hero Ban** configuration page is basically the same as the **Hero Selection** configuration page, except for an extra mode switch button in the top right corner. Clicking the button switches ban modes.

*Normal Ban Mode*: This mode operates like the **Hero Selection** configuration page. If no hero is configured for banning, it will empty-ban when the Ban phase timer reaches 0 seconds.

*Group Ban Mode*: The items in the configuration list will be replaced by the corresponding heroes in the **Hero Selection** configuration. When selecting an item, double-click the hero entry on the left to add it to the hero's **Ban Group**. When auto-banning heroes, it will follow the order of the **Hero Selection** configuration items. If none of the **Hero Selection** configuration **Ban Groups** have heroes configured to ban, the logic will revert to normal ban mode.

> If *Ignore Teammate Preselection* is enabled, auto-ban will skip team preselection detection. Enabling this option is not recommended.

## Accept Match
Automatically accept the match after being matched.

> When the *Delayed Match Acceptance* option is enabled, **Accept Match** will only automatically accept the match when there is one second left in the acceptance countdown.

## Create Match
You can manually create a match through the **Create Match** button or enable this toggle to automatically create matches.

> *Auto Create Match* requires you to select the match mode to be created in *More Settings*. This option will not be saved in the configuration.

## Find Match
Automatically find a match. This option only works in match mode rooms when you are the squad owner (host).

> If the *Timeout Detection* option is enabled, it will automatically requeue for a match if the queue exceeds the estimated time by the specified interval.

## Skip Commendation
Skip the commendation page for teammates at the end of the match.

## Skip Settlement
Skip the post-match settlement (black screen loading) or post-game settlement page and return to the match mode room.

## Swap Function
Includes a main toggle and three independent toggles; additional settings are required. In **Swap Function**'s more settings, you can set whether to swap heroes with teammates in Random Hero mode, swap floors (hero selection order), or swap pre-selection slots in Draft mode.

*Hero swapping and slot swapping settings are relatively straightforward and will not be elaborated here.*

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/361b4b19-cd72-4cb3-901f-69d49284bc11" />

In **Swap Floor**'s **More Settings**, you can set the swap order (i.e., floor) and swap mode.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/697bed4a-2984-43f6-b747-36c7911ef99d" />

*Swap Mode*:
- Target Order Only: Accept requests from teammates with the specified *order*.
- Priority Including Target: Accept requests from teammates with *order* ≤ specified *order*.
- Deferred Including Target: Accept requests from teammates with *order* ≥ specified *order*.
- Range Based on Target Order: Accept requests from teammates with *order* ≤ (*specified order* - *range*) and *order* ≥ (*specified order* + *range*).

Additionally, there are two reject swap options in **Other Settings**. When **enabled**, if a teammate requests to swap hero or slot with you and the request does not meet the criteria, it will automatically reject the swap request. **Otherwise**, no action will be taken, and you can decide whether to accept the swap yourself.

## Ban/Pick Hero Quit Prevention
When this option is enabled, it will automatically **pick** or **ban** a hero in the last second of the BP phase.

> You can change the mode settings for the **Ban/Pick Hero Quit Prevention** function on the *Feature Settings Page*.

## AFK Auto-Reply
This toggle is the main switch; you need to perform additional settings. On the **More** configuration page, set whether to automatically reply to friend messages or match invitations when you leave (each option is enabled by default), and set the reply text content.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/68f9e16f-7263-4924-954f-8e4f880a4007" />

## Additional Window
When enabled, an **Additional Window** will be displayed during certain client phases. In addition, you can enter the **Additional Window**'s **Configuration Page** via the button next to this toggle, where you can also view the hero's **balance attributes** in currently available fun modes (if any), and configure available rune setups and client-specific configurations for each mode.

**Additional Window** Configuration Page</br>
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/dd7a6d53-177e-4132-b612-20aaf4a4d2e6" />
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/7675278c-5ed8-4d0d-9248-d8ef8b07201d" />

> If you want to add or update a hero's rune setup in the **Rune Setup Page**, you need to select a rune page to edit and save in the game client's **Collection - Runes**, then change the summoner spell in the upper right and press the **Add Setup** button or the *Update current game setup to this configuration* button in the rune setup you want to update, to add or update the rune setup.

**Additional Window**</br>
<img width="388" height="650" alt="image" src="https://github.com/user-attachments/assets/b7a1df40-f496-4c8a-a540-54806fc8d3f4" />

## Auto Close Match
Simply put, it will automatically close the game process when the end-of-match crystal destruction animation is played.

## Auto Reconnect Match
Attempts to reconnect automatically when the game needs to be reconnected.

## Auto Card Picking (Extra Extension)
When playing as Twisted Fate in the current game, use Z/X/C keys to automatically select Blue/Red/Yellow cards.

![pickCards](https://github.com/user-attachments/assets/df5aa45a-8593-44c9-8c3f-bec315552113)

> This feature is implemented via graphic processing and keyboard emulation, and is currently only tested on the two most common resolutions (1920x1080/2560x1440). Other resolutions will not function properly unless configured manually (especially resolutions outside of the 16:9 aspect ratio). The detection allows for some filter range, but it is recommended not to use filters while using this feature to avoid making some detections invalid.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---