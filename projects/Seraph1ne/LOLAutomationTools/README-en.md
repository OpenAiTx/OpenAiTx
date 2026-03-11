# Introduction
**LOLAutomationTools** is a functional extension tool for **League of Legends**; it helps players perform some simple client operations in scenarios where they cannot free their hands or need to step away temporarily, saving a small amount of time; the software does not overly interfere with the player's understanding and gameplay of the game, so some functions still require manual configuration first (such as champion rune setup). Excessive constraints can cause numbness and take away the fun of the game itself; play actively and happily, and build a harmonious environment together.

# Features
- Champion selection
  - Pre-select champion
- Champion ban
  - Ignore team ban
  - Group ban mode
- Random champion
- Ban pick anti-leave
- Accept match
  - Delayed accept match
- Create match
- Find match
  - Match timeout detection
- Swap function
  - Random mode champion swap
    - Or only passively accept other players’ champion swaps
    - Reject swaps of non-selected champions
  - Draft mode swap pick position
    - Or passively receive other players’ pick position swaps
    - Reject swaps of non-preselected positions
  - Draft mode swap lane
    - Or only passively accept other players’ lane swaps
    - Reject swaps of non-configured lanes
- Skip commendation page
- Skip unlock page
- Chat reply control
  - Reply to friend messages when away
  - Reply to match invites when away
    - Reject match invites when away
- Additional windows
  - Fun mode champion balance BUFF display
  - Auto-apply runes
  - Rune error correction
  - Independent champion configuration
- Auto close match
- Auto reconnect match
- Auto claim pass rewards (including Teamfight Tactics)
- Friend Request Handling
  - Batch Delete Friends
- Personalized Career
  - Career Background
  - Summoner Avatar
  - Client Status
  - Status Signature
  - Business Card Rank
  - Hero Achievement Points
  - Clear Equipped Medals
- Function Key Blocking
- Match Record Inquiry
  - Match Record Sending
  - In-Game Team Detection
  - Player Match Spectating
  - Post-Match Player Reporting
- In-Game Shoutouts
- Blacklist
- Hotkey Settings
- Theme Settings
  - Dark/Light Theme
  - Adaptive Theme
  - Custom Theme
  - Background Image Settings
  - Font Customization
- Extended Features
  - Auto Pick (Card Master)


## Hero Selection
Before using **Hero Selection** and **Hero Banning**, editing operations must be performed on the configuration page (the button next to the toggle).

Heroes added in the lane settings only take effect in some match modes with *preset slots* (such as *Ranked* and *Extreme Blitz*), random only takes effect in *Random Hero* modes (such as *ARAM*, *URF*, and random is not included in the hero ban configuration page), general applies to all other modes (excluding the modes listed above, for usage standardization). When executing auto hero selection, it will follow the **Hero Selection** configuration items in a top-down order.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/6aa4f1ad-28db-4bd5-a917-df4197024f5f" />

## Pre-Selected Heroes
The execution logic of this feature is basically the same as **Hero Selection**, except that **Pre-Selected Heroes** only take effect in modes with a banning phase, such as *Ranked* and some entertainment modes that require hero bans.

## Hero Banning
**Disabled Heroes** configuration page is basically the same as the **Selected Heroes** configuration page, with an additional mode switch button in the upper right corner. Clicking the button can switch to the disable mode.

*Normal Disable Mode*: This mode operates with the same logic as the **Selected Heroes** configuration page. When automatically disabling heroes, if no heroes are configured to be disabled, an empty ban will occur at 0 seconds remaining in the Ban phase.

*Group Disable Mode*: The items in the configuration list will be replaced by the corresponding heroes from the **Selected Heroes** configuration. When selecting an item, double-click the hero on the left side to add it to the hero’s **Disable Group**. When automatically disabling heroes, it will disable according to the order of the **Selected Heroes** configuration items. If none of the **Selected Heroes** configurations’ **Disable Groups** have heroes to disable, it will follow the logic of the normal disable mode.

> If *Ignore Teammate Preselection* is enabled, automatic hero disabling will skip the team preselection check. It is not recommended to enable this option.

## Accept Match
Automatically accept the match after it is found.

> When *Delayed Accept Match* option is enabled, **Accept Match** will only automatically accept the match at the last second of the accept countdown.

