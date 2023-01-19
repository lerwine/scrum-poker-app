Add-Type -AssemblyName 'System.Security.Cryptography' -ErrorAction Stop;

$Rng = [System.Security.Cryptography.RandomNumberGenerator]::Create();
$Data = New-Object -TypeName 'System.Byte[]' -ArgumentList 32;
$Rng.GetBytes($Data);
Write-Information -MessageData "Decrypted Token: $([Convert]::ToHexString($Data).ToLower())" -InformationAction Continue;
$EData = [System.Security.Cryptography.ProtectedData]::Protect($Data, $null, [System.Security.Cryptography.DataProtectionScope]::LocalMachine);
Write-Information -MessageData "Encrypted Token: $([Convert]::ToBase64String($EData, [System.Base64FormattingOptions]::None))" -InformationAction Continue;
