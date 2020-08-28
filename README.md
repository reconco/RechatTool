# RechatTool
Command line tool to download the chat log from a Twitch VOD. Saves the full JSON data and optionally processes it to produce a simple text file. Requires .NET Framework 4.6+.

Sample usage:
```
RechatTool -D 111111111
```
Downloads the chat replay for video ID 111111111 and saves the .json and processed .txt output in the current directory.

Run without any arguments to see full list of modes.

# RechatTool_GUI
WPF로 제작된 GUI 버전입니다. (닷넷프레임워크 4.5.2 이상 요구)
RechatTool과 함께 컴파일하여 동일한 폴더에 있어야합니다.
트위치 URL 주소를 사용합니다.

이 프로젝트는 RechatTool 에서 포크되었습니다 - https://github.com/jdpurcell/RechatTool

This is GUI version of WPF. (Requires .NET Framework 4.5.2+.)
Compile with RechatTool and be in the same folder.
Use the Twitch VOD URL address.

This project was forked in RechatTool - https://github.com/jdpurcell/RechatTool