## Create Match
You can manually create a match by clicking the **Create Match** button or enable this switch to automatically create matches.

> *Auto Create Match* requires selecting the match mode to create in *More Settings*. This option will not be saved in the configuration.

## Find Match
Automatically find matches. This option only takes effect when in match mode room and you are the team owner (host).

> If *Timeout Detection* is enabled, it will automatically find a new match when the queue time exceeds the estimated queue time by the specified interval.

## Skip Praise
Skip the teammates’ praise page at the end of the match.

## Skip Settlement
Skip the waiting settlement (black screen loading spinner) or post-match settlement page at the end of the match and return to the match mode room.

## Swap Feature
Includes a main toggle and three independent toggles. Additional settings are required. In **Swap Feature** more settings, you can configure whether to swap heroes with teammates in Random Hero mode, or swap picks (selection order) and preselection slots with teammates in Draft mode.

*Swap hero and swap pick settings are relatively simple and will not be elaborated here.*

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/361b4b19-cd72-4cb3-901f-69d49284bc11" />

In **Swap Pick** > **More Settings**, you can set the swap order (pick order) and swap mode.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/697bed4a-2984-43f6-b747-36c7911ef99d" />

*Exchange Mode*:
- Target Order Only: Accept requests from teammates whose order matches the specified *order* exactly.
- Priority Including Target: Accept requests from teammates with order ≤ the specified *order*.
- Delay Including Target: Accept requests from teammates with order ≥ the specified *order*.
- Range Based on Target Order: Accept requests from teammates with *order* ≤ (*specified order* - *range*) and *order* ≥ (*specified order* + *range*).

Additionally, in **Other Settings**, there are two reject exchange options. When **enabled**, if a teammate's request to swap heroes or positions does not meet the judgment criteria, the exchange request will be automatically rejected; **otherwise**, no action is taken, and you can decide whether to accept the swap.

## Ban Hero Anti-Retreat
When enabled, the **select hero** or **ban hero** actions will be executed in the last second of the BP phase.

> You can change the mode settings of the **Ban Hero Anti-Retreat** feature on the *Function Settings Page*.

## AFK Reply
This toggle is the main switch; you need to make other settings as well. On the **More** configuration page, set whether to automatically reply to friend messages or match invitations when leaving (both enabled by default), and set the reply text content.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/68f9e16f-7263-4924-954f-8e4f880a4007" />

## Additional Window
When enabled, the **Additional Window** will appear during certain client phases. Moreover, you can enter the **Additional Window**'s **Configuration Page** by clicking the button behind this toggle. Here, you can also view the hero’s **balance attributes** in the currently available entertainment modes (if any) and configure rune setups and client-independent settings for each mode.

**Additional Window** Configuration Page</br>
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/dd7a6d53-177e-4132-b612-20aaf4a4d2e6" />
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/7675278c-5ed8-4d0d-9248-d8ef8b07201d" />

> To add or update a hero’s rune configuration on the **Rune Configuration Page**, you need to select and save a rune page in the game client’s **Collection - Runes**, then change the summoner spells from the top right and press the **Add Configuration** button or the *Update current game configuration to this config* button in the rune configuration item to add or update the rune setup.

**Additional Window**</br>
<img width="388" height="650" alt="image" src="https://github.com/user-attachments/assets/b7a1df40-f496-4c8a-a540-54806fc8d3f4" />

## Auto Close Match
Straightforward: automatically close the game process when the crystal destruction animation plays at the end of the match.

## Auto Reconnect Match
Attempt to reconnect when the game requires reconnection.

## Auto Card Pick (Extra Extension)
When the current hero in the game is Twisted Fate, use Z/X/C keys to automatically pick Blue/Red/Yellow cards.

![pickCards](https://github.com/user-attachments/assets/df5aa45a-8593-44c9-8c3f-bec315552113)
> This feature is implemented using graphics processing and keyboard simulation, and has only been tested on two commonly used resolutions (1920x1080/2560x1440). Other resolutions will not function properly without manual configuration (especially resolutions with an aspect ratio other than 16:9). The detection allows for a certain range of filters, but it is recommended not to enable filters when using this feature to avoid invalid detection.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---