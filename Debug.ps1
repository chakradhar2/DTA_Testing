iwr -Uri https://raw.githubusercontent.com/nigurr/DTA_Testing/patch-1/vstest.discoveryengine.exe.config -OutFile vstest.discoveryengine.exe.config
iwr -Uri https://raw.githubusercontent.com/nigurr/DTA_Testing/patch-1/vstest.discoveryengine.x86.exe.config -OutFile vstest.discoveryengine.x86.exe.config
iwr -Uri https://raw.githubusercontent.com/nigurr/DTA_Testing/patch-1/vstest.executionengine.exe.config -OutFile vstest.executionengine.exe.config
iwr -Uri https://raw.githubusercontent.com/nigurr/DTA_Testing/patch-1/vstest.executionengine.x86.exe.config -OutFile vstest.executionengine.x86.exe.config

cp -Force .\*.exe.config 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow' -Verbose

New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.executionengine.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.executionengine.x86.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.discoveryengine.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.discoveryengine.x86.exe"

New-ItemProperty "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.executionengine.exe" -Name GlobalFlag -Value 512
New-ItemProperty "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.executionengine.x86.exe" -Name GlobalFlag -Value 512
New-ItemProperty "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.discoveryengine.exe" -Name GlobalFlag -Value 512
New-ItemProperty "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\vstest.discoveryengine.x86.exe" -Name GlobalFlag -Value 512

New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SilentProcessExit"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SilentProcessExit\vstest.executionengine.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SilentProcessExit\vstest.executionengine.x86.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SilentProcessExit\vstest.discoveryengine.exe"
New-Item "Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SilentProcessExit\vstest.discoveryengine.x86.exe"
