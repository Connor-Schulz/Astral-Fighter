# Setting up a new key mapping
**Last Updated *(yyyy/mm/dd)*:**   *2022/06/29* **by** Connor
**Repository:** [Astral-Fighter](https://github.com/Connor-Schulz/Astral-Fighter/pulse)

### Format
```json
{
	"moveLeft": <key>,
	"moveRight": <key>,
	"jump": <key>,
	"attack": <key>,
	"projectile": <key>
}
```
1. Create a new file in the [Key Binding](https://github.com/Connor-Schulz/Astral-Fighter/tree/main/Astral%20Fighter/Assets/Scripts/Configs/KeyBindings) directory and give it any name you want and remember to save it as a `.json`.
	> **example:** `newBinding.json` 
2. Copy the format listed above and replace the values between the <> characters with any key name in the table from [this web page](https://docs.unity3d.com/ScriptReference/KeyCode.html).
3. To apply it to a character, see the instructions on [this](https://github.com/Connor-Schulz/Astral-Fighter/tree/main/Astral%20Fighter/Assets/Scripts/Configs/Player) page

## Example File A
```json
{
	"moveLeft": "A",
	"moveRight": "D",
	"jump": "W",
	"attack": "G",
	"projectile": "H"
}
```
## Example File B
```json
{
	"moveLeft": "LeftArrow",
	"moveRight": "RightArrow",
	"jump": "UpArrow",
	"attack": "Keypad1",
	"projectile": "Keypad2"
}
```