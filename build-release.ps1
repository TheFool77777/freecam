param(
    [string]$GoghDir = $env:GOGH_DIR
)

$ErrorActionPreference = 'Stop'

$buildArgs = @('build', '.\freecam.csproj', '-c', 'Release')
if (-not [string]::IsNullOrWhiteSpace($GoghDir)) {
    $buildArgs += "-p:GoghDir=$GoghDir"
}

& dotnet @buildArgs
if ($LASTEXITCODE -ne 0) {
    exit $LASTEXITCODE
}

$stage = Join-Path $PSScriptRoot 'artifacts\freecam'
$zip = Join-Path $PSScriptRoot 'artifacts\freecam.zip'

New-Item -ItemType Directory -Force -Path $stage | Out-Null
Copy-Item .\bin\Release\freecam.dll $stage -Force
Copy-Item .\README.md $stage -Force
Copy-Item .\LICENSE $stage -Force

if (Test-Path $zip) { Remove-Item $zip -Force }
Compress-Archive -Path "$stage\*" -DestinationPath $zip -Force
Write-Host "Release package: $zip"
