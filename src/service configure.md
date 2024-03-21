



### Dotnet aplikacijos sukonfigūravimas kaip windows serviso

Šitaip servisą reikia sukonfigūruoti, kad nereiktų jo leisti per IIS.  
Per IIS nenorim leist, nes daug vargo padaryt kad veiktų SQLite duomenų bazė.  
SQLite db norime naudoti, nes be reikalo užkraunamas geolis2 su intraneto duomenim.  

Pagrindinis straipsnis čia: https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/windows-service?view=aspnetcore-6.0&tabs=visual-studio

```powershell
	New-LocalUser -Name IntranetService 
	- pa$$word
```


```powershell
$acl = Get-Acl "{EXE PATH}"
$aclRuleArgs = "{DOMAIN OR COMPUTER NAME\USER}", "Read,Write,ReadAndExecute", "ContainerInherit,ObjectInherit", "None", "Allow"
$accessRule = New-Object System.Security.AccessControl.FileSystemAccessRule($aclRuleArgs)
$acl.SetAccessRule($accessRule)
$acl | Set-Acl "{EXE PATH}"

New-Service -Name {SERVICE NAME} -BinaryPathName "{EXE FILE PATH} --contentRoot {EXE FOLDER PATH}" -Credential "{DOMAIN OR COMPUTER NAME\USER}" -Description "{DESCRIPTION}" -DisplayName "{DISPLAY NAME}" -StartupType Automatic
```

|Var|Val|
|---|---|
|{EXE PATH}|C:\IIS\Intranet\Live|
|{DOMAIN OR COMPUTER NAME\USER}|OPALAS\IntranetService|
|{SERVICE NAME}||
|{EXE FILE PATH}||
|{EXE FOLDER PATH}||
|{DESCRIPTION}||
|{DISPLAY NAME}||
