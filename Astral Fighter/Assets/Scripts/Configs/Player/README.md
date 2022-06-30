# Setting up a new player
**Last Updated *(yyyy/mm/dd)*:**   *2022/06/29* **by** Connor
**Repository:** [Astral-Fighter](https://github.com/Connor-Schulz/Astral-Fighter/pulse)

### Format
```json
{
	"healthMax": <int>,
	"healthCurrent": <int>,
	"mass": <int>,
	"runSpeed": <int>,
	"jumpHeight": <int>,
	"playerName": <str>,
	"keyBindingFile": <str>
}
```
1. Create a new file in the [Player Config](https://github.com/Connor-Schulz/Astral-Fighter/tree/main/Astral%20Fighter/Assets/Scripts/Configs/Player) directory and give it any name you want and remember to save it as a `.json`.
	> **example:** `newPlayer.json` 
2. Copy the format listed above and replace the values between the <> characters with a appropriate value with respect to the guidelines in the table below.
---
| Key |Description  |Format |
|--|--|--|
| **healthMax:**| The maximum amount of health the player can have | Positive Int|
| **healthCurrent:**| Tracks the current amount of health that a player has. This value represents how much health the player spawns with | Positive Int less than **healthMax**|
| **mass:**| The weight of the player ***(units currently not decided)*** | Positive Int |
| **runSpeed:**| The speed that the player runs ***(units currently not decided)*** | Positive Int|
| **jumpHeight:**| The height that the player jumps ***(units currently not decided)*** | Positive Int|
| **playerName:**| The official "screen name" for the player | non-empty String|
| **keyBindingFile:**| the file name of a key binding config from [this](https://github.com/Connor-Schulz/Astral-Fighter/tree/main/Astral%20Fighter/Assets/Scripts/Configs/KeyBindings) folder | Valid key binding file name

## Example File
```json
{
	"healthMax": 100,
	"healthCurrent": 100,
	"mass": 100,
	"runSpeed": 100,
	"jumpHeight": 100,
	"playerName": "Default",
	"keyBindingFile": "P1_DEFAULT.json"
}
```
