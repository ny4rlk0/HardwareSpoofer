@echo off&& color a && cls
::edksetup.bat
::build all -p NyarlkoEfiSpooferPkg/NyarlkoEfiSpooferPkg.dsc -b RELEASE -a X64 -n 0
cd ".\Build\NyarlkoEfiSpooferPkg\RELEASE_VS2019\X64"
del "C:\msys64\home\asus\edk2\Build\NyarlkoEfiSpooferPkg\RELEASE_VS2019\X64\image\BOOTX64.EFI"
copy "C:\msys64\home\asus\edk2\Build\NyarlkoEfiSpooferPkg\RELEASE_VS2019\X64\NyarlkoEfiSpooferApplication.efi" "C:\msys64\home\asus\edk2\Build\NyarlkoEfiSpooferPkg\RELEASE_VS2019\X64\image"
cd image
rename NyarlkoEfiSpooferApplication.efi BOOTX64.EFI
CMD /C "write_gpt.exe"
CMD /C "qemu.bat"
cd "../../../../../"
