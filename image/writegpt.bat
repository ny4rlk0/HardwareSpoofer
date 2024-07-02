@echo off%%color a &&cls
del BOOTX64.EFI
rename NyarlkoEfiSpooferApplication.efi BOOTX64.EFI
write_gpt.exe
qemu.bat
pause